namespace HomeworkExceptions
{
    using System;
    using HomeworkLogger;
    using LibraryOfProject;

    public class OutputTasks
    {
        private IConsole Output;
        LoggerRealisation logger = new LoggerRealisation(new Output());

        public OutputTasks(IConsole Output)
        {
            this.Output = Output;
        }

        public void RunTasks()
        {
            Output.Write("\n--- Task1 ---");
            try
            {
                GeneratorOfExceptions.GenerateStackOverflowException();
            }
            catch (StackOverflowException e)
            {
                logger.Log(e.Message);
            }

            Output.Write("----------------------------");

            Output.Write("\n--- Task2 ---");
            try
            {
                GeneratorOfExceptions.GenerateIndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException e)
            {
                logger.Log(e.Message);
            }

            Output.Write("----------------------------");

            Output.Write("\n--- Task3 ---");

            Output.Write("Generated exceptions logged in event viewer. Add screenshot to the project 'Task3EventViewer.png'");

            Output.Write("----------------------------");

            Output.Write("\n--- Task4 ---");

            try
            {
                GeneratorOfExceptions.GenerateStackOverflowException();
                GeneratorOfExceptions.GenerateIndexOutOfRangeException();
            }
            catch (StackOverflowException e)
            {
                logger.Log(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                logger.Log(e.Message);
            }

            Output.Write("----------------------------");

            Output.Write("\n--- Task5 ---");

            try
            {
                GeneratorOfExceptions.DoSomeMath(-1, 2);
                GeneratorOfExceptions.DoSomeMath(1, 2);
            }
            catch (ArgumentException e)
            when (e.ParamName == "a")
            {
                logger.Log(e.Message);
            }
            catch (ArgumentException e)
            when (e.ParamName == "b")
            {
                logger.Log(e.Message);
            }

            Output.Write("----------------------------");
        }
    }
}
