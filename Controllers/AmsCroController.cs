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
    public class AmsCroController : Controller
    {
        private readonly AfsContext _context;
        private readonly IMapper mapper;
        public AmsCroController(AfsContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmsCro>>> GetCalls()
        {
            _context.Database.SetCommandTimeout(3600);
            var data = _context.AmsCroElements
            .FromSqlRaw(@"
 SELECT 
    C.CompanyID,
    CP.plan_id as PlanId,
    C.Company,
    CP.plan AS plan,
    cro.officer,
    cro.description,
    cro.outPatientBenefit,
    cro.inPatientBenefit,
    cro.dentalBenefit,
    cro.opticalBenefit,
    cro.maternityDeliveryBenefit,
    cro.chronicBenefit,
    cro.cancerBenefit,
    cro.lastUpdate,
    cro.overallSurgeryBenefit
FROM 
    company C
LEFT JOIN 
    company_plan CP ON CP.companyID = C.CompanyID
LEFT JOIN 
    ams_cro cro ON cro.companyId = C.companyID AND cro.planId = CP.plan_id
WHERE 
    C.company_status = 'Active'
ORDER BY C.Company ASC;

            ")
            .ToList();
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<AmsCro>>> AddCall(AmsCroCreateDto croDto)
        {
            List<AmsCro> data = await _context.AmsCros.Where(c => c.CompanyId== croDto.CompanyId && c.PlanId==croDto.PlanId).ToListAsync();
            croDto.LastUpdate = DateTime.Now;
            if (data.Any())
            {
                foreach (var item in data)
                {
                    item.CompanyId = croDto.CompanyId;
                    item.Officer = croDto.Officer;
                    item.OutPatientBenefit = croDto.OutPatientBenefit;
                    item.InPatientBenefit = croDto.InPatientBenefit;
                    item.DentalBenefit = croDto.DentalBenefit;
                    item.OpticalBenefit = croDto.OpticalBenefit;
                    item.MaternityDeliveryBenefit = croDto.MaternityDeliveryBenefit;
                    item.ChronicBenefit = croDto.ChronicBenefit;
                    item.CancerBenefit = croDto.CancerBenefit;
                    item.Description = croDto.Description;
                    item.LastUpdate = croDto.LastUpdate;
                    item.OverallSurgeryBenefit = croDto.OverallSurgeryBenefit;
                    item.PlanId = croDto.PlanId;
                }
                _context.AmsCros.UpdateRange(data);
                //_context.SaveChanges();
            }
            else
            {
            var cro = mapper.Map<AmsCro>(croDto);
            await _context.AmsCros.AddAsync(cro);
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
