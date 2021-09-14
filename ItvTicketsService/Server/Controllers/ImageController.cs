using ItvTicketsService.Server.Logics;
using ItvTicketsService.Server.Models;
using ItvTicketsService.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]

    public class ImageController : ControllerBase
    {
        private readonly IFileManagerLogic _fileManagerLogic;

        public ImageController(IFileManagerLogic fileManagerLogic)
        {
            _fileManagerLogic = fileManagerLogic;
        }

        [Route("upload")]
        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var folder = Request.Headers["folder"];
                var file = formCollection.Files.First();
                
                if (file.Length > 0)
                {
                    FileModel fileModel = new FileModel();
                    fileModel.ImageFile = file;
                    fileModel.Folder = folder;
                    var imgUrl = await _fileManagerLogic.Upload(fileModel);
                    return Ok(imgUrl);
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [Route("get")]
        [HttpGet]
        public async Task<IActionResult> Get(string fileName)
        {
            var imgBytes = await _fileManagerLogic.Get(fileName);

            return File(imgBytes, "image/webp");
        }

        [Route("download")]
        [HttpGet]
        public async Task<IActionResult> Download(string fileName)
        {
            var imagBytes = await _fileManagerLogic.Get(fileName);
            return new FileContentResult(imagBytes, "application/octet-stream")
            {
                FileDownloadName = Guid.NewGuid().ToString() + ".webp",
            };
        }

        [Route("delete")]
        [HttpPost]
        public async Task<IActionResult> Delete(DeviceImageFile deviceImageFile)
        {
            await _fileManagerLogic.Delete(deviceImageFile.Name, deviceImageFile.Folder);
            return Ok();
        }

        [Route("list")]
        [HttpGet]
        public async Task<ActionResult<List<string>>> List(string container, string folder)
        {
            return Ok(await _fileManagerLogic.List(container, folder));
        }

    }
}
