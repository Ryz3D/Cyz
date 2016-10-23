namespace Cyz_IDE
{
    public interface FileManager
    {
        string[] GetLines(string identifier);
        void SetLines(string identifier, string[] content);
    }
}