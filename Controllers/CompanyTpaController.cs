using AutoMapper;
using DCI_TSP_API.Dto.CompanyPremiumPlan;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.TpaDataModel;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyTpaController : Controller
    {
        private readonly TpaDbContext _context;
        private readonly AfsContext _afsContext;
        private readonly IMapper mapper;
        public CompanyTpaController(TpaDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TpaCompany>>> GetCompanies()
        {
            List<TpaCompany> company = await _context.Companies.OrderBy(x => x.company).ToListAsync();
            return Ok(company);
        }


    }
}
