using AutoMapper;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintReportController : Controller
    {
        private readonly RxDBContext _context;
        private readonly IMapper mapper;
        public PrintReportController(RxDBContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrintReport>>> GetPrintReport()
        {
            _context.Database.SetCommandTimeout(900); // Set the timeout to 300 seconds (5 minutes)
            var result = _context.CustomerPrintedCards
            .FromSqlRaw(@"
            select PR.date,PR.admin_id,PR.name as adminName,PR.member_no,PR.member_name,type,PI.employer as companyName from print_report PR
            join patient_info PI on PI.member_no = PR.member_no
            group by PR.member_no
            ")
            .ToList();
            return Ok(result);
            //List<PrintReport> printReport = await _context.PrintReports.ToListAsync();
            //List<Company> companies = await _context.Companies.ToListAsync();
            //List<Object> data = new List<Object>();
            //foreach (var printRep in printReport)
            //{
            //    foreach (var comp in companies)
            //    {
            //        if (printRep.Company = comp.Id.ToString)
            //        {
            //            var localObject = new
            //            {
            //                id = printRep.Id,
            //                date = printRep.date,
            //                agentName = printRep.Name,
            //                cardNumber = printRep.CardNum,
            //                CompanyName = comp.company,
            //                memberName = printRep.MemberName,
            //                type = printRep.Type,
            //            };
            //            data.Add(localObject);
            //        }

            //    }
            //}
            //return Ok(printReport);
        }

    }
}
