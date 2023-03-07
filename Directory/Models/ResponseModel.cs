namespace Directory.Models
{
    public class ResponseModel
    {
        public bool Status { get; set; }
        public string? Message { get; set; }
        public DirectoryContentModel? Data { get; set; }
    }
}
