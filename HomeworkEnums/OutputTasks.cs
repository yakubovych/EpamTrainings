namespace HomeworkEnums
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
            Output.Write("Input number of month: ");
            int n;
            int.TryParse(Output.Read(), out n);
            if (n < 1 || n > 12)
            {
                Output.Write("Incorrect input!");
            }

            Output.Write($"{(Months)n}");
            Output.Write("----------------------------");

            Output.Write("\n--- Task2 ---");
            ColorsExtension.SortedColors();
            Output.Write("----------------------------");

            Output.Write("\n--- Task3 ---");
            foreach (var i in Enum.GetValues(typeof(LongRange)))
            {
                Output.Write($"{(long)i}");
            }

            Output.Write("----------------------------");
        }
    }
}
