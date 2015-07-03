using System.IO;

namespace Core.Services
{
    public class DatabaseConfigService
    {
        public DatabaseConfigService(string file, string path)
        {
            FileName = file;
            FilePath = path;
        }

        public string ConnectionString
        {
            get
            {
                return Path.Combine("Data Source=" + FilePath, FileName + ".sqlie");
            }
        }

        public string FileName { get; private set; }

        public string FilePath { get; private set; }
    }
}
