using AutoMapper;
using DCI_TSP_API.Dto.MemberRoles;
using DCI_TSP_API.Dto.ParentRole;
using DCI_TSP_API.Dto.Parents;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentsController : Controller
    {
        private readonly AfsContext _context;
        private readonly IMapper mapper;
        public ParentsController(AfsContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parent>>> GetParentRoles()
        {
            List<Parent> parent = await _context.Parents.ToListAsync();
            return Ok(parent);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Parent>>> AddParentRoles(ParentCreateDto parentDto)
        {
            var parent = mapper.Map<Parent>(parentDto);
            await _context.Parents.AddAsync(parent);
            await _context.SaveChangesAsync();

            return Ok(parent.Id);
        }
        [HttpDelete]
        public async Task<ActionResult<Parent>> DeleteParent(int id)
        {

            var parent = await _context.Parents.FindAsync(id);
            _context.Parents.Remove(parent!);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
