using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Abstractions.Storage
{
    public interface IStorage
    {
        Task<List<(string fileName, string pathOrContainer)>> UploadAsync(string path, IFormFileCollection files);
        Task DeleteAsync(string path,string fileName);
        List<string> GetFiles(string pathOrContainer);
        bool HasFile(string pathOrContainer,string fileName);
    }
}
