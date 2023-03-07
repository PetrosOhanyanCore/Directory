using DirectoryAPI.Models;
using DirectoryAPI.Repositories.InterFaces;
using Microsoft.AspNetCore.Mvc;


namespace DirectoryAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        private readonly IDirectory _directory;

        public DirectoryController(IDirectory directory)
        {
            _directory = directory;
        }

        [HttpGet(Name = "GetCurrentDirectoryContent")]
        public async Task<Response> GetCurrentDirectoryContent(string path)
        {
            var result = await _directory.GetCurrentDirectoryContent(path);
            return result;
        }

        [HttpGet(Name = "GetCurrentDirectory")]
        public Task<string> GetCurrentDirectory()
        {
            var result = _directory.GetCurrentDirectory();
            return Task.FromResult(result);
        }

        [HttpGet(Name = "GetPrevious")]
        public async Task<string> GetPrevious(string path)
        {
            var result = await _directory.GetPrevious(path);
            return result;
        }
    }
}
