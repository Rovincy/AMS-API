//using AutoMapper;
//using DCI_TSP_API.Dto.MemberRoles;
//using DCI_TSP_API.UserModels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace DCI_TSP_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MemberRolesController : Controller
//    {
//        private readonly DciTspContext _context;
//        private readonly IMapper mapper;
//        public MemberRolesController(DciTspContext context,IMapper mapper)
//        {
//            _context = context;
//            this.mapper = mapper;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<MemberRole>>> GetMemberRoles()
//        {
//            List<MemberRole> memberRole = await _context.MemberRoles.ToListAsync();
//            return Ok(memberRole);
//        }

//        [HttpPost]
//        public async Task<ActionResult<IEnumerable<MemberRole>>> AddMemberRoles(MemberRoleCreateDto memberRoleDto)
//        {
//            var memberRole = mapper.Map<MemberRole>(memberRoleDto);
//            await _context.MemberRoles.AddAsync(memberRole);
//            await _context.SaveChangesAsync();

//            return Ok(memberRole.Id);
//        }
//        [HttpDelete]
//        public async Task<ActionResult<MemberRole>> DeleteMemberRole(int id)
//        {

//            var memberRole = await _context.MemberRoles.FindAsync(id);
//            _context.MemberRoles.Remove(memberRole!);
//            await _context.SaveChangesAsync();

//            return Ok();
//        }
//    }
//}
