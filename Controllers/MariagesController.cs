//using AutoMapper;
//using DCI_TSP_API.Dto.MemberRoles;
//using DCI_TSP_API.Dto.ParentRole;
//using DCI_TSP_API.Dto.Parents;
//using DCI_TSP_API.UserModels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace DCI_TSP_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MariagesController : Controller
//    {
//        private readonly AfsContext _context;
//        private readonly IMapper mapper;
//        public MariagesController(AfsContext context, IMapper mapper)
//        {
//            _context = context;
//            this.mapper = mapper;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Mariage>>> GetMariages()
//        {
//            List<Mariage> mariage = await _context.Mariages.ToListAsync();
//            return Ok(mariage);
//        }

//        [HttpPost]
//        public async Task<ActionResult<IEnumerable<Mariage>>> AddParentRoles(AmsCroCreateDto mariageDto)
//        {
//            var mariage = mapper.Map<Mariage>(mariageDto);
//            await _context.Mariages.AddAsync(mariage);
//            await _context.SaveChangesAsync();

//            return Ok(mariage.Id);
//        }
//        [HttpDelete]
//        public async Task<ActionResult<Parent>> DeleteParent(int id)
//        {

//            var mariage = await _context.Mariages.FindAsync(id);
//            _context.Mariages.Remove(mariage!);
//            await _context.SaveChangesAsync();

//            return Ok();
//        }
//    }
//}
