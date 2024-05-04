using AutoMapper;
using DCI_TSP_API.RxModels;
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
        private readonly IMapper mapper;
        public PatientInfoController(RxDBContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientInfo>>> GetPatients()
        {
            var patients = _context.PatientInfos
.FromSqlRaw(@"
     select id,firstname,othernames,surname,member_no,employer_id from patient_info
            ")
.ToList();
            //List<PatientInfo> patients = await _context.PatientInfos.ToListAsync();
            return Ok(patients);
        }
    }
}
