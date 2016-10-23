using System.IO;

namespace Cyz_IDE
{
    public class LocalFiles : FileManager
    {
        public LocalFiles() { }

        public string[] GetLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public void SetLines(string path, string[] content)
        {
            File.WriteAllLines(path, content);
        }
    }
}