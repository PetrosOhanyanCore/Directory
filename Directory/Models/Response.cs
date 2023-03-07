namespace Directory.Models
{
    public class Response
    {
        public bool status { get; set; }
        public string message { get; set; }
        public DirectoryContent data { get; set; } = new DirectoryContent();
    }
}
