namespace Directory.Models
{
    public class DirectoryContent
    {
        public List<File> Files { get; set; } = new List<File>();
        public List<Folder> Folders { get; set; } = new List<Folder>();
    }
}
