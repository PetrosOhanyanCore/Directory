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
        Task<Response> GetCurrentDirectoryContent(string path);

        /// <summary>
        /// Get the Previous path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>string: Previous path</returns>
        Task<string> GetPrevious(string path);
    }
}
