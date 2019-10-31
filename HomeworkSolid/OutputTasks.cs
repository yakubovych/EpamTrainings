namespace HomeworkSolid
{
    using System;
    using LibraryOfProject;
    using NLog;

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
            int firstNumber;
            int secondNumber;
            Calculator calculator = new Calculator();
            Output.Write("Enter first number: ");
            while (!int.TryParse(Output.Read(), out firstNumber))
            {
                Output.Write("Input error! Enter integer: ");
            }

            Output.Write("Enter second number: ");
            while (!int.TryParse(Output.Read(), out secondNumber))
            {
                Output.Write("Input error! Enter integer: ");
            }

            try
            {
                calculator.CalculateToConsole(firstNumber, secondNumber, '+');
                calculator.CalculateToFile(firstNumber, secondNumber, '/');
                calculator.ReadFromFile();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Problems with file!");
            }
        }
    }
}
