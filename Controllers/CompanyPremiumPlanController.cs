using AutoMapper;
using DCI_TSP_API.Dto.CompanyPremiumPlan;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyPremiumPlanController : Controller
    {
        private readonly RxDBContext _context;
        private readonly AfsContext _afsContext;
        private readonly IMapper mapper;
        public CompanyPremiumPlanController(RxDBContext context,AfsContext afsContext, IMapper mapper)
        {
            _context = context;
            _afsContext = afsContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetProviders()
        {
            List<Company> company = await _context.Companies.OrderBy(x => x.company).ToListAsync();
            return Ok(company);
        }

        [HttpGet("getPremiumBalance")]
        //[HttpGet("getPremiumBalance/{year}")]
        //[Route("getPremiumBalance")]
        public async Task<ActionResult<IEnumerable<Company>>> GetPremiumPlan()
        {
            List<CompanyPremiumPlan> data = await _afsContext.CompanyPremiumPlans.OrderBy(x => x.CompanyId).ToListAsync();
            // Define a list to hold the data objects
            List<object> dataObjects = new List<object>();

            // Iterate through each plan in the data
            foreach (var plan in data)
            {
                var company = _context.Companies.FirstOrDefault(x => x.CompanyID == plan.CompanyId.ToString());

                // Calculate total amount made for the year of the current plan
                decimal totalAmountMade = 0;

                // Calculate balance for years beyond the year of the current plan
                decimal balance = 0;

                // Iterate through each month to sum up PremiumAmount
                for (int month = 1; month <= 12; month++)
                {
                    // Get the year and month parts of the given date
                    //int year = dateOfConsultation.Year;
                    //int month = dateOfConsultation.Month;

                    
                    // Sum up PremiumAmount for each month of the current plan's year
                    switch (month)
                    {
                        case 1:
                            totalAmountMade += plan.January;
                            break;
                        case 2:
                            totalAmountMade += plan.February;
                            break;
                        case 3:
                            totalAmountMade += plan.March;
                            break;
                        case 4:
                            totalAmountMade += plan.April;
                            break;
                        case 5:
                            totalAmountMade += plan.May;
                            break;
                        case 6:
                            totalAmountMade += plan.June;
                            break;
                        case 7:
                            totalAmountMade += plan.July;
                            break;
                        case 8:
                            totalAmountMade += plan.August;
                            break;
                        case 9:
                            totalAmountMade += plan.September;
                            break;
                        case 10:
                            totalAmountMade += plan.October;
                            break;
                        case 11:
                            totalAmountMade += plan.November;
                            break;
                        case 12:
                            totalAmountMade += plan.December;
                            break;
                    }
                }

                // Calculate balance for years beyond the year of the current plan
                foreach(var secData in data.Where(x=>x.Year>plan.Year
                &&x.CompanyId==plan.CompanyId&&x.InvoiceNumber==plan.InvoiceNumber
                &&x.Category==plan.Category
                &&x.Product==plan.Product
                )){

                    balance = balance+ secData.January + secData.February + secData.March + secData.April + secData.May + secData.June + secData.July + secData.August + secData.September + secData.October + secData.November + secData.December;
                    

                }

                string formattedStartDate = plan.StartDate?.ToString("dd-MMM-yy", CultureInfo.InvariantCulture)!;
                string formattedEndDate = plan.EndDate?.ToString("dd-MMM-yy", CultureInfo.InvariantCulture)!;

                //double? januaryClaimedAmount = 0;
                //double? FebruaryClaimedAmount = 0;
                //double? MarchClaimedAmount = 0;
                //double? AprilClaimedAmount = 0;
                //double? MayClaimedAmount = 0;
                //double? JuneClaimedAmount = 0;
                //double? JulyClaimedAmount = 0;
                //double? AugustClaimedAmount = 0;
                //double? SeptemberClaimedAmount = 0;
                //double? OctoberClaimedAmount = 0;
                //double? NovemberClaimedAmount = 0;
                //double? DecemberClaimedAmount=0;
            //    for(var month = 1; month <= 12; month++)
            //    {
            //    var claimedAmount = await _context.ClaimsDetails
            //.Where(cd => cd.EmployerId == plan.CompanyId.ToString() &&
            //             cd.DateOfConsultation.HasValue &&
            //             cd.DateOfConsultation.Value.Year == plan.Year &&
            //             cd.DateOfConsultation.Value.Month == month)
            //.SumAsync(cd => cd.Qty * cd.UnitPrice);
            //        if (month == 1)
            //        {
            //            januaryClaimedAmount = claimedAmount;
            //        }else if (month == 2)
            //        {
            //            FebruaryClaimedAmount = claimedAmount;
            //        }else if(month == 3)
            //        {
            //            MarchClaimedAmount = claimedAmount;
            //        }else if(month == 4)
            //        {
            //            AprilClaimedAmount = claimedAmount;
            //        }else if (month == 5)
            //        {
            //            MayClaimedAmount = claimedAmount;
            //        }else if( month == 6)
            //        {
            //            JuneClaimedAmount = claimedAmount;
            //        }else if (month == 7)
            //        {
            //            JulyClaimedAmount = claimedAmount;
            //        }else if ( month == 8)
            //        {
            //            AugustClaimedAmount = claimedAmount;
            //        }else if (month == 9)
            //        {
            //            SeptemberClaimedAmount = claimedAmount;
            //        }else if (month == 10)
            //        {
            //            OctoberClaimedAmount= claimedAmount;
            //        }else if (month == 11)
            //        {
            //            NovemberClaimedAmount=claimedAmount;
            //        }else if (month == 12)
            //        {
            //            DecemberClaimedAmount=claimedAmount;
            //        }
            //    }
                
                // Create a new data object and populate its properties
                var dataObject = new
                {
                    company = company!.company,
                    Product = plan.Product,
                    InvoiceType = plan.InvoiceType,
                    Category = plan.Category,
                    InvoiceNumber = plan.InvoiceNumber,
                    StartDate = formattedStartDate,//plan.StartDate,
                    EndDate = formattedEndDate,//plan.EndDate,
                    NumberOfLife = plan.NumberOfLife,
                    CardFees = plan.FinalCardFees.ToString("N2", CultureInfo.InvariantCulture),
                    PremiumAmount = plan.PremiumAmount.ToString("N2", CultureInfo.InvariantCulture),
                    Year = plan.Year,
                    January = plan.January.ToString("N2", CultureInfo.InvariantCulture),
                    //JanuaryClaims = januaryClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    February = plan.February.ToString("N2", CultureInfo.InvariantCulture),
                    //FebruaryClaims = FebruaryClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    March = plan.March.ToString("N2", CultureInfo.InvariantCulture),
                    //MarchClaims = MarchClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    April = plan.April.ToString("N2", CultureInfo.InvariantCulture),
                    //AprilClaims = AprilClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    May = plan.May.ToString("N2", CultureInfo.InvariantCulture),
                    //MayClaims = MayClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    June = plan.June.ToString("N2", CultureInfo.InvariantCulture),
                    //JuneClaims = JuneClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    July = plan.July.ToString("N2", CultureInfo.InvariantCulture),
                    //Julylaims = JulyClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    August = plan.August.ToString("N2", CultureInfo.InvariantCulture),
                    //AugustClaims = AugustClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    September = plan.September.ToString("N2", CultureInfo.InvariantCulture),
                    //SeptemberClaims = SeptemberClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    October = plan.October.ToString("N2", CultureInfo.InvariantCulture),
                    //OctoberClaims = OctoberClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    November = plan.November.ToString("N2", CultureInfo.InvariantCulture),
                    //NovemberClaims = NovemberClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    December = plan.December.ToString("N2", CultureInfo.InvariantCulture),
                    //DecemberClaims = DecemberClaimedAmount?.ToString("N2", CultureInfo.InvariantCulture),
                    TotalAmountMade = totalAmountMade.ToString("N2", CultureInfo.InvariantCulture),
                    Balance = balance.ToString("N2", CultureInfo.InvariantCulture)
                };

                // Add the data object to the list
                dataObjects.Add(dataObject);
            }

            return Ok(dataObjects);
        }

        //        public async Task<ActionResult<IEnumerable<Company>>> GetPremiumPlan()
        //{
        //    List<CompanyPremiumPlan> data = await _context.CompanyPremiumPlans.OrderBy(x => x.CompanyId).ToListAsync();
        //    // Define a list to hold the data objects
        //    List<object> dataObjects = new List<object>();

        //    // Get the current year
        //    int currentYear = DateTime.Now.Year;

        //    // Iterate through each plan in the data
        //    foreach (var plan in data)
        //    {
        //        var company =  _context.Companies.FirstOrDefault(x => x.CompanyID == plan.CompanyId.ToString());

        //        // Calculate total amount made within the current year
        //        decimal totalAmountMade = 0;
        //        decimal balance = 0;

        //        // Iterate through each month to sum up PremiumAmount
        //        for (int month = 1; month <= 12; month++)
        //        {
        //            // Check if the plan's PremiumAmount belongs to the current year
        //            if (plan.Year == currentYear)
        //            {
        //                switch (month)
        //                {
        //                    case 1:
        //                        totalAmountMade += plan.January;
        //                        break;
        //                    case 2:
        //                        totalAmountMade += plan.February;
        //                        break;
        //                    case 3:
        //                        totalAmountMade += plan.March;
        //                        break;
        //                    case 4:
        //                        totalAmountMade += plan.April;
        //                        break;
        //                    case 5:
        //                        totalAmountMade += plan.May;
        //                        break;
        //                    case 6:
        //                        totalAmountMade += plan.June;
        //                        break;
        //                    case 7:
        //                        totalAmountMade += plan.July;
        //                        break;
        //                    case 8:
        //                        totalAmountMade += plan.August;
        //                        break;
        //                    case 9:
        //                        totalAmountMade += plan.September;
        //                        break;
        //                    case 10:
        //                        totalAmountMade += plan.October;
        //                        break;
        //                    case 11:
        //                        totalAmountMade += plan.November;
        //                        break;
        //                    case 12:
        //                        totalAmountMade += plan.December;
        //                        break;
        //                }
        //            }
        //            else if (plan.Year > currentYear) // If the plan's year is beyond the current year
        //            {
        //                switch (month)
        //                {
        //                    case 1:
        //                        balance += plan.January;
        //                        break;
        //                    case 2:
        //                        balance += plan.February;
        //                        break;
        //                    case 3:
        //                        balance += plan.March;
        //                        break;
        //                    case 4:
        //                        balance += plan.April;
        //                        break;
        //                    case 5:
        //                        balance += plan.May;
        //                        break;
        //                    case 6:
        //                        balance += plan.June;
        //                        break;
        //                    case 7:
        //                        balance += plan.July;
        //                        break;
        //                    case 8:
        //                        balance += plan.August;
        //                        break;
        //                    case 9:
        //                        balance += plan.September;
        //                        break;
        //                    case 10:
        //                        balance += plan.October;
        //                        break;
        //                    case 11:
        //                        balance += plan.November;
        //                        break;
        //                    case 12:
        //                        balance += plan.December;
        //                        break;
        //                }
        //            }
        //        }

        //        // Create a new data object and populate its properties
        //        var dataObject = new
        //        {
        //            company = company!.company,
        //            Product = plan.Product,
        //            InvoiceType = plan.InvoiceType,
        //            Category = plan.Category,
        //            InvoiceNumber = plan.InvoiceNumber,
        //            StartDate = plan.StartDate,
        //            EndDate = plan.EndDate,
        //            NumberOfLife = plan.NumberOfLife,
        //            CardFees = plan.FinalCardFees,
        //            PremiumAmount = plan.PremiumAmount,
        //            Year = plan.Year,
        //            January = plan.January,
        //            February = plan.February,
        //            March = plan.March,
        //            April = plan.April,
        //            May = plan.May,
        //            June = plan.June,
        //            July = plan.July,
        //            August = plan.August,
        //            September = plan.September,
        //            October = plan.October,
        //            November = plan.November,
        //            December = plan.December,
        //            TotalAmountMade = totalAmountMade,
        //            Balance = balance
        //        };

        //        // Add the data object to the list
        //        dataObjects.Add(dataObject);
        //    }

        //    return Ok(dataObjects);
        //}

        //public async Task<ActionResult<IEnumerable<Company>>> GetPremiumPlan()
        //{
        //    List<CompanyPremiumPlan> data = await _context.CompanyPremiumPlans.OrderBy(x => x.CompanyId).ToListAsync();
        //    // Define a list to hold the data objects
        //    List<object> dataObjects = new List<object>();

        //    // Iterate through each plan in the data
        //    foreach (var plan in data)
        //    {
        //        var company =  _context.Companies.Where(x=>x.CompanyID==plan.CompanyId.ToString()).FirstOrDefault();
        //        // Create a new data object and populate its properties
        //        var dataObject = new
        //        {
        //            //Id = plan.Id,
        //            //CompanyId = plan.CompanyId,
        //            company = company!.company,
        //            Product = plan.Product,
        //            InvoiceType = plan.InvoiceType,
        //            Category = plan.Category,
        //            InvoiceNumber = plan.InvoiceNumber,
        //            StartDate = plan.StartDate,
        //            EndDate = plan.EndDate,
        //            //CardFees = plan.CardFees,
        //            NumberOfLife = plan.NumberOfLife,
        //            CardFees = plan.FinalCardFees,
        //            //DaysDifference = plan.DaysDifference,
        //            //Amount = plan.Amount,
        //            PremiumAmount = plan.PremiumAmount,
        //            //AmountPerMonth = plan.AmountPerMonth,
        //            Year = plan.Year,
        //            January = plan.January,
        //            February = plan.February,
        //            March = plan.March,
        //            April = plan.April,
        //            May = plan.May,
        //            June = plan.June,
        //            July = plan.July,
        //            August = plan.August,
        //            September = plan.September,
        //            October = plan.October,
        //            November = plan.November,
        //            December = plan.December
        //        };

        //        // Add the data object to the list
        //        dataObjects.Add(dataObject);
        //    }

        //    return Ok(dataObjects);
        //}

        //[HttpPost]
        //public async Task<ActionResult<IEnumerable<CompanyPremiumPlan>>> AddPlan(CompanyPremiumPlanDto companyPremiumPlanDto)
        //{
        //    var totalAmountPerMonth = new Dictionary<string, decimal>();

        //    // Get the start year and end year
        //    int startYear = companyPremiumPlanDto.StartDate?.Year ?? 0;
        //    int endYear = companyPremiumPlanDto.EndDate?.Year ?? 0;

        //    for (int year = startYear; year <= endYear; year++)
        //    {
        //        var companyPremiumPlan = mapper.Map<CompanyPremiumPlan>(companyPremiumPlanDto);

        //        // Set the start date for the current year
        //        DateTime currentStartDate = companyPremiumPlanDto.StartDate ?? new DateTime(year, 1, 1);

        //        // Set the end date for the current year
        //        DateTime currentEndDate = companyPremiumPlanDto.EndDate ?? new DateTime(year, 12, 31);

        //        // Adjust the start date for the first year and the end date for the last year
        //        if (year == startYear)
        //        {
        //            currentStartDate = companyPremiumPlanDto.StartDate.Value;
        //        }
        //        if (year == endYear)
        //        {
        //            currentEndDate = companyPremiumPlanDto.EndDate.Value;
        //        }

        //        // Calculate the premium amount for the current year
        //        var premiumAmountForYear = companyPremiumPlanDto.amount - companyPremiumPlanDto.FinalCardFees;

        //        // Calculate the amount per day for the current year
        //        var amountPerDayForYear = premiumAmountForYear / currentStartDate.DayOfYear;

        //        // Iterate through each day between the StartDate and EndDate for the current year
        //        var currentDate = currentStartDate;
        //        while (currentDate <= currentEndDate)
        //        {
        //            // Calculate the month and year of the current date
        //            var monthYear = currentDate.ToString("yyyy-MM");

        //            // Add the amount per day to the total amount for the corresponding month
        //            if (!totalAmountPerMonth.ContainsKey(monthYear))
        //            {
        //                totalAmountPerMonth[monthYear] = 0;
        //            }
        //            totalAmountPerMonth[monthYear] += amountPerDayForYear;

        //            // Move to the next day
        //            currentDate = currentDate.AddDays(1);
        //        }

        //        // Output the total amount per month
        //        foreach (var kvp in totalAmountPerMonth)
        //        {
        //            Console.WriteLine($"Total amount for {kvp.Key}: {kvp.Value}");
        //            // Assuming kvp.Key is of type string containing the date in the format "yyyy-MM"
        //            string dateString = kvp.Key;
        //            DateTime date = DateTime.ParseExact(dateString, "yyyy-MM", System.Globalization.CultureInfo.InvariantCulture);
        //            string monthName = date.ToString("MMMM"); // This will give you the full name of the month

        //            Console.WriteLine($"Total amount for new {monthName}: {kvp.Value}");
        //            companyPremiumPlan.Month = kvp.Key;
        //            companyPremiumPlan.PremiumAmount = premiumAmountForYear;
        //            companyPremiumPlan.AmountPerMonth = kvp.Value;
        //            if (monthName == "January")
        //            {
        //                companyPremiumPlan.January = kvp.Value;
        //            }
        //            else if (monthName == "February")
        //            {
        //                companyPremiumPlan.February = kvp.Value;
        //            }
        //            else if (monthName == "March")
        //            {
        //                companyPremiumPlan.March = kvp.Value;
        //            }
        //            else if (monthName == "April")
        //            {
        //                companyPremiumPlan.April = kvp.Value;
        //            }
        //            else if (monthName == "May")
        //            {
        //                companyPremiumPlan.May = kvp.Value;
        //            }
        //            else if (monthName == "June")
        //            {
        //                companyPremiumPlan.June = kvp.Value;
        //            }
        //            else if (monthName == "July")
        //            {
        //                companyPremiumPlan.July = kvp.Value;
        //            }
        //            else if (monthName == "August")
        //            {
        //                companyPremiumPlan.August = kvp.Value;
        //            }
        //            else if (monthName == "September")
        //            {
        //                companyPremiumPlan.September = kvp.Value;
        //            }
        //            else if (monthName == "October")
        //            {
        //                companyPremiumPlan.October = kvp.Value;
        //            }
        //            else if (monthName == "November")
        //            {
        //                companyPremiumPlan.November = kvp.Value;
        //            }
        //            else if (monthName == "December")
        //            {
        //                companyPremiumPlan.December = kvp.Value;
        //            }
        //        }

        //        await _context.CompanyPremiumPlans.AddAsync(companyPremiumPlan);
        //        await _context.SaveChangesAsync();
        //    }

        //    return Ok(totalAmountPerMonth);
        //}

        [HttpPost]
        public async Task<ActionResult<IEnumerable<CompanyPremiumPlan>>> AddPlan(CompanyPremiumPlanDto companyPremiumPlanDto)
        {
            //var premiumAmount = companyPremiumPlanDto.amount - companyPremiumPlanDto.FinalCardFees;
            var premiumAmount = companyPremiumPlanDto.amount;
            //var companyPremiumPlan = mapper.Map<CompanyPremiumPlan>(companyPremiumPlanDto);
            // Get the start year and end year
            int startYear = companyPremiumPlanDto.StartDate?.Year ?? 0;
            int endYear = companyPremiumPlanDto.EndDate?.Year ?? 0;
            //Console.WriteLine("finalPremiumAmount:" + premiumAmount);

            var amountPerDay = premiumAmount / companyPremiumPlanDto.DaysDifference;
            //Console.WriteLine("amountPerDay:" + amountPerDay);

            // Calculate the total amount per month
            var totalAmountPerMonth = new Dictionary<string, decimal>();

            // Iterate through each day between the StartDate and EndDate
            var currentDate = companyPremiumPlanDto.StartDate;
            while (currentDate <= companyPremiumPlanDto.EndDate)
            {
                // Calculate the month and year of the current date
                var monthYear = currentDate.Value.ToString("yyyy-MM");

                // Add the amount per day to the total amount for the corresponding month
                if (!totalAmountPerMonth.ContainsKey(monthYear))
                {
                    totalAmountPerMonth[monthYear] = 0;
                }
                totalAmountPerMonth[monthYear] += amountPerDay;

                // Move to the next day
                currentDate = currentDate.Value.AddDays(1);
            }
            for (int year = startYear; year <= endYear; year++)
            {
                        // Create a new instance of companyPremiumPlan for each month
                        var companyPremiumPlan = mapper.Map<CompanyPremiumPlan>(companyPremiumPlanDto);
                foreach (var kvp in totalAmountPerMonth)
                {
                    string dateString = kvp.Key;
                    DateTime date = DateTime.ParseExact(dateString, "yyyy-MM", System.Globalization.CultureInfo.InvariantCulture);
                    string monthName = date.ToString("MMMM");
                    string yearRead = date.ToString("yyyy");

                    if (int.Parse(yearRead) == year)
                    {
                        companyPremiumPlan.Year = int.Parse(yearRead);
                        companyPremiumPlan.PremiumAmount = premiumAmount;
                        companyPremiumPlan.AmountPerMonth = kvp.Value;
                        if (monthName == "January")
                        {
                            companyPremiumPlan.January = kvp.Value;
                        }
                        else if (monthName == "February")
                        {
                            companyPremiumPlan.February = kvp.Value;
                        }
                        else if (monthName == "March")
                        {
                            companyPremiumPlan.March = kvp.Value;
                        }
                        else if (monthName == "April")
                        {
                            companyPremiumPlan.April = kvp.Value;
                        }
                        else if (monthName == "May")
                        {
                            companyPremiumPlan.May = kvp.Value;
                        }
                        else if (monthName == "June")
                        {
                            companyPremiumPlan.June = kvp.Value;
                        }
                        else if (monthName == "July")
                        {
                            companyPremiumPlan.July = kvp.Value;
                        }
                        else if (monthName == "August")
                        {
                            companyPremiumPlan.August = kvp.Value;
                        }
                        else if (monthName == "September")
                        {
                            companyPremiumPlan.September = kvp.Value;
                        }
                        else if (monthName == "October")
                        {
                            companyPremiumPlan.October = kvp.Value;
                        }
                        else if (monthName == "November")
                        {
                            companyPremiumPlan.November = kvp.Value;
                        }
                        else if (monthName == "December")
                        {
                            companyPremiumPlan.December = kvp.Value;
                        }

                    }
                }
                        // Add this instance to the context
                        await _afsContext.CompanyPremiumPlans.AddAsync(companyPremiumPlan);
            }
            await _afsContext.SaveChangesAsync();


            //var companyPremiumPlan = mapper.Map<CompanyPremiumPlan>(companyPremiumPlanDto);
            //await _context.CompanyPremiumPlans.AddAsync(companyPremiumPlan);

            //return Ok(companyPremiumPlan.Id);
            return Ok(amountPerDay);
        }
        //[HttpPost]
        //        public async Task<ActionResult<IEnumerable<CompanyPremiumPlan>>> AddPlan(CompanyPremiumPlanDto companyPremiumPlanDto)
        //        {
        //            var premiumAmount = companyPremiumPlanDto.amount - companyPremiumPlanDto.FinalCardFees;
        //            var companyPremiumPlan = mapper.Map<CompanyPremiumPlan>(companyPremiumPlanDto);
        //            // Get the start year and end year
        //            int startYear = companyPremiumPlanDto.StartDate?.Year ?? 0;
        //            int endYear = companyPremiumPlanDto.EndDate?.Year ?? 0;
        //            Console.WriteLine("finalPremiumAmount:" + premiumAmount);

        //            var amountPerDay = premiumAmount / companyPremiumPlanDto.DaysDifference;
        //            Console.WriteLine("amountPerDay:" + amountPerDay);

        //            // Calculate the total amount per month
        //            var totalAmountPerMonth = new Dictionary<string, decimal>();

        //            // Iterate through each day between the StartDate and EndDate
        //            var currentDate = companyPremiumPlanDto.StartDate;
        //            while (currentDate <= companyPremiumPlanDto.EndDate)
        //            {
        //                // Calculate the month and year of the current date
        //                var monthYear = currentDate.Value.ToString("yyyy-MM");

        //                // Add the amount per day to the total amount for the corresponding month
        //                if (!totalAmountPerMonth.ContainsKey(monthYear))
        //                {
        //                    totalAmountPerMonth[monthYear] = 0;
        //                }
        //                totalAmountPerMonth[monthYear] += amountPerDay;

        //                // Move to the next day
        //                currentDate = currentDate.Value.AddDays(1);
        //            }
        //            for (int year = startYear; year <= endYear; year++)
        //            {
        //                // Output the total amount per month
        //                foreach (var kvp in totalAmountPerMonth)
        //                {
        //                        string dateString = kvp.Key;
        //                        DateTime date = DateTime.ParseExact(dateString, "yyyy-MM", System.Globalization.CultureInfo.InvariantCulture);
        //                        string monthName = date.ToString("MMMM"); // This will give you the full name of the month
        //                        string yearRead = date.ToString("yyyy"); // This will give you the full name of the month

        //                    if (int.Parse(yearRead) ==year) {
        //                        Console.WriteLine($"Total amount for {kvp.Key}: {kvp.Value}");
        //                        // Assuming kvp.Key is of type string containing the date in the format "yyyy-MM"
        //                        Console.WriteLine($"Total amount for new {monthName}: {kvp.Value}");
        //                        companyPremiumPlan.Month = kvp.Key;
        //                        companyPremiumPlan.PremiumAmount = premiumAmount;
        //                        companyPremiumPlan.AmountPerMonth = kvp.Value;
        //                        if (monthName == "January")
        //                        {
        //                            companyPremiumPlan.January = kvp.Value;
        //                        }
        //                        else if (monthName == "February")
        //                        {
        //                            companyPremiumPlan.February = kvp.Value;
        //                        }
        //                        else if (monthName == "March")
        //                        {
        //                            companyPremiumPlan.March = kvp.Value;
        //                        }
        //                        else if (monthName == "April")
        //                        {
        //                            companyPremiumPlan.April = kvp.Value;
        //                        }
        //                        else if (monthName == "May")
        //                        {
        //                            companyPremiumPlan.May = kvp.Value;
        //                        }
        //                        else if (monthName == "June")
        //                        {
        //                            companyPremiumPlan.June = kvp.Value;
        //                        }
        //                        else if (monthName == "July")
        //                        {
        //                            companyPremiumPlan.July = kvp.Value;
        //                        }
        //                        else if (monthName == "August")
        //                        {
        //                            companyPremiumPlan.August = kvp.Value;
        //                        }
        //                        else if (monthName == "September")
        //                        {
        //                            companyPremiumPlan.September = kvp.Value;
        //                        }
        //                        else if (monthName == "October")
        //                        {
        //                            companyPremiumPlan.October = kvp.Value;
        //                        }
        //                        else if (monthName == "November")
        //                        {
        //                            companyPremiumPlan.November = kvp.Value;
        //                        }
        //                        else if (monthName == "December")
        //                        {
        //                            companyPremiumPlan.December = kvp.Value;
        //                        }
        //                    }
        //                }
        //            await _context.CompanyPremiumPlans.AddAsync(companyPremiumPlan);
        //            }
        //            await _context.SaveChangesAsync();

        //            //var companyPremiumPlan = mapper.Map<CompanyPremiumPlan>(companyPremiumPlanDto);
        //            //await _context.CompanyPremiumPlans.AddAsync(companyPremiumPlan);

        //            //return Ok(companyPremiumPlan.Id);
        //            return Ok(amountPerDay);
        //        }

        [HttpDelete]
        public async Task<ActionResult<CompanyPremiumPlan>> DeletePlan(String Company, String Product, String InvoiceType, String Category, String InvoiceNumber,int numberOfLifes)
        {
            var company = await _context.Companies.Where(x => x.company == Company).FirstOrDefaultAsync();
            var plan = await _afsContext.CompanyPremiumPlans
                .Where(x => x.CompanyId.ToString() == company!.CompanyID
                         && x.Product == Product
                         && x.InvoiceType == InvoiceType
                         && x.Category == Category
                         && x.InvoiceNumber == InvoiceNumber
                         && x.NumberOfLife == numberOfLifes)
                .FirstOrDefaultAsync();

            if (plan == null)
            {
                return NotFound(); // Plan not found
            }

            _afsContext.CompanyPremiumPlans.Remove(plan);
            await _afsContext.SaveChangesAsync();

            return Ok();
        }

    }
}
