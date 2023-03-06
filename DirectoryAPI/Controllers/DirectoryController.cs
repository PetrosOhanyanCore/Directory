using DirectoryAPI.Models;
using DirectoryAPI.Repositories.InterFaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DirectoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        private readonly IDirectory _directory;

        public DirectoryController(IDirectory directory)
        {
            _directory = directory;
        }
        // GET: api/<DirectoryController>
        [HttpGet]
        public async Task<Response> GetCurrentDirectoryContent(string path)
        {
            var result = await _directory.GetCurrentDirectoryContent(path);
            return result;
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
