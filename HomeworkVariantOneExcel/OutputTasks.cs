namespace HomeworkVariantOneExcel
{
    using System;
    using System.Configuration;
    using System.Diagnostics;
    using LibraryOfProject;
    using NLog;

    public class OutputTasks
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string firstValueOfColumn = ConfigurationManager.AppSettings["firstColumn"];
        private static string secondValueOfColumn = ConfigurationManager.AppSettings["secondColumn"];
        private IConsole Output;

        public OutputTasks(IConsole Output)
        {
            this.Output = Output;
        }

        public void RunTasks()
        {
            Stopwatch stopWatch = new Stopwatch();
            try
            {
                stopWatch.Start();
                int firstColumn;
                int.TryParse(firstValueOfColumn, out firstColumn);
                int secondColumn;
                int.TryParse(secondValueOfColumn, out secondColumn);

                Excel excel = new Excel(firstColumn, secondColumn);

                excel.WriteToExcel();
                Output.Write("Full data from excel file: ");

                excel.ReadExcel();
                Output.Write("Unique files: ");
                foreach (var item in excel.GetUnique())
                {
                    Output.Write(item);
                }

                stopWatch.Stop();
                Output.Write("RunTime : " + stopWatch.ElapsedMilliseconds + " ms \n");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
