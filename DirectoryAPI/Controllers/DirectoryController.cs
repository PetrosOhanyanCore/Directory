using DirectoryAPI.Models;
using DirectoryAPI.Repositories.InterFaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        // GET api/<DirectoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DirectoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DirectoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DirectoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
