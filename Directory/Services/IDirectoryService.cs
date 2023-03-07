using Directory.Models;

namespace Directory.Services
{
    public interface IDirectoryService
    {
        /// <summary>
        /// Returns the current directory
        /// </summary>
        /// <returns>Directory name</returns>
        Task<string> GetCurrentDirectory();

        /// <summary>
        /// Returns a list with information about the contents of the current directory
        /// </summary>
        /// <returns>Information about the contents</returns>
        Task<ResponseModel> GetCurrentDirectoryContent(string path);
    }
}
