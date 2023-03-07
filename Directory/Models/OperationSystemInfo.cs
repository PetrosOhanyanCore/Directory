namespace Directory.Models
{
    public class OperationSystemInfo
    {
        public string Name { get; set; }
        public string CurrentDirectory { get; set; }
        public List<string> FolderNames { get; set; }
        public List<string> FileNames { get; set; }
    }
}
