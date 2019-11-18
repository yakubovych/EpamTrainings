namespace HomeworkAsynchrony
{
    using LibraryOfProject;
    using NLog;
    using System;

    public class OutputTasks
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private IConsole Output;

        public OutputTasks(IConsole Output)
        {
            this.Output = Output;
        }

        public void RunTasks()
        {
            try
            {
                AsynchronousMatrix parallelSum = new AsynchronousMatrix();
                parallelSum.ReceiveParallelSumOfElementsOfArray();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
