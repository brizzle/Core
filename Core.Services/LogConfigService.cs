namespace Core.Services
{
    public class LogConfigService
    {
        public LogConfigService(string file, string path)
        {
            FileName = file;
            FilePath = path;
        }

        public string FileName { get; private set; }

        public string FilePath { get; private set; }
    }
}
