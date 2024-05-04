using AutoMapper;
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
    public class AmsHspController : Controller
    {
        private readonly AfsContext _context;
        private readonly IMapper mapper;
        public AmsHspController(AfsContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmsCro>>> GetData()
        {
            _context.Database.SetCommandTimeout(3600);
            var data = _context.AmsHspElements
            .FromSqlRaw(@"
     
select H.id,P.provider_id as providerId,P.facility_name as FacilityName,H.status,H.lastUpdate from provider_api P
LEFT JOIN ams_hsp H on H.providerId = P.provider_id
order by P.facility_name asc

            ")
            .ToList();
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<AmsCro>>> AddData(AmsHspCreateDto hspDto)
        {
            List<AmsHsp> data = await _context.AmsHsps.Where(c => c.ProviderId== hspDto.ProviderId).ToListAsync();
            hspDto.LastUpdate = DateTime.Now;
            if (data.Any())
            {
                foreach (var item in data)
                {
                    item.ProviderId = hspDto.ProviderId;
                    item.Status = hspDto.Status;
                    item.LastUpdate = hspDto.LastUpdate;
                }
                _context.AmsHsps.UpdateRange(data);
                //_context.SaveChanges();
            }
            else
            {
            var hsp = mapper.Map<AmsHsp>(hspDto);
            await _context.AmsHsps.AddAsync(hsp);
            }
            await _context.SaveChangesAsync();

            return Ok();
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
