using AutoMapper;
using DCI_TSP_API.Dto.MemberRoles;
using DCI_TSP_API.Dto.ParentRole;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : Controller
    {
        private readonly AfsContext _context;
        private readonly IMapper mapper;
        public NationalityController(AfsContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nationality>>> GetNationalities()
        {
            List<Nationality> nationality = await _context.Nationalities.ToListAsync();
            return Ok(nationality);
        }

        //[HttpPost]
        //public async Task<ActionResult<IEnumerable<ParentRole>>> AddParentRoles(ParentRoleCreateDto parentRoleDto)
        //{
        //    var parentRole = mapper.Map<ParentRole>(parentRoleDto);
        //    await _context.ParentRoles.AddAsync(parentRole);
        //    await _context.SaveChangesAsync();

        //    return Ok(parentRole.Id);
        //}
        //[HttpDelete]
        //public async Task<ActionResult<ParentRole>> DeleteParentRole(int id)
        //{

        //    var parentRole = await _context.ParentRoles.FindAsync(id);
        //    _context.ParentRoles.Remove(parentRole!);
        //    await _context.SaveChangesAsync();

        //    return Ok();
        //}
    }
}
