using AutoMapper;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProviderApi = DCI_TSP_API.RxModels.ProviderApi;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersController : Controller
    {
        private readonly RxDBContext _context;
        private readonly IMapper mapper;
        public ProvidersController(RxDBContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProviderApi>>> GetProviders()
        {
            List<ProviderApi> providers = await _context.ProviderApis.OrderBy(provider => provider.FacilityName).ToListAsync();
            return Ok(providers);
        }
    }
}
