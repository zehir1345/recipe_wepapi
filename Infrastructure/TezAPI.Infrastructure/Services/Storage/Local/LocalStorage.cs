﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Abstractions.Storage.Local;

namespace TezAPI.Infrastructure.Services.Storage.Local
{
    public class LocalStorage :Storage, ILocalStorage
    {
        readonly IWebHostEnvironment _webHostEnvironment;

        public LocalStorage(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task DeleteAsync(string path, string fileName)
         => File.Delete($"{path}\\{fileName}");

        public List<string> GetFiles(string path)
        {
            DirectoryInfo directoryInfo = new(path);
            return directoryInfo.GetFiles().Select(f => f.Name).ToList();
        }

        public bool HasFile(string path, string fileName)
           => File.Exists($"{path}\\{fileName}");
        private async Task<bool> CopyFileAsync(string filePath, IFormFile file)
        {
            try
            {
                await using FileStream fileStream = new(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;
            }
            catch (Exception ex)
            {
                //todo log!
                throw ex;
            }

        }
        public async Task<List<(string fileName, string pathOrContainer)>> UploadAsync(string path, IFormFileCollection files)
        {
            string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, path);

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            List<(string fileName, string path)> datas = new();
            foreach (IFormFile file in files)
            {
                string newFileName = await FileRenameAsync(uploadPath, file.FileName);
                await CopyFileAsync($"{uploadPath}\\{newFileName}", file);
                datas.Add((newFileName, $"{path}\\{newFileName}"));
            }

            return datas;
        }

    }
}
