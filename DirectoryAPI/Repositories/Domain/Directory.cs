using DirectoryAPI.Repositories.InterFaces;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Reflection;
using DirectoryAPI.Models;

namespace DirectoryAPI.Repositories.Domain
{
    public class Directory : IDirectory
    {
        public string GetCurrentDirectory()
        {
            var result = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return result;
        }

        public Task<Response> GetCurrentDirectoryContent(string path)
        {
            var response = new Response();

            try
            {
                var filePaths = System.IO.Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
                var folderPaths = System.IO.Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);

                var result = new DirectoryContent();
                result.Files = new List<Models.File>();
                result.Folders = new List<Models.Folder>();

                foreach (var filePath in filePaths)
                {
                    var newFile = new Models.File();
                    var fileName = Path.GetFileName(filePath);
                    long size = new System.IO.FileInfo(filePath).Length;

                    newFile.Name = fileName;
                    newFile.Size = size.ToString();
                    newFile.Path = filePath;
                    result.Files.Add(newFile);
                }

                foreach (var folderPath in folderPaths)
                {
                    var newFolder = new Models.Folder();
                    var folderName = Path.GetFileName(folderPath);

                    newFolder.Name = folderName;
                    newFolder.Path = folderPath;
                    result.Folders.Add(newFolder);
                }

                response.Status = true;
                response.Message = null;
                response.Data = result;

                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
                response.Data = null;
                return Task.FromResult(response);
            }
        }

        public Task<string> GetPrevious(string path)
        {
            string parent = Path.GetDirectoryName(path);
            return Task.FromResult(parent);
        }
    }
}
