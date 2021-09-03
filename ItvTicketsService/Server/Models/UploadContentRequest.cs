using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Models
{
    public class UploadContentRequest
    {
        public string Content { get; set; }
        public string FileName { get; set; }
    }
}
