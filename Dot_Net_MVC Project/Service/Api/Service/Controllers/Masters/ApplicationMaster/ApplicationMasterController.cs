using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DB.Login;
using DB.Login.Tables;
using RTA.Masters;
using RTAAPI;
using RTA.Masters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]

    public class ApplicationMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ApplicationMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ApplicationMasterResp))]
        public IActionResult CreateApplicationMaster([FromBody] ApplicationMasterReq samp)
        {
            try
            {
                ApplicationMasterBLL sample = new ApplicationMasterBLL(DBConnStr);



                int daysDifference = (samp.end_date.Value - samp.start_date.Value).Days;

                var model = new
                {
                    first_email = samp.first_email,
                    first_address = samp.first_addres,
                    first_city = samp.first_city,
                    first_state = samp.first_state,
                    first_pincode = samp.first_pincode.ToString(),
                    first_mobile = samp.first_mobile.ToString(),
                    date = samp.date?.ToShortDateString(),
                    second_name = samp.second_name,
                    second_address = samp.second_address,
                    second_city = samp.second_city,
                    second_state = samp.second_state,
                    second_pincode = samp.second_pincode,
                    subject = samp.subject,
                    total_day = daysDifference.ToString(),
                    type_of_leave = samp.type_of_leave,
                    coWorker_name = samp.coWorker_name,
                    start_date = samp.start_date?.ToShortDateString(),
                    end_date = samp.end_date?.ToShortDateString(),
                    coming_date = samp.coming_date?.ToShortDateString(),
                    disease = samp.disease,
                    logo_image = samp.logo_image,
                    sign_image = samp.sign_image,
                    designation = samp.designation
                    // Add other properties
                };
                var filePath = GenerateLeaveRequestDocument(model);

                string content = null;
                if (filePath is ContentResult contentResult)
                {
                    content = contentResult.Content;
                    content = content.Replace("wwwroot", "http://localhost:5200");
                }

                var Res = sample.InsertApplicationMaster(samp, content);
                objAction = CreatedAtAction("CreateApplicationMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ApplicationMasterResp data = new ApplicationMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateApplicationMaster", data);
                return objAction;
            }
        }





        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult GenerateLeaveRequestDocument(object dynamicModel)
        {

            string templateContent1 = @"
To,
{{second_name}}
{{second_address}}
{{second_city}}, {{second_state}}, {{second_pincode}}

Date:{{date}}

Sub: John Doe

Dear Sir,

I would like to bring to your kind attention that my medical reports have detected {{disease}}. I have been advised by my doctor to be on bed rest for {{total_day}} days. I am enclosing my medical reports for your reference.

I am writing this letter to officially inform about my illness and request for {{type_of_leave}} leave. I have handed over my work to {{coWorker_name}}, who will be keeping the files updated in my absence. I would kindly request you to grant me leave w.e.f {{start_date}} to {{end_date}}. I would be reporting back on {{coming_date}}.

Thanks and Regards,
({{second_name}})
";

            string _docxSavePath = "wwwroot/documents/";
            if (!Directory.Exists(_docxSavePath))
            {
                Directory.CreateDirectory(_docxSavePath);
            }

            // Generate a unique filename (you can customize this logic)
            string fileName = $"LeaveRequest_{DateTime.Now:yyyyMMddHHmmss}.docx";
            string filePath = Path.Combine(_docxSavePath, fileName);
            dynamic model = dynamicModel;


            using (var stream = new MemoryStream())
            {
                using (var document = DocX.Create(stream))
                {

                    /*string imagePath = @"D:/33343.JPEG";
                    string _docxSavePath1 = "wwwroot/GeneralRequested_image/";
                    string filepath = Path.Combine(_docxSavePath, "0NHJg9DXbn_andriyko-podilnyk-jFAG_ixCrsM-unsplash 1.png");
                    string imagePathp = @"/GeneralRequested_image/0NHJg9DXbn_andriyko-podilnyk-jFAG_ixCrsM-unsplash 1.png";
                    string imagePathp3 = @"/GeneralRequested_image/0NHJg9DXbn_andriyko-podilnyk-jFAG_ixCrsM-unsplash 1.png";
                    string fullPath = Path.Combine(directoryPath + "/wwwroot", imagePathp3.TrimStart('/').Replace('/', Path.DirectorySeparatorChar));
                    fullPath = fullPath.Replace("\\\\", "\\");*/


                    string directoryPath = Directory.GetCurrentDirectory();


                    string full_path_logo = Path.Combine(directoryPath + "/wwwroot", model.logo_image.Replace("http://localhost:5200/", string.Empty));
                    full_path_logo = full_path_logo.Replace("\\\\", "\\");


                    string full_path_signature = Path.Combine(directoryPath + "/wwwroot", model.sign_image.Replace("http://localhost:5200/", string.Empty));
                    full_path_signature = full_path_signature.Replace("\\\\", "\\");




                    /* var image = document.AddImage(imagePath);
                     var picture = image.CreatePicture();
                     picture.Width = 300;
                     picture.Height = 100;
                     var paragraph1 = document.InsertParagraph();
                     paragraph1.InsertPicture(picture);*/


                    var table = document.AddTable(1, 2);

                    table.SetWidthsPercentage(new[] { 60f, 50f });
                    table.Design = TableDesign.None;

                    var imageCell = table.Rows[0].Cells[0];
                    var image = document.AddImage(full_path_logo);
                    var picture = image.CreatePicture();

                    picture.Width = 150;
                    picture.Height = 90;

                    var imageParagraph = imageCell.Paragraphs[0];
                    imageParagraph.InsertPicture(picture);
                    imageParagraph.Alignment = Alignment.left;

                    // Access the second cell (column) for text
                    var textCell = table.Rows[0].Cells[1];
                    string originalText = "\n\n\n\n{{first_mobile}}\n{{first_email}}\n{{first_address}}, {{first_city}}, {{first_pincode}}";
                    string replacedText = originalText
                    .Replace("{{first_mobile}}", model.first_mobile)
                    .Replace("{{first_email}}", model.first_email)
                    .Replace("{{first_address}}", model.first_address)
                    .Replace("{{first_city}}", model.first_city)
                    .Replace("{{first_pincode}}", model.first_pincode);
                    textCell.Paragraphs[0].InsertText(replacedText);

                    textCell.Paragraphs[0].Alignment = Alignment.left;

                    document.InsertTable(table);

                    // Parse the template content and replace placeholders
                    var paragraph = document.InsertParagraph(templateContent1
                        .Replace("{{date}}", model.date)
                        .Replace("{{second_name}}", model.second_name)
                        .Replace("{{second_address}}", model.second_address)
                        .Replace("{{second_city}}", model.second_city)
                        .Replace("{{second_state}}", model.second_state)
                        .Replace("{{second_pincode}}", model.second_pincode)
                        .Replace("{{subject}}", model.subject)
                        .Replace("{{total_day}}", model.total_day)
                        .Replace("{{type_of_leave}}", model.type_of_leave)
                        .Replace("{{coWorker_name}}", model.coWorker_name)
                        .Replace("{{start_date}}", model.start_date)
                        .Replace("{{end_date}}", model.end_date)
                        .Replace("{{coming_date}}", model.coming_date)
                        .Replace("{{disease}}", model.disease)

                    // Add other replacements
                    );

                    // string imagePath = @"D:/33343.JPEG";

                    var image2 = document.AddImage(full_path_signature);
                    var picture2 = image2.CreatePicture();
                    picture2.Width = 50;
                    picture2.Height = 50;
                    var paragraph2 = document.InsertParagraph();
                    paragraph2.InsertPicture(picture2);

                    paragraph.Alignment = Alignment.left;


                    var paragraph3 = document.InsertParagraph("Authorized by {{designation}}.");
                    paragraph3.ReplaceText("{{designation}}", model.designation);
                    paragraph3.Alignment = Alignment.left;


                    document.SaveAs(stream);
                }

                // Reset the stream position before saving to a file
                stream.Position = 0;

                // Save the file to the specified path
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    stream.CopyTo(fileStream);
                }
            }
            return Content(filePath);
        }



        [HttpPost("html")]
        public IActionResult FirstProcess()
        {
            var htmlFilePath = Path.Combine("wwwroot", "htmltemp", "htmlpagedemo.html");
            var docxFilePath = Path.Combine("wwwroot", "ApplicationTemplate", "MyDocFile.docx");

            var path = @"./htmltemp/htmlpagedemo.html";

            ConvertFromStream();


            //if (System.IO.File.Exists(htmlFilePath))
            //{
            //    // Load HTML file
            //    DocumentCore htmlDocument = DocumentCore.Load(htmlFilePath, new HtmlLoadOptions());

            //    // Save as DOCX file
            //    htmlDocument.Save(docxFilePath);

            //    // Assuming you want to return the DOCX file as a response
            //    byte[] docxBytes = System.IO.File.ReadAllBytes(docxFilePath);
            //    return File(docxBytes, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "MyDocFile.docx");
            //}

            // Handle the case where the HTML file doesn't exist
            return NotFound();
        }


        static void ConvertFromStream()
        {

            // We need files only for demonstration purposes.
            // The conversion process will be done completely in memory.
            // string inpFile = @"..\..\..\example.html";


            //string inpFile = Path.Combine("wwwroot", "htmltemp", "htmlpagedemo.html");
            //string outFile = @"ResultStream.docx";
            //byte[] inpData = System.IO.File.ReadAllBytes(inpFile);
            //byte[] outData = null;



            //using (MemoryStream msInp = new MemoryStream(inpData))
            //{

            //    // Load a document.
            //    DocumentCore dc = DocumentCore.Load(msInp, new HtmlLoadOptions());

            //    // Save the document to DOCX format.
            //    using (MemoryStream outMs = new MemoryStream())
            //    {
            //        dc.Save(outMs, new DocxSaveOptions());
            //        outData = outMs.ToArray();
            //    }
            //    // Show the result for demonstration purposes.
            //    if (outData != null)
            //    {
            //        System.IO.File.WriteAllBytes(outFile, outData);
            //        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            //    }
            //}
        }


        [HttpPost("uploadsignatureimage")]
        [Produces("application/json", Type = typeof(ApplicationMasterResp))]

        public IActionResult UploadApplicationSignature(IFormFile? signature)
        {
            try
            {
                if (signature == null || signature.Length == 0)
                {
                    return BadRequest(new { status = 404, message = "image is Required", data = false });
                }


                string fileExtension = Path.GetExtension(signature.FileName)?.ToLower();
                if (fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".png")
                {
                    return BadRequest(new { status = 400, message = "Invalid file format. Only JPG, JPEG, and PNG files are allowed.", data = false });
                }


                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Signature_image");
                if (!Directory.Exists(uploadDirectory))
                {
                    Directory.CreateDirectory(uploadDirectory);
                }


                string fileName = $"{DateTime.Now:yyyyMMddHHmmss}_{signature.FileName}";

                var filePath = Path.Combine(uploadDirectory, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    signature.CopyTo(stream);
                }
                var base_url = $"{Configurations["BaseUrl"]}/Signature_image/{fileName}";


                objAction = CreatedAtAction("UploadApplicationSignature", new
                {
                    status = true,
                    Message = "File upload successfully",
                    Data = base_url
                });
                return objAction;

            }
            catch (Exception ex)
            {
                ApplicationMasterResp data = new ApplicationMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadApplicationSignature", data);
                return objAction;

            }
        }


        [HttpPost("uploadheader")]
        [Produces("application/json", Type = typeof(ApplicationMasterResp))]

        public IActionResult UploadApplicationHeader(IFormFile? header)
        {
            try
            {
                if (header == null || header.Length == 0)
                {
                    return BadRequest(new { status = 404, message = "image is Required", data = false });
                }


                string fileExtension = Path.GetExtension(header.FileName)?.ToLower();
                if (fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".png")
                {
                    return BadRequest(new { status = 400, message = "Invalid file format. Only JPG, JPEG, and PNG files are allowed.", data = false });
                }


                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Header_image");
                if (!Directory.Exists(uploadDirectory))
                {
                    Directory.CreateDirectory(uploadDirectory);
                }


                string fileName = $"{DateTime.Now:yyyyMMddHHmmss}_{header.FileName}";

                var filePath = Path.Combine(uploadDirectory, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    header.CopyTo(stream);
                }
                var base_url = $"{Configurations["BaseUrl"]}/Header_image/{fileName}";


                objAction = CreatedAtAction("UploadApplicationHeader", new
                {
                    status = true,
                    Message = "File upload successfully",
                    Data = base_url
                });
                return objAction;

            }
            catch (Exception ex)
            {
                ApplicationMasterResp data = new ApplicationMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadApplicationHeader", data);
                return objAction;

            }
        }
    }
}