namespace HomeworkSolid
{
    using System;
    using System.Configuration;
    using System.IO;

    class Calculator : ICalculator
    {
        private static string path = ConfigurationManager.AppSettings[@"CalcPath"].ToString();
        StreamWriter streamWriter;
        FileInfo calcFile = new FileInfo(path);

        public void CalculateToConsole(int x, int y)
        {
            Console.WriteLine($"Your sum = {x + y}");
        }

        public void CalculateToFile(int x, int y)
        {
            streamWriter = calcFile.AppendText();
            streamWriter.WriteLine($"Your sum = {x + y}" + "\n");
            streamWriter.Close();
        }

        public void ReadFromFile()
        {
            using (FileStream fstream = File.OpenRead(path))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Info from file:\n{textFromFile}");
            }
        }
    }
}
