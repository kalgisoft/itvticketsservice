using ItvTicketsService.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlobExplorerController : ControllerBase
    {
        private readonly IBlobService _blobService;

        public BlobExplorerController(IBlobService blobService)
        {
            _blobService = blobService;
        }

        [HttpGet("{blobName}")]
        public async Task<IActionResult> GetBlob(string blobName)
	    {
            var data = await _blobService.GetBlobAsync(blobName);
            //return File(data.Content, data.Content);

            return Ok(data);
	    }

        [HttpGet]
        public async Task<IActionResult> ListBlobs()
        {
            int k = 0;
            try
            {
                return Ok(await _blobService.ListBlobsAsync());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from cloud");
            }
        }

        [HttpPost("uploadfile")]
        public async Task<IActionResult> UploadFile()
        {
            IFormFile file = Request.Form.Files[0];
            if (file == null)
            {
                return BadRequest();
            }
            return Ok();

            /*
            var result = await _blobService.UploadFileBlobAsync(file.FileName, file.FileName);

            var toReturn = result.AbsoluteUri;

            return Ok(new { path = toReturn });
            */
        }

        [HttpPost("uploadcontent")]
        public async Task<IActionResult> UploadContent()
        {
            //await _blobService.UploadContentBlobAsync();
            return Ok();
        }

    }
}
