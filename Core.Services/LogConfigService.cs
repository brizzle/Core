using System.IO;

namespace Core.Services
{
    public class LogConfigService
    {
        public LogConfigService(string file, string path)
        {
            FileName = file;
            FilePath = path;
        }
        
        public string ConnectionString
        {
            get
            {
                return Path.Combine(FilePath, FileName + ".log");
            }
        }

        public string FileName { get; private set; }

        public string FilePath { get; private set; }
    }
}
