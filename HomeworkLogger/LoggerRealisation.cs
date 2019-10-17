namespace HomeworkLogger
{
    using System;
    using System.Configuration;
    using System.IO;
    using LibraryOfProject;

    public class LoggerRealisation : ILogger
    {
        private IConsole Output;

        private static string path = ConfigurationManager.AppSettings[@"AssemblyPath"].ToString();
        StreamWriter streamWriter;
        FileInfo logFile = new FileInfo(path);

        public LoggerRealisation(IConsole Output)
        {
            this.Output = Output;
        }

        public void Log(string message)
        {
            streamWriter = logFile.AppendText();
            streamWriter.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss\t"));
            streamWriter.WriteLine(message + "\n");
            streamWriter.Close();
        }

        public void ReadLog()
        {
            using (StreamReader streamReader = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Output.Write(line);
                }
            }
        }
    }
}
