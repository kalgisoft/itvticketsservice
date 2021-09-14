using ItvTicketsService.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Logics
{
    public interface IFileManagerLogic
    {
        Task<string> Upload(FileModel model);
        Task<byte[]> Get(string imageName);
        Task Delete(string imageName, string folder);
        Task<List<string>> List(string container, string folder);
    }
}
