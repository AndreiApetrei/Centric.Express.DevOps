using System;
using System.IO;
using CentricExpress.DevOps.Logging.Cons;

namespace CentricExpress.DevOps.Logging
{
    public class LogInFile : ILog
    {
        public void Run(string filePath, string env)
        {
            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            var fullPath = $@"{filePath }\{Const.FileName}";

            using (StreamWriter file = new StreamWriter(fullPath, true))
            {
                WriteInFile(env, file);
            }
        }

        private static void WriteInFile(string env, StreamWriter file)
        {
            var line = $"[{env}] {DateTime.Now.ToString("dd MM yyyy HH:mm:ss")} - {Const.LoggingText}";

            file.WriteLine(line);
        }
    }
}
