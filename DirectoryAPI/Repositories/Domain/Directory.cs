using DirectoryAPI.Repositories.InterFaces;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Reflection;

namespace DirectoryAPI.Repositories.Domain
{
    public class Directory : IDirectory
    {
        public void ChangeCurrentDirectory(string newDirectory)
        {
            Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location);       
        }

        public string GetCurrentDirectory()
        {
            var result = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location);
            return result;
        }

        public async Task<List<string>> GetCurrentDirectoryContent(string path)
        {
            var filePaths = System.IO.Directory.GetFiles(path,"*.*", SearchOption.TopDirectoryOnly);
            var result = System.IO.Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);

            var res = new List<string>();
            foreach (var file in filePaths) { res.Add(file); }
            foreach (var r in result) { res.Add(r); }
            
            return res.ToList();
        }
    }
}
