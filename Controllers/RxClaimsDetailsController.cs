using AutoMapper;
using DCI_TSP_API.Dto.MemberRoles;
using DCI_TSP_API.Dto.ParentRole;
using DCI_TSP_API.Dto.Parents;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Company = DCI_TSP_API.RxModels.Company;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RxClaimsDetailsController : Controller
    {
        private readonly RxDBContext _context;
        private readonly IMapper mapper;
        public RxClaimsDetailsController(RxDBContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetMariages()
        {
            //List<ClaimsDetail> mariage = await _context.ClaimsDetails.ToListAsync();
            DateTime startDate = new DateTime(2023, 01, 01);
            DateTime endDate = new DateTime(2023, 01, 31);

            List<Company> claim = await _context.Companies
                //.Where(cd => cd.Id== 23652592)
                .ToListAsync();

            return Ok(claim);
        }

        //[HttpPost]
        //public async Task<ActionResult<IEnumerable<Mariage>>> AddParentRoles(MariageCreateDto mariageDto)
        //{
        //    var mariage = mapper.Map<Mariage>(mariageDto);
        //    await _context.Mariages.AddAsync(mariage);
        //    await _context.SaveChangesAsync();

        //    return Ok(mariage.Id);
        //}
        //[HttpDelete]
        //public async Task<ActionResult<Parent>> DeleteParent(int id)
        //{

        //    var mariage = await _context.Mariages.FindAsync(id);
        //    _context.Mariages.Remove(mariage!);
        //    await _context.SaveChangesAsync();

        //    return Ok();
        //}
    
    }
}
