using AutoMapper;
using DCI_TSP_API.Dto.AuditTrail;
using DCI_TSP_API.Dto.Banks;
using DCI_TSP_API.Dto.MemberRoles;
using DCI_TSP_API.Dto.ParentRole;
using DCI_TSP_API.Dto.Parents;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditTrailController : Controller
    {
        private readonly AfsUserdbContext _context;
        private readonly IMapper mapper;
        public AuditTrailController(AfsUserdbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmsCro>>> GetAuditTrail()
        {
            _context.Database.SetCommandTimeout(3600);
            var data = _context.AuditTrails
            .ToList();
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<AmsCro>>> AddCall(AuditTrailDto auditTrailDto)
        {
            auditTrailDto.Timestamp = DateTime.Now;
            var trail = mapper.Map<AuditTrail>(auditTrailDto);
                await _context.AuditTrails.AddAsync(trail);
            await _context.SaveChangesAsync();

            return Ok(trail.Id);
        }
        //[HttpDelete]
        //public async Task<ActionResult<AfsCRM>> DeleteCall(int id)
        //{

        //    var crm = await _context.AfsCRMs.FindAsync(id);
        //    _context.AfsCRMs.Remove(crm!);
        //    await _context.SaveChangesAsync();

        //    return Ok();
        //}

    }
}
