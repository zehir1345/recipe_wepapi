using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Abstractions.Storage;

namespace TezAPI.Infrastructure.Services.Storage
{
    public class StorageService : IStorageService
    {
        IStorage _storage;
        public StorageService(IStorage storage)
        {
            _storage = storage;
        }

        public string StorageName { get => _storage.GetType().Name;}

        public async Task DeleteAsync(string path, string fileName)
          =>await _storage.DeleteAsync(path, fileName);

        public List<string> GetFiles(string pathOrContainer)
         => _storage.GetFiles(pathOrContainer);

        public bool HasFile(string pathOrContainer, string fileName)
         => _storage.HasFile(pathOrContainer, fileName);

        public Task<List<(string fileName, string pathOrContainer)>> UploadAsync(string path, IFormFileCollection files)
         => _storage.UploadAsync(path, files);
    }
}
