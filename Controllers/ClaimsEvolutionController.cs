using AutoMapper;
using DCI_TSP_API.RxModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsEvolutionController : Controller
    {
        private readonly RxDBContext _context;
        private readonly IMapper mapper;
        public ClaimsEvolutionController(RxDBContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }
        

       
        [HttpGet("topProviders")]
        public async Task<ActionResult> GetTopProviders()
        {
            _context.Database.SetCommandTimeout(3600);
            var data = _context.ClaimTopProviders
            .FromSqlRaw(@"
     
SELECT 
    pr.facility_name as provider,
    SUM(cd.qty * cd.unit_price) AS Amount
FROM 
    claims_details cd
JOIN
    provider_api pr ON pr.provider_id = cd.provider_id
WHERE 
    YEAR(cd.date_of_consultation) = YEAR(CURRENT_DATE()) AND
		pr.facility_name not like ('%Refund%')
GROUP BY 
    pr.facility_name
ORDER BY
    Amount DESC
LIMIT 10;



            ")
            .ToList();

            return Ok(data);
        }

    }
}
