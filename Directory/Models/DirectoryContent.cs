namespace Directory.Models
{
    public class DirectoryContent
    {
        public List<File> files { get; set; } = new List<File>();
        public List<Folder> folders { get; set; } = new List<Folder>();
    }
}
