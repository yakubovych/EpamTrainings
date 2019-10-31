namespace HomeworkVariantTwoFolderComparer
{
    using System;
    using System.Configuration;
    using System.Diagnostics;
    using LibraryOfProject;
    using NLog;

    public class OutputTasks
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string pathFirst = ConfigurationManager.AppSettings[@"FirstPathToCompare"].ToString();
        private static string pathSecond = ConfigurationManager.AppSettings[@"SecondPathToCompare"].ToString();
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
                FolderComparer folderComparer = new FolderComparer(pathFirst, pathSecond);
                Output.Write("Unique files: ");
                foreach (var item in folderComparer.UniqueFiles())
                {
                    Output.Write(item);
                }

                Output.Write("Duplicate files: ");
                foreach (var item in folderComparer.DuplicateFiles())
                {
                    Output.Write(item);
                }

                Output.Write("Number of duplicate files: ");
                Output.Write(folderComparer.NumberOfDuplicateFiles().ToString());
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
