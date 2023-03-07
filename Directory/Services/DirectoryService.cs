using Directory.Models;
using System.IO;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Directory.Services
{
    public class DirectoryService : IDirectoryService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public DirectoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUrl = "https://localhost:7121/Directory";
        }

        public async Task<string> GetCurrentDirectory()
        {
            var response = await _httpClient.SendAsync(new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_baseUrl}/GetCurrentDirectory")
            });

            var responseBody = await response.Content.ReadAsStringAsync();
            //var result = JsonSerializer.Deserialize<string>(responseBody);

            return responseBody;
        }

        public async Task<Response> GetCurrentDirectoryContent(string path)
        {
            var response = await _httpClient.SendAsync(new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_baseUrl}/GetCurrentDirectoryContent?path={path}")
            });

            var responseBody = await response.Content.ReadAsStringAsync();
            Response result = JsonSerializer.Deserialize<Response>(responseBody);

            return result;
        }
    }
}