using AutoMapper;
using DCI_TSP_API.Dto.Banks;
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
    public class AmsCrmController : Controller
    {
        private readonly AfsContext _context;
        private readonly IMapper mapper;
        public AmsCrmController(AfsContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet("UserPerformances")]
        public async Task<ActionResult<IEnumerable<AmsCRM>>> GetUserPerformances()
        {
            var userPerformances = _context.AmsUserPerformances
 .FromSqlRaw(@"
     SELECT U.firstName as FirstName,U.lastName as LastName,R.name as Role, sum(C.callDuration) as Duration, count(C.id) as Count FROM ams_crm C
join afs_userdb.`user` U on U.id = C.userId
join afs_userdb.role R on R.id = U.roleId
group by C.userId
            ")
 .ToList();
            return Ok(userPerformances);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmsCRM>>> GetCalls()
        {
            List<AmsCRM> crm = await _context.AmsCRMs.OrderByDescending(timestamp => timestamp).ToListAsync();
            return Ok(crm);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<AmsCRM>>> AddCall(AmsCrmCreateDto crmDto)
        {
            crmDto.Timestamp = DateTime.Now;
            var crm = mapper.Map<AmsCRM>(crmDto);
            await _context.AmsCRMs.AddAsync(crm);
            if (crm.CallType=="REFUND CODE") {
                AmsRefund refund = new AmsRefund();
                refund.RefundCode = crm.RefundCode;
                refund.MemberNumber = crm.MemberNumber;
                await _context.AmsRefunds.AddAsync(refund);
            }
            await _context.SaveChangesAsync();

            return Ok(crm.Id);
        }
        [HttpDelete]
        public async Task<ActionResult<AmsCRM>> DeleteCall(int id)
        {

            var crm = await _context.AmsCRMs.FindAsync(id);
            _context.AmsCRMs.Remove(crm!);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
