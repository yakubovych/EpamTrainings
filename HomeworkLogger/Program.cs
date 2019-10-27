namespace HomeworkLogger
{
    using System;
    using LibraryOfProject;
    using NLog;
    using System.Configuration;

    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            // Custom Logger example
            //LoggerRealisation logerDll = new LoggerRealisation(new Output());
            //try
            //{
            //    FakeError fakeError = new FakeError();
            //    fakeError.DoSomeMath();
            //}
            //catch (Exception e)
            //{
            //    logerDll.Log("Сheck method.|" + e.Message);
            //}

            try
            {
                logger.Info("Hello world");
                throw new IndexOutOfRangeException();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Bye!");
            }
        }
    }
}
