namespace HomeworkLogger
{
    using System;
    using LibraryOfProject;
    using System.Configuration;

    class Program
    {
        static void Main(string[] args)
        {
            LoggerRealisation logerDll = new LoggerRealisation(new Output());
            try
            {
                FakeError fakeError = new FakeError();
                fakeError.DoSomeMath();
            }
            catch (Exception e)
            {
                logerDll.Log("Сheck method.|" + e.Message);
            }
        }
    }
}
