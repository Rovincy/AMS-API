using AutoMapper;
using DCI_TSP_API.Dto.Members;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : Controller
    {
        private readonly AfsContext _context;
        private readonly IMapper mapper;
        public static IWebHostEnvironment? _environment;
        public MembersController(AfsContext context,IMapper mapper, IWebHostEnvironment environment)
        {
            _context = context;
            this.mapper = mapper;
            _environment = environment;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Member>>> GetMembers()
        {
            List<Member> members = await _context.Members.ToListAsync();
            return Ok(members);
        }
        [HttpPost]
        public async Task<ActionResult<Member>> AddMember([FromForm] MembersCreateDto memberDto)
        {

            //Register New Member Details
            if (memberDto.ImageFile != null && memberDto.ImageFile.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment!.WebRootPath + "\\Uploads\\"))
                    {
                        Directory.CreateDirectory(_environment!.WebRootPath + "\\Uploads\\");
                    }

                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(memberDto.ImageFile.FileName);
                    string filePath = Path.Combine(_environment!.WebRootPath, "Uploads", fileName);

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await memberDto.ImageFile.CopyToAsync(fileStream);
                    }

                    memberDto.Image = "\\Uploads\\" + fileName;
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            var member = mapper.Map<Member>(memberDto);
            await _context.Members.AddAsync(member);
            await _context.SaveChangesAsync();

            ////Register Mariage Details if any
            //var mariage = mapper.Map<Mariage>(memberDto);
            //await _context.Mariages.AddAsync(mariage);
            //await _context.SaveChangesAsync();

            //Register Parent Details if any
            //memberDto.ChildId = member.Id;
            //var parent = mapper.Map<Parent>(memberDto);
            //await _context.Parents.AddAsync(parent);

            await _context.SaveChangesAsync();
            return Ok(member.Id);
        }
        [HttpDelete]
        public async Task<ActionResult<Member>> DeleteMember(int id)
        {

            var member = await _context.Members.FindAsync(id);
            _context.Members.Remove(member!);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
