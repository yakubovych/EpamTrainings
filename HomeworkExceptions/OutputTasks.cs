namespace HomeworkExceptions
{
    using System;
    using LibraryOfProject;

    public class OutputTasks
    {
        private IConsole Output;

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
                Output.Write(e.Message);
            }

            Output.Write("----------------------------");

            Output.Write("\n--- Task2 ---");
            try
            {
                GeneratorOfExceptions.GenerateIndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException e)
            {
                Output.Write(e.Message);
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
                Output.Write(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Output.Write(e.Message);
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
                Output.Write(e.Message);
            }
            catch (ArgumentException e)
            when (e.ParamName == "b")
            {
                Output.Write(e.Message);
            }

            Output.Write("----------------------------");
        }
    }
}
