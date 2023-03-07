namespace Directory.Models
{
    public class Response
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public DirectoryContent Data { get; set; } = new DirectoryContent();
    }
}
