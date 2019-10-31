namespace HomeworkSolid
{
    using System.Configuration;
    using NLog;
    using System;
    using System.IO;

    class Calculator : ICalculator
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string path = ConfigurationManager.AppSettings[@"CalcPath"].ToString();
        StreamWriter streamWriter;
        FileInfo calcFile = new FileInfo(path);

        public void CalculateToConsole(int x, int y, char operation)
        {
            try
            {
                switch (operation)
                {
                    case '+':
                        Console.WriteLine(string.Format($"Your result = {x + y} \n"));
                        break;

                    case '-':
                        Console.WriteLine(string.Format($"Your result = {x - y} \n"));
                        break;

                    case '*':
                        Console.WriteLine(string.Format($"Your result = {x * y} \n"));
                        break;

                    case '/':
                        if (y == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        else
                        {
                            Console.WriteLine(string.Format($"Your result = {x / y} \n"));
                        }

                        break;

                    default:
                        Console.WriteLine("Input error!");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(string.Format($"{ex.Message} \n"));
                logger.Error(ex.ToString());
            }
            catch (Exception ex)
            {
                logger.Error(string.Format($"{ex.Message} \n"));
                throw;
            }
        }

        public void CalculateToFile(int x, int y, char operation)
        {
            streamWriter = calcFile.AppendText();
            try
            {
                switch (operation)
                {
                    case '+':
                        streamWriter.WriteLine($"Your result = {x + y}" + "\n");
                        break;

                    case '-':
                        streamWriter.WriteLine($"Your result = {x - y}" + "\n");
                        break;

                    case '*':
                        streamWriter.WriteLine($"Your result = {x * y}" + "\n");
                        break;

                    case '/':
                        if (y == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        else
                        {
                            streamWriter.WriteLine($"Your result = {x / y}" + "\n");
                        }

                        break;

                    default:
                        Console.WriteLine("Input error!");
                        break;

                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(string.Format($"{ex.Message} \n"));
                logger.Error(ex.ToString());
            }
            catch (Exception ex)
            {
                logger.Error(string.Format($"{ex.Message} \n"));
                throw;
            }

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
