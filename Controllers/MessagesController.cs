using AutoMapper;
using DCI_TSP_API.Dto.Banks;
using DCI_TSP_API.Dto.MemberRoles;
using DCI_TSP_API.Dto.Messages;
using DCI_TSP_API.Dto.ParentRole;
using DCI_TSP_API.Dto.Parents;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : Controller
    {
        private readonly AfsUserdbContext _context;
        private readonly IMapper mapper;
        public MessagesController(AfsUserdbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Messages>>> GetBanks(int userId)
        {
            List<Messages> messages = await _context.Messages.Where(x=>x.SenderId==userId||x.ReceiverId==userId).OrderBy(x => x.Timestamp).ToListAsync();
            return Ok(messages);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Messages>>> AddMessage(MessageCreateDto messageDto)
        {
            var message = mapper.Map<Messages>(messageDto);
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();

            return Ok(message.Id);
        }
        [HttpDelete]
        public async Task<ActionResult<Messages>> DeleteMessage(int id)
        {

            var message = await _context.Messages.FindAsync(id);
            _context.Messages.Remove(message!);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
