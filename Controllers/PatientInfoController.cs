using AutoMapper;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.TpaDataModel;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientInfoController : Controller
    {
        private readonly RxDBContext _context;
        private readonly TpaDbContext _tpaContext;
        private readonly IMapper mapper;
        public PatientInfoController(RxDBContext context, IMapper mapper, TpaDbContext tpaContext)
        {
            _context = context;
            this.mapper = mapper;
            _tpaContext = tpaContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientInfo>>> GetPatients()
        {
            var patients = _context.PatientInfos
.FromSqlRaw(@"
     select p1.id,p1.firstname,p1.othernames,p1.surname,p1.member_no,p1.employer_id,p1.principal_id,
p2.firstname as principalFirstName, p2.othernames as principalOthernames,p2.surname as principalLastname 
from patient_info p1
join patient_info p2 on p2.member_no=p1.principal_id; ")
.ToList();
            //List<PatientInfo> patients = await _context.PatientInfos.ToListAsync();
            return Ok(patients);
        }
        [HttpGet("TPA")]
        public async Task<ActionResult<IEnumerable<PatientInfoTpa>>> GetTPAPatients()
        {
            var patients = _tpaContext.PatientInfoTpas
                .FromSqlRaw(@"
            select p1.id,p1.firstname,p1.othernames,p1.surname,p1.member_no as MemberNo,p1.employer_id as EmployerId,p1.principal_id as PrincipalId,
p2.firstname as principalFirstName, p2.othernames as principalOthernames,p2.surname as principalLastname 
from afs_tpa.patient_info p1
join afs_tpa.patient_info p2 on p2.member_no=p1.principal_id;")
                .ToList();

            return Ok(patients);
        }

        //   [HttpGet("TPA")]
        //        public async Task<ActionResult<IEnumerable<PatientInfoTpa>>> GetTPAPatients()
        //        {
        //            var patients = _context.PatientInfoTpas
        //.FromSqlRaw(@"
        //          select p1.id,p1.firstname,p1.othernames,p1.surname,p1.member_no,p1.employer_id,p1.principal_id,
        //p2.firstname as principalFirstName, p2.othernames as principalOthernames,p2.surname as principalLastname 
        //from afs_tpa.patient_info p1
        //join afs_tpa.patient_info p2 on p2.member_no=p1.principal_id; ")
        //.ToList();
        //            //List<PatientInfo> patients = await _context.PatientInfos.ToListAsync();
        //            return Ok(patients);
        //        }

    }
}
