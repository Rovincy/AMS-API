//using DCI_TSP_API.RxModels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Security.Claims;

//public class AccountStatementController : ControllerBase
//{
//    private readonly RxDBContext _context;

//    public AccountStatementController(RxDBContext context)
//    {
//        _context = context;
//    }

//    [HttpGet]
//    public async Task<ActionResult<IEnumerable<ResultDto>>> GetData(string provider, DateTime startDate, DateTime endDate)
//    {
//        var query = (from claim in _context.ClaimsDetails
//                     join providerApi in _context.ProviderApis on claim.ProviderId equals providerApi.ProviderId
//                     where provider.Split(',').Contains(claim.ProviderId)
//                        && claim.DateOfConsultation >= startDate && claim.DateOfConsultation <= endDate
//                     group new { claim, providerApi } by new { LastDay = EF.Functions.Like(claim.DateOfConsultation.AddDays(-1), "%-01") } into grouped
//                     select new ResultDto
//                     {
//                         EndOfMonth = grouped.Key.LastDay,
//                         FacilityName = grouped.First().providerApi.FacilityName,
//                         Description = $"Total Claim for {grouped.Key.LastDay:MMM yyyy}",
//                         Debit = 0,
//                         Credit = grouped.Sum(x => x.claim.Qty * x.claim.UnitPrice),
//                         PaymentId = null
//                     })
//                    .Union(
//                    from claim in _context.ClaimsDetails
//                    join providerApi in _context.ProviderApis on claim.ProviderId equals providerApi.ProviderId
//                    where provider.Split(',').Contains(claim.ProviderId)
//                        && claim.DateOfConsultation >= startDate && claim.DateOfConsultation <= endDate
//                    group new { claim, providerApi } by new { LastDay = EF.Functions.Like(claim.DateOfConsultation.AddDays(-1), "%-01") } into grouped
//                    select new ResultDto
//                    {
//                        EndOfMonth = grouped.Key.LastDay,
//                        FacilityName = grouped.First().providerApi.FacilityName,
//                        Description = $"Total Rejected Amount for {grouped.Key.LastDay:MMM yyyy}",
//                        Debit = (grouped.Sum(x => x.claim.Qty * x.claim.UnitPrice) - grouped.Sum(x => x.claim.QtyFinance * x.claim.UnitPriceFinance)) ?? 0,
//                        Credit = 0,
//                        PaymentId = null
//                    })
//                    .Union(
//                    from claim in _context.ClaimsDetails
//                    join providerApi in _context.ProviderApis on claim.ProviderId equals providerApi.ProviderId
//                    where provider.Split(',').Contains(claim.ProviderId)
//                        && claim.DateOfConsultation >= startDate && claim.DateOfConsultation <= endDate
//                    group new { claim, providerApi } by new { LastDay = EF.Functions.Like(claim.DateOfConsultation.AddDays(-1), "%-01") } into grouped
//                    select new ResultDto
//                    {
//                        EndOfMonth = grouped.Key.LastDay,
//                        FacilityName = grouped.First().providerApi.FacilityName,
//                        Description = $"WithholdingTax for {grouped.Key.LastDay:MMM yyyy}",
//                        Debit = (claim.DateOfConsultation >= new DateTime(2021, 5, 1) && claim.DateOfConsultation <= new DateTime(2023, 1, 31)) ?
//                        0 :
//                                    (grouped.Sum(x => x.claim.Qty * x.claim.UnitPrice) - grouped.Sum(x => x.claim.QtyFinance * x.claim.UnitPriceFinance)) * x.providerApi.TaxRate / 100,
//                        Credit = 0,
//                        PaymentId = null
//                    })
//                    .Union(
//                    from paymentAdvice in _context.PaymentAdvices
//                    join providerApi in _context.ProviderApis on paymentAdvice.ProviderId equals providerApi.ProviderId
//                    where provider.Split(',').Contains(paymentAdvice.ProviderId)
//                        && paymentAdvice.Timestamp >= startDate && paymentAdvice.Timestamp <= endDate
//                    select new ResultDto
//                    {
//                        EndOfMonth = paymentAdvice.Timestamp,
//                        FacilityName = providerApi.FacilityName,
//                        Description = paymentAdvice.Description,
//                        Debit = (paymentAdvice.Type == "Debit") ? paymentAdvice.Amount : 0,
//                        Credit = (paymentAdvice.Type == "Credit") ? paymentAdvice.Amount : 0,
//                        PaymentId = paymentAdvice.Id
//                    });

//        var result = await query
//            .GroupBy(x => new { x.EndOfMonth, x.PaymentId, x.FacilityName, x.Description })
//            .Select(g => new ResultDto
//            {
//                EndOfMonth = g.Key.EndOfMonth,
//                FacilityName = g.Key.FacilityName,
//                Description = g.Key.Description,
//                Debit = g.Sum(x => x.Debit),
//                Credit = g.Sum(x => x.Credit),
//                PaymentId = g.Key.PaymentId
//            })
//            .OrderBy(x => x.PaymentId)
//            .ToListAsync();

//        return Ok(result);
//    }
//}

//public class ResultDto
//{
//    public DateTime EndOfMonth { get; set; }
//    public string FacilityName { get; set; }
//    public string Description { get; set; }
//    public decimal Debit { get; set; }
//    public decimal Credit { get; set; }
//    public int? PaymentId { get; set; }
//}
