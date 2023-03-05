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

        public Task<List<FileInfo>> GetCurrentDirectoryContent()
        {
            throw new NotImplementedException();
        }
    }
}
