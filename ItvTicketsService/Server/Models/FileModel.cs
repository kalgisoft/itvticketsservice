using Microsoft.AspNetCore.Http;

namespace ItvTicketsService.Server.Models
{
    public class FileModel
    {
        public IFormFile ImageFile { get; set; }
        public string Folder { get; set; }
    }
}
