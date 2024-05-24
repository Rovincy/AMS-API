using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using DCI_TSP_API.UserModels;
using Microsoft.EntityFrameworkCore;
using DCI_TSP_API.Dto.PaymentAdvice;
using DCI_TSP_API.RxModels;

namespace DCI_TSP_API.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FileController : ControllerBase
    {
        public static IWebHostEnvironment _environment;
        private readonly AfsContext _context;
        public FileController(AfsContext context,IWebHostEnvironment environment)
        {
            _context = context;
        _environment = environment;
        }
        public class FileUpload
        {
            public IFormFile files { get; set; }
            //public string name {  get; set; }
            public string? refundCode { get; set; }
            public bool? isApproved { get; set; }
            public int uploadedBy {  get; set; }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Files>>> GetFiles(String refundCode)
        {
            var data = await _context.Files.Where(x=>x.RefundCode==refundCode).ToListAsync();
            foreach (var service in data)
            {
                //Development
                //service.Path = $"{Request.Scheme}://{Request.Host}//{service.Path}";

                //Production
                service.Path = $"{Request.Scheme}://{Request.Host}/afs-api//{service.Path}";
            }
            return Ok(data);
        }
        [HttpPost]
        public async Task<string> Post([FromForm] FileUpload objFile)
        {
            if (objFile.files.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Uploads\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Uploads\\");
                    }
                    String filePath;
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Uploads\\" + objFile.files.FileName))
                    {
                        //var path = _environment.WebRootPath + "\\Upload\\" + objFile.files.FileName;
                        filePath = String.Format(_environment.WebRootPath + "\\Uploads\\" + objFile.files.FileName);
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                    }
                    Files files = new Files();
                    //files.Name = objFile.name;
                    files.RefundCode = objFile.refundCode;
                    files.IsApproved = objFile.isApproved;
                    files.Path = "\\Uploads\\" + objFile.files.FileName;
                    files.UploadedBy = objFile.uploadedBy;
                    files.Timestamp = DateTime.Now;
                     _context.Files.Add(files);
                    await _context.SaveChangesAsync();
                    return "\\Uploads\\" + objFile.files.FileName;
                }
                catch (Exception ex)
                {
                    return ex.Message.ToString();
                }
            }
            else
            {
                return "Failed";
            }
        }
        [HttpDelete]
        public async Task<ActionResult<Files>> DeleteFile(int id)
        {

            var file = await _context.Files.FindAsync(id);
            if (file == null)
            {
                return NotFound();
            }

            // Delete the file from the file system
            try
            {
                System.IO.File.Delete(file.Path!); // Assuming 'Path' property stores the file path
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur while deleting the file
                return StatusCode(500, $"Error deleting file: {ex.Message}");
            }
            _context.Files.Remove(file!);
            await _context.SaveChangesAsync();

            return Ok();
        }

        public class FileList
        {
            public int id { get; set; }
            public string refundCode { get; set; }
            public bool? isApproved { get; set; }
        }
        [HttpPut]
        public async Task<ActionResult<IEnumerable<Files>>> EditFileStatus(List<FileList> list)
        {
                foreach(var listValue in list)
            {
            List<Files> file = await _context.Files.Where(x => x.Id == listValue.id&&x.RefundCode==listValue.refundCode).ToListAsync();
            foreach (var value in file)
                {
                    value.IsApproved = listValue.isApproved;
                }
            _context.Files.UpdateRange(file);
            }
            _context.SaveChanges();
            return Ok();
        }

    }

}
