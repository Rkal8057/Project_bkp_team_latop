using Microsoft.AspNetCore.Mvc;
using Web_API.Models;
using Web_API.Middleware;
using Microsoft.EntityFrameworkCore;

namespace Web_API.Controllers
{
    public class FileController : Controller
    {
        private readonly DBContext _context;
        public FileController(DBContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("upload")]
        public async Task<ActionResult> UploadFile(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    // Handle the case where no file is selected.
                    return BadRequest("file is required!!");
                }

                // Process the uploaded file, e.g., save it to the server.
                var filePath = Path.Combine("root", "users", file.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }


                var baseUrl = "http://localhost:5193"; 
                var fileUrl = baseUrl + "/root/users/" + file.FileName;

                Console.WriteLine(fileUrl+"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

                //Save file info to the database.
                //var uploadedFile = new Models.File
                //{
                //    FileName = file.FileName,
                //    FilePath = filePath,
                //    userId = 3
                //};

                //await _context.Files.AddAsync(uploadedFile);
                //await _context.SaveChangesAsync();

                return Ok("File upload successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("download")]
        public IActionResult DownloadFile(int fileId)
        {
            try
            {
                // Retrieve the file info from the database using the fileId.
                var file = _context.Files.FirstOrDefault(f => f.Id == fileId);

                if (file == null)
                {
                    return NotFound("File not found.");
                }

                // Open the file and prepare it for download.
                var stream = System.IO.File.OpenRead(file.FilePath);

                // Specify the content type and file name for the response.
                return File(stream, "application/octet-stream", file.FileName);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //[HttpGet("getDetailWithUserDetail")]
        //public async Task<ActionResult> fileDataWithUserDetail(int id )
        //{
        //    try
        //    {

        //        return Ok( );

        //    }catch (Exception ex) { 
        //        return BadRequest(ex.Message);  
        //    }

        //}

    }
}
