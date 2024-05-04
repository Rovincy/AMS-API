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
    public class BanksController : Controller
    {
        private readonly AfsContext _context;
        private readonly IMapper mapper;
        public BanksController(AfsContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bank>>> GetBanks()
        {
            List<Bank> bank = await _context.Banks.OrderBy(bank => bank.Name).ToListAsync();
            return Ok(bank);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Bank>>> AddBank(BankCreateDto bankDto)
        {
            var bank = mapper.Map<Bank>(bankDto);
            await _context.Banks.AddAsync(bank);
            await _context.SaveChangesAsync();

            return Ok(bank.Id);
        }
        [HttpDelete]
        public async Task<ActionResult<Bank>> DeleteBank(int id)
        {

            var bank = await _context.Banks.FindAsync(id);
            _context.Banks.Remove(bank!);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
