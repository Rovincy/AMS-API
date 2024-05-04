using AutoMapper;
using DCI_TSP_API.Dto.Parents;
using DCI_TSP_API.Dto.PaymentAdvice;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.Json;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentAdviceController : Controller
    {
        private readonly AfsContext _context;
        private readonly RxDBContext _RxContext;
        private readonly IMapper mapper;
        public PaymentAdviceController(AfsContext context, RxDBContext RxContext, IMapper mapper)
        {
            _context = context;
            _RxContext = RxContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult<PaymentAdvice>> AddPaymentAdvice(PaymentAdviceCreateDto paymentAdviceDto)
        {
            //var paymentAdvice = mapper.Map<PaymentAdvice>(paymentAdviceDto);
            //await _context.PaymentAdvices.AddAsync(paymentAdvice);
            //await _context.SaveChangesAsync();

            //return Ok(paymentAdvice.Id);
            var paidAmount = paymentAdviceDto.Amount;
            double? change = null;
            double? balance = 0;
            _RxContext.Database.SetCommandTimeout(900); // Set the timeout to 300 seconds (5 minutes)
            var result = _RxContext.ProviderClaims
            .FromSqlRaw(@"
     WITH ProviderClaims AS (
    SELECT 
    P.facility_name, 
    LAST_DAY(CL.date_of_consultation) as EndOfMonth, 
    CONCAT('Total Claim for',' ',DATE_FORMAT(CL.date_of_consultation, '%b %Y')) as Description,
    P.tax_rate,
    COALESCE(SUM(CL.qty * CL.unit_price), 0) as Amount,
			COALESCE(SUM(CL.qty * CL.unit_price) - COALESCE((SUM(CL.qty * CL.unit_price) - SUM(CL.qty_finance * CL.unit_price_finance)),0), 0) as AmountToPay,
			COALESCE(SUM(CL.qty * CL.unit_price) - SUM(CL.qty_finance * CL.unit_price_finance), 0) as RejectedAmount,
			COALESCE((SUM(CL.qty * CL.unit_price) - COALESCE((SUM(CL.qty * CL.unit_price) - SUM(CL.qty_finance * CL.unit_price_finance)),0))*P.tax_rate/100, 0) as WithholdingTax,
			0.00 as Balance
FROM 
    provider_api P
JOIN 
    claims_details CL ON CL.provider_id = P.provider_id
WHERE 
    P.provider_id ={0}
    AND CL.date_of_consultation >= '2023-01-01'
GROUP BY 
    LAST_DAY(CL.date_of_consultation), 
    Description,
    P.facility_name,
    P.tax_rate
)

SELECT 
    EndOfMonth,
    Description,
    facility_name,
    tax_rate,
    SUM(Amount) as TotalAmount,
		AmountToPay,
		RejectedAmount,
		WithholdingTax,
        Balance
FROM ProviderClaims
GROUP BY 
    EndOfMonth,
    Description,
    facility_name,
    tax_rate;
            ", paymentAdviceDto.ProviderId!)
            .ToList();

            List<object> proClaim = new List<object>();
            foreach (var item in result)
            {
                if (item.Description.Contains("Total Claim for"))
                {
                    var providerPayments = _context.PaymentAdvices.Where(x => x.ProviderId == paymentAdviceDto.ProviderId && x.Month.Year == item.EndOfMonth.Year &&
                    //var providerPayments = _context.PaymentAdvices.Where(x => x.ProviderId == paymentAdviceDto.ProviderId && x.Month.Year == item.EndOfMonth.Year &&
                   x.Month.Month == item.EndOfMonth.Month).ToList();
                    var sumOfAmountPaid=0.0;
                    foreach (var payment in providerPayments)
                    {
                        sumOfAmountPaid = sumOfAmountPaid + payment.Amount;
                        Console.WriteLine(payment.Month.ToString("MMMM yyyy"));
                        Console.WriteLine(item.EndOfMonth.ToString("MMMM yyyy"));
                        Console.WriteLine(payment.ProviderId);
                        Console.WriteLine(payment.Amount);
                        Console.WriteLine("Amount to pay: "+item.AmountToPay);
                        Console.WriteLine("Amount paid: "+payment.Amount);
                        Console.WriteLine(" ");
                    }
                        Console.WriteLine("sumOfAmountPaid: " + sumOfAmountPaid);
                        var finalResult = item.AmountToPay - (decimal)sumOfAmountPaid;
                        Console.WriteLine("Final Result for that month: "+finalResult);
                        Console.WriteLine(" ");
                    //if(paymentAdviceDto.Amount>= (double)finalResult) { 
                    //    Console.WriteLine("Payment for this said month");
                    //}
                    if(sumOfAmountPaid >= (double)item.AmountToPay) { 
                        Console.WriteLine("No outstanding amount for "+item.EndOfMonth.ToString("MMMM yyyy"));
                    }
                    else
                    {
                        //if (change != null)
                        //{
                        //    paidAmount = change;
                        //    //change = 0;
                        //}

                        if (sumOfAmountPaid>paidAmount)
                        {
                            change = 0;
                        }
                        else
                        {
                            
                            change = (double)item.AmountToPay - sumOfAmountPaid - paidAmount;
                            if (change<0)
                            {
                                change = change * (-1);
                            }
                            else
                            {
                                balance = change * (-1);
                                change = 0;

                                if (balance<0)
                                {
                                    balance = balance * (-1);
                                }
                            }
                        }
                        var netPaid = paidAmount - change;
                        Console.WriteLine("New payment of " + netPaid + " made for " + item.EndOfMonth.ToString("MMMM yyyy"));
                        Console.WriteLine("Change: " + change);
                        Console.WriteLine("Balance: " + balance);
                        Console.WriteLine("NetPaid: " + netPaid);
                        paidAmount = change;
                        //var parent = mapper.Map<Parent>(parentDto);
                        if (netPaid>0)
                        {
                            PaymentAdvice paymentAdvice = new PaymentAdvice();
                            paymentAdvice.ProviderId = (int)paymentAdviceDto.ProviderId!;
                            //paymentAdvice.Month = item.EndOfMonth.ToString("dd-MM-yyyy HH:mm:ss");
                            // Convert item.EndOfMonth to a formatted string
                            string formattedDateTime = item.EndOfMonth.ToString("yyyy-MM-dd HH:mm:ss");
                            // Parse the formatted string to a DateTime
                            DateTime parsedDateTime = DateTime.ParseExact(formattedDateTime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                            // Save the parsed DateTime to paymentAdvice.Month
                        //Console.WriteLine("item.EndOfMonth: " + parsedDateTime);
                        //Console.WriteLine("formattedDateTime: " + formattedDateTime);
                        //Console.WriteLine("Converted formattedDateTime: " +DateTime.Parse(formattedDateTime));
                            paymentAdvice.Month = parsedDateTime;
                            paymentAdvice.Amount = (double)netPaid!;
                            paymentAdvice.Description = netPaid + sumOfAmountPaid < (double)item.AmountToPay ? "Part payment for " + item.EndOfMonth.ToString("MMMM yyyy") : "Full payment for " + item.EndOfMonth.ToString("MMMM yyyy");
                            paymentAdvice.Timestamp = DateTime.UtcNow;
                            paymentAdvice.Type = paymentAdviceDto.Type;
                            paymentAdvice.CheckNumber = paymentAdviceDto.CheckNumber;
                            paymentAdvice.BankId = paymentAdviceDto.BankId;

                            // Create a string representation of paymentAdvice and add it to the proClaim list
                            //string paymentAdviceString = $"{paymentAdvice.ProviderId}, {paymentAdvice.Month}, {paymentAdvice.Amount}, {paymentAdvice.Description}, {paymentAdvice.Timestamp}, {paymentAdvice.Type}, {paymentAdvice.CheckNumber}, {paymentAdvice.BankId}";
                            //proClaim.Add(paymentAdviceString);
                            
                        await _context.PaymentAdvices.AddAsync(paymentAdvice);
                            var providerBalanceResult = _RxContext.ProviderClaims
            .FromSqlRaw(@"
     SELECT 
  '0000-00-00' as EndOfMonth,
  '' as  Description,
    facility_name,
   0.00 as tax_rate,
   0.00 as TotalAmount,
	 0.00 as AmountToPay,
	 0.00 as RejectedAmount,
	 0.00 as WithholdingTax,
    SUM(balance) as Balance
FROM (
    SELECT 
        endOfMonth,
        facility_name,
        SUM(debit) as totalDebit,
        SUM(credit) as totalCredit,
        SUM(credit) - SUM(debit) as balance,
        MAX(paymentId) as paymentId
    FROM (
        SELECT 
            LAST_DAY(CL2.date_of_consultation) as endOfMonth,
            P2.facility_name as facility_name,
            0 as debit,
            SUM(CL2.qty * CL2.unit_price) as credit,
            null as paymentId
        FROM 
            claims_details CL2
        INNER JOIN 
            provider_api P2 ON P2.provider_id = CL2.provider_id
         WHERE
		CL2.date_of_consultation > '0000-00-00'
            and CL2.provider_id={0}
        GROUP BY 
            LAST_DAY(CL2.date_of_consultation), P2.facility_name

        UNION

        SELECT 
            LAST_DAY(CL2.date_of_consultation) as endOfMonth,
            P2.facility_name as facility_name,
            COALESCE(SUM(CL2.qty * CL2.unit_price) - sum(qty_finance*unit_price_finance), 0) as debit,
            0 as credit,
            null as paymentId
        FROM 
            claims_details CL2
        INNER JOIN 
            provider_api P2 ON P2.provider_id = CL2.provider_id
         WHERE
		CL2.date_of_consultation > '0000-00-00'
            and CL2.provider_id={0}
        GROUP BY 
            LAST_DAY(CL2.date_of_consultation), P2.facility_name

        UNION

        SELECT 
            LAST_DAY(CL2.date_of_consultation) as endOfMonth,
            P2.facility_name as facility_name,
            (SUM(CL2.qty * unit_price) - COALESCE(SUM(CL2.qty * CL2.unit_price) - sum(qty_finance*unit_price_finance), 0)) * P2.tax_rate / 100 as debit,
            0 as credit,
            null as paymentId
        FROM 
            claims_details CL2
        INNER JOIN 
            provider_api P2 ON P2.provider_id = CL2.provider_id
         WHERE
		CL2.date_of_consultation > '0000-00-00'
            and CL2.provider_id={0}
        GROUP BY 
            LAST_DAY(CL2.date_of_consultation), P2.facility_name

        UNION

        SELECT 
            PA.`timestamp` as endOfMonth,
            P2.facility_name as facility_name,
            (CASE WHEN type='Debit' THEN PA.amount ELSE 0 END) as debit,
            (CASE WHEN type='Credit' THEN PA.amount ELSE 0 END) as credit,
            PA.id as paymentId
        FROM 
            payment_advice PA,
            provider_api P2
        WHERE 
		PA.timestamp > '0000-00-00' and
            PA.providerId={0}
            AND 
						PA.providerId=P2.provider_id
    ) as Result
    GROUP BY 
        endOfMonth, facility_name
) as AggregatedResults
GROUP BY 
    facility_name
ORDER BY 
    facility_name;

            ", paymentAdviceDto.ProviderId)
            .ToList();
                            var dataObject = new
                            {
                                providerId= paymentAdviceDto.ProviderId,
                                facility_name = item.facility_name,
                                month = item.EndOfMonth.ToString("MMMM yyyy"),
                                claimedAmount = item.TotalAmount,
                                amountPaid= netPaid!,
                                RejectedAmount = item.RejectedAmount,
                                WithholdingTax = item.WithholdingTax,
                                Description = paymentAdvice.Description,
                                Balance = providerBalanceResult[0].Balance,

                            };                            
                            proClaim.Add(dataObject);
                            //await _context.PaymentAdvices.AddAsync(paymentAdvice);
                        }
                        balance = 0;
                        await _context.SaveChangesAsync();
                        //await _context.SaveChangesAsync();
                    }
                }
                //Console.WriteLine(item.Description);
                //Console.WriteLine(item.TotalAmount);
                //Console.WriteLine(proClaim.ToList());
            }
            return Ok(proClaim.ToList());
        }

        [HttpGet]
        public async Task<ActionResult> GetProviderPayments(int providerId)
        {
            //List<PaymentAdvice> paymentAdvice = await _context.PaymentAdvices.ToListAsync();
            //List<PaymentAdvice> paymentAdvice = await _context.PaymentAdvices.OrderByDescending(pa => pa.Id).ToListAsync();
            _RxContext.Database.SetCommandTimeout(900); // Set the timeout to 300 seconds (5 minutes)
            var result = _RxContext.ProviderClaims
            .FromSqlRaw(@"
     SELECT 
  '0000-00-00' as EndOfMonth,
  '' as  Description,
    facility_name,
   0.00 as tax_rate,
   0.00 as TotalAmount,
	 0.00 as AmountToPay,
	 0.00 as RejectedAmount,
	 0.00 as WithholdingTax,
    SUM(balance) as Balance
FROM (
    SELECT 
        endOfMonth,
        facility_name,
        SUM(debit) as totalDebit,
        SUM(credit) as totalCredit,
        SUM(credit) - SUM(debit) as balance,
        MAX(paymentId) as paymentId
    FROM (
        SELECT 
            LAST_DAY(CL2.date_of_consultation) as endOfMonth,
            P2.facility_name as facility_name,
            0 as debit,
            SUM(CL2.qty * CL2.unit_price) as credit,
            null as paymentId
        FROM 
            claims_details CL2
        INNER JOIN 
            provider_api P2 ON P2.provider_id = CL2.provider_id
         WHERE
		CL2.date_of_consultation > '0000-00-00'
            and CL2.provider_id={0}
        GROUP BY 
            LAST_DAY(CL2.date_of_consultation), P2.facility_name

        UNION

        SELECT 
            LAST_DAY(CL2.date_of_consultation) as endOfMonth,
            P2.facility_name as facility_name,
            COALESCE(SUM(CL2.qty * CL2.unit_price) - sum(qty_finance*unit_price_finance), 0) as debit,
            0 as credit,
            null as paymentId
        FROM 
            claims_details CL2
        INNER JOIN 
            provider_api P2 ON P2.provider_id = CL2.provider_id
         WHERE
		CL2.date_of_consultation > '0000-00-00'
            and CL2.provider_id={0}
        GROUP BY 
            LAST_DAY(CL2.date_of_consultation), P2.facility_name

        UNION

        SELECT 
            LAST_DAY(CL2.date_of_consultation) as endOfMonth,
            P2.facility_name as facility_name,
            (SUM(CL2.qty * unit_price) - COALESCE(SUM(CL2.qty * CL2.unit_price) - sum(qty_finance*unit_price_finance), 0)) * P2.tax_rate / 100 as debit,
            0 as credit,
            null as paymentId
        FROM 
            claims_details CL2
        INNER JOIN 
            provider_api P2 ON P2.provider_id = CL2.provider_id
         WHERE
		CL2.date_of_consultation > '0000-00-00'
            and CL2.provider_id={0}
        GROUP BY 
            LAST_DAY(CL2.date_of_consultation), P2.facility_name

        UNION

        SELECT 
            PA.`timestamp` as endOfMonth,
            P2.facility_name as facility_name,
            (CASE WHEN type='Debit' THEN PA.amount ELSE 0 END) as debit,
            (CASE WHEN type='Credit' THEN PA.amount ELSE 0 END) as credit,
            PA.id as paymentId
        FROM 
            payment_advice PA,
            provider_api P2
        WHERE 
		PA.timestamp > '0000-00-00' and
            PA.providerId={0}
            AND 
						PA.providerId=P2.provider_id
    ) as Result
    GROUP BY 
        endOfMonth, facility_name
) as AggregatedResults
GROUP BY 
    facility_name
ORDER BY 
    facility_name;

            ", providerId)
            .ToList();
            return Ok(result);
        }

        [HttpPost("NewPaymentAdvice")]
        public async Task<ActionResult<PaymentAdvice>> NewAdvice(PaymentAdviceCreateDto paymentAdviceDto) {
            var year = paymentAdviceDto.Month?.Year;
            var month = paymentAdviceDto.Month?.Month;
            List<object> proClaim = new List<object>();
            _RxContext.Database.SetCommandTimeout(900); // Set the timeout to 300 seconds (5 minutes)
            var result = _RxContext.ProviderClaims
            .FromSqlRaw(@"
                 WITH ProviderClaims AS (
                SELECT 
                P.facility_name, 
                LAST_DAY(CL.date_of_consultation) as EndOfMonth, 
                CONCAT('Total Claim for',' ',DATE_FORMAT(CL.date_of_consultation, '%b %Y')) as Description,
                P.tax_rate,
                COALESCE(SUM(CL.qty * CL.unit_price), 0) as Amount,
            			COALESCE(SUM(CL.qty * CL.unit_price) - COALESCE((SUM(CL.qty * CL.unit_price) - SUM(CL.qty_finance * CL.unit_price_finance)),0), 0) as AmountToPay,
            			COALESCE(SUM(CL.qty * CL.unit_price) - SUM(CL.qty_finance * CL.unit_price_finance), 0) as RejectedAmount,
            			COALESCE((SUM(CL.qty * CL.unit_price) - COALESCE((SUM(CL.qty * CL.unit_price) - SUM(CL.qty_finance * CL.unit_price_finance)),0))*P.tax_rate/100, 0) as WithholdingTax,
            			0.00 as Balance
            FROM 
                provider_api P
            JOIN 
                claims_details CL ON CL.provider_id = P.provider_id
            WHERE 
                P.provider_id ={0}
                AND YEAR(CL.date_of_consultation) = {1} 
                AND MONTH(CL.date_of_consultation) = {2}
            GROUP BY 
                LAST_DAY(CL.date_of_consultation), 
                Description,
                P.facility_name,
                P.tax_rate
            )

            SELECT 
                EndOfMonth,
                Description,
                facility_name,
                tax_rate,
                SUM(Amount) as TotalAmount,
            		AmountToPay,
            		RejectedAmount,
            		WithholdingTax,
                    Balance
            FROM ProviderClaims
            GROUP BY 
                EndOfMonth,
                Description,
                facility_name,
                tax_rate;
                        ", paymentAdviceDto.ProviderId!,year!,month!)
                        .ToList();

            var paymentAdvice = mapper.Map<PaymentAdvice>(paymentAdviceDto);
            paymentAdviceDto.Timestamp = DateTime.Now;
            await _context.PaymentAdvices.AddAsync(paymentAdvice);
            await _context.SaveChangesAsync();


            var providerBalanceResult = _RxContext.ProviderClaims
.FromSqlRaw(@"
     SELECT 
  '0000-00-00' as EndOfMonth,
  '' as  Description,
    facility_name,
   0.00 as tax_rate,
   0.00 as TotalAmount,
	 0.00 as AmountToPay,
	 0.00 as RejectedAmount,
	 0.00 as WithholdingTax,
    SUM(balance) as Balance
FROM (
    SELECT 
        endOfMonth,
        facility_name,
        SUM(debit) as totalDebit,
        SUM(credit) as totalCredit,
        SUM(credit) - SUM(debit) as balance,
        MAX(paymentId) as paymentId
    FROM (
        SELECT 
            LAST_DAY(CL2.date_of_consultation) as endOfMonth,
            P2.facility_name as facility_name,
            0 as debit,
            SUM(CL2.qty * CL2.unit_price) as credit,
            null as paymentId
        FROM 
            claims_details CL2
        INNER JOIN 
            provider_api P2 ON P2.provider_id = CL2.provider_id
         WHERE
		CL2.date_of_consultation > '0000-00-00'
            and CL2.provider_id={0}
        GROUP BY 
            LAST_DAY(CL2.date_of_consultation), P2.facility_name

        UNION

        SELECT 
            LAST_DAY(CL2.date_of_consultation) as endOfMonth,
            P2.facility_name as facility_name,
            COALESCE(SUM(CL2.qty * CL2.unit_price) - sum(qty_finance*unit_price_finance), 0) as debit,
            0 as credit,
            null as paymentId
        FROM 
            claims_details CL2
        INNER JOIN 
            provider_api P2 ON P2.provider_id = CL2.provider_id
         WHERE
		CL2.date_of_consultation > '0000-00-00'
            and CL2.provider_id={0}
        GROUP BY 
            LAST_DAY(CL2.date_of_consultation), P2.facility_name

        UNION

        SELECT 
            LAST_DAY(CL2.date_of_consultation) as endOfMonth,
            P2.facility_name as facility_name,
            (SUM(CL2.qty * unit_price) - COALESCE(SUM(CL2.qty * CL2.unit_price) - sum(qty_finance*unit_price_finance), 0)) * P2.tax_rate / 100 as debit,
            0 as credit,
            null as paymentId
        FROM 
            claims_details CL2
        INNER JOIN 
            provider_api P2 ON P2.provider_id = CL2.provider_id
         WHERE
		CL2.date_of_consultation > '0000-00-00'
            and CL2.provider_id={0}
        GROUP BY 
            LAST_DAY(CL2.date_of_consultation), P2.facility_name

        UNION

        SELECT 
            PA.`timestamp` as endOfMonth,
            P2.facility_name as facility_name,
            (CASE WHEN type='Debit' THEN PA.amount ELSE 0 END) as debit,
            (CASE WHEN type='Credit' THEN PA.amount ELSE 0 END) as credit,
            PA.id as paymentId
        FROM 
            payment_advice PA,
            provider_api P2
        WHERE 
		PA.timestamp > '0000-00-00' and
            PA.providerId={0}
            AND 
						PA.providerId=P2.provider_id
    ) as Result
    GROUP BY 
        endOfMonth, facility_name
) as AggregatedResults
GROUP BY 
    facility_name
ORDER BY 
    facility_name;

            ", paymentAdviceDto.ProviderId!)
.ToList();
            var dataObject = new
            {
                providerId = paymentAdviceDto.ProviderId,
                facility_name = result[0].facility_name,
                month = result[0].EndOfMonth.ToString("MMMM yyyy"),
                claimedAmount = result[0].TotalAmount,
                amountPaid = paymentAdviceDto.Amount!,
                RejectedAmount = result[0].RejectedAmount,
                WithholdingTax = result[0].WithholdingTax,
                Description = paymentAdviceDto.Description,
                Balance = providerBalanceResult[0].Balance,

            };
            proClaim.Add(dataObject);

            return Ok(proClaim);
            //            var paidAmount = paymentAdviceDto.Amount;
            //            double? change = null;
            //            double? balance = 0;
            //            _RxContext.Database.SetCommandTimeout(900); // Set the timeout to 300 seconds (5 minutes)
            //            var result = _RxContext.ProviderClaims
            //            .FromSqlRaw(@"
            //     WITH ProviderClaims AS (
            //    SELECT 
            //    P.facility_name, 
            //    LAST_DAY(CL.date_of_consultation) as EndOfMonth, 
            //    CONCAT('Total Claim for',' ',DATE_FORMAT(CL.date_of_consultation, '%b %Y')) as Description,
            //    P.tax_rate,
            //    COALESCE(SUM(CL.qty * CL.unit_price), 0) as Amount,
            //			COALESCE(SUM(CL.qty * CL.unit_price) - COALESCE((SUM(CL.qty * CL.unit_price) - SUM(CL.qty_finance * CL.unit_price_finance)),0), 0) as AmountToPay,
            //			COALESCE(SUM(CL.qty * CL.unit_price) - SUM(CL.qty_finance * CL.unit_price_finance), 0) as RejectedAmount,
            //			COALESCE((SUM(CL.qty * CL.unit_price) - COALESCE((SUM(CL.qty * CL.unit_price) - SUM(CL.qty_finance * CL.unit_price_finance)),0))*P.tax_rate/100, 0) as WithholdingTax,
            //			0.00 as Balance
            //FROM 
            //    provider_api P
            //JOIN 
            //    claims_details CL ON CL.provider_id = P.provider_id
            //WHERE 
            //    P.provider_id ={0}
            //    AND CL.date_of_consultation >'0000-00-00'
            //GROUP BY 
            //    LAST_DAY(CL.date_of_consultation), 
            //    Description,
            //    P.facility_name,
            //    P.tax_rate
            //)

            //SELECT 
            //    EndOfMonth,
            //    Description,
            //    facility_name,
            //    tax_rate,
            //    SUM(Amount) as TotalAmount,
            //		AmountToPay,
            //		RejectedAmount,
            //		WithholdingTax,
            //        Balance
            //FROM ProviderClaims
            //GROUP BY 
            //    EndOfMonth,
            //    Description,
            //    facility_name,
            //    tax_rate;
            //            ", paymentAdviceDto.ProviderId!)
            //            .ToList();
            //            List<object> proClaim = new List<object>();
            //            //var providerPayments = _context.PaymentAdvices.Where(x => x.ProviderId == paymentAdviceDto.ProviderId).ToList();
            //            // Assuming _context is your database context
            //            var totalAmountEverPaid = _context.PaymentAdvices
            //                .Where(x => x.ProviderId == paymentAdviceDto.ProviderId)
            //                .Sum(x => x.Amount);

            //            Console.WriteLine("Before operation: "+ totalAmountEverPaid);
            //            foreach (var item in result)
            //            {
            //                if (item.Description!.Contains("Total Claim for"))
            //                {
            //                    totalAmountEverPaid = totalAmountEverPaid - (double)item.AmountToPay!;
            //            //Console.WriteLine("During operation: "+ totalAmountEverPaid);
            //                }
            //            }
            //            Console.WriteLine("After operation: "+ totalAmountEverPaid);
            //            return Ok(result);
        }
    }
}
