using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Infrastructure.Operations;

namespace TezAPI.Infrastructure.Services.Storage
{
    public class Storage
    {

        protected async Task<string> FileRenameAsync(string path, string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string oldname = Path.GetFileNameWithoutExtension(fileName);
            string regulatedfilename = NameOperation.CharacterRegulatory(oldname);

            var files = Directory.GetFiles(path, regulatedfilename + "*"); //bu isimle başlayan tüm dosyaları bulur

            if (files.Length == 0) return regulatedfilename + "-1" + extension; //demek ki bu isimde ilk kez dosya yükleniyor.

            int[] filenumbers = new int[files.Length];  //dosya numaralarını buraya alıp en yükseğini bulucaz.
            int lasthyphenındex;
            for (int i = 0; i < files.Length; i++)
            {
                lasthyphenındex = files[i].LastIndexOf("-");
                filenumbers[i] = int.Parse(files[i].Substring(lasthyphenındex + 1, files[i].Length - extension.Length - lasthyphenındex - 1));
            }
            var biggestnumber = filenumbers.Max(); //en yüksek sayıyı bulduk
            biggestnumber++;
            return regulatedfilename + "-" + biggestnumber + extension; //bir artırıp dönüyoruz
        }
    }
}
