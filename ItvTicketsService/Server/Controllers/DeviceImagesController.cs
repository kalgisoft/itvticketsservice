using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;

namespace ItvTicketsService.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeviceImagesController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DeviceImagesController(IWebHostEnvironment webHost)
        {
            _webHostEnvironment = webHost;

        }

        //Get Device images by device code
        [HttpGet("{Code}")]
        //public async Task<ActionResult<string>> DeviceImages(string Code)
        public async Task<ActionResult<List<string>>> DeviceImages(string Code)
        {
            try
            {
                string path1 =  $"{Directory.GetCurrentDirectory()}{@"\deviceimages\"}{Code}";
                List<string> filesList = new List<string>();

                var files = Directory.GetFiles(path1);
                foreach (var file in files)
                {
                    filesList.Add(Path.GetFileName(file));
                }

                if (1 == 0)
                {
                    return NotFound();
                }

                return Ok(filesList);
            }
            catch (Exception ex)
            {
                string ss = ex.Message;

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving images from server");
            }
        }

/*
        [HttpGet("{code}/{filename}")]
        public async Task<HttpResponseMessage> GetImageFile(string code, string filename)
        {
            var result = new HttpResponseMessage(HttpStatusCode.OK);
           
            string path1 = $"{Directory.GetCurrentDirectory()}{@"\deviceimages\"}{code}";

            byte[] data = null;
            FileInfo finfo = new FileInfo(Path.Combine(path1, filename));
            if (finfo.Exists)
            {          
                data = new byte[finfo.Length];
                using (FileStream fs = finfo.OpenRead())
                {
                    fs.Read(data, 0, data.Length);
                }

                //finfo.Delete();
                //strImage = Convert.ToBase64String(data);

                var fileMemStream = new MemoryStream(data);
                long fsl = fileMemStream.Length;
                result.Content = new StreamContent(fileMemStream);

                var headers = result.Content.Headers;
                headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                headers.ContentDisposition.FileName = finfo.FullName;

                headers.ContentType = new MediaTypeHeaderValue("application/octet-stream"); //octet-stream
                headers.ContentLength = fileMemStream.Length;

                return result;
            }
 
            return result;
        }
*/

        [HttpGet("{code}/{filename}")]
        public async Task<ActionResult> GetImageFile(string code, string filename)
        {
            string path1 = $"{Directory.GetCurrentDirectory()}{@"\deviceimages\"}{code}";
            var mimeType = "application/octet-stream";
            byte[] data = null;
            FileInfo finfo = new FileInfo(Path.Combine(path1, filename));
            if (finfo.Exists)
            {
                data = new byte[finfo.Length];
                using (FileStream fs = finfo.OpenRead())
                {
                    fs.Read(data, 0, data.Length);
                }
            }

            return Ok(new FileContentResult(data, mimeType));
        }

        //si usa cosi'
        //<img src= '@Url.Action("GetUserImageFile", "Manage")'/>
        //<img src="@Url.Action("GetImage", "Foo", new { id = myImageIdentifier }">
        //<img src="data:image/bmp;base64, @(Convert.ToBase64String(admin.GetCategoryLabelImage(label.Id)))"/>
        //<img src={`data:image/png;base64, ${encoded}`} />

        // upload image files da BCL, Blazor & Core Learning
        [HttpPost]
        public async Task<IActionResult> PostImage(IFormFile image)
	    {
            if (image==null || image.Length==0)
            {
                return BadRequest("Error 1");
            }

            string fileName = image.FileName;
            string ext = Path.GetExtension(fileName);

            string[] allow = { ".jpg", ".png" };

            if (!allow.Contains(ext.ToLower())) return BadRequest("Invalid Image");

            string fileNameNew = $"{Guid.NewGuid()}{ext}";
            string filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "wwwroot", "Files", fileNameNew);


            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await image.CopyToAsync(fileStream);
            }

            return Ok($"File Uploaded");
	    }
    }
}
