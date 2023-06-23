namespace FolderScanner.Models
{
    public class MediaFile : PrototypeFile
    {
        public string TypeFile { get; set; }

        public MediaFile(string name, double size, string type) : base(name, size)
        {
            TypeFile = type;
        }
    }
}