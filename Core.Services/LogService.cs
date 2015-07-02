using System;
using System.IO;

namespace Core.Services
{
    public class LogService
    {
        private string fileName;

        public LogService(string fileName)
        {
            this.fileName = fileName;
        }

        public void LogInfo(string message)
        {
            using (var writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine("[{0:MM:dd:yy H:mm:ss}] {1}\r\n", DateTime.Now, message);
            }
        }

        public void LogError(string message)
        {
            using (var writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine("[{0:MM:dd:yy H:mm:ss}] ERROR - {1}\r\n", DateTime.Now, message);
            }
        }

        public void LogQuery(string message)
        {
            using (var writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(message + "\r\n");
            }
        }
    }
}
