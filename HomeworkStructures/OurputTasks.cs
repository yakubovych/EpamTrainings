namespace HomeworkStructures
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
            Output.Write("Enter your name: ");
            string name = Output.Read();
            Output.Write("Enter your surname: ");
            string surname = Output.Read();
            int age;
            Output.Write("Enter your age: ");
            int.TryParse(Output.Read(), out age);

            if (String.IsNullOrEmpty(name) && name.Length > 1)
            {
                Output.Write("Incorrect input!");
            }

            if (String.IsNullOrEmpty(surname) && surname.Length > 1)
            {
                Output.Write("Incorrect input!");
            }

            if (age <= 1 || age >= 100)
            {
                Output.Write("Incorrect input");
            }

            Person person = new Person(name, surname, age);
            int n;
            Output.Write("Enter number to compare: ");
            int.TryParse(Output.Read(), out n);
            person.CompareAgeWithInput(n);
            Output.Write("----------------------------");

            Output.Write("\n--- Task2 ---");
            double width;
            Output.Write("Enter width of rectangle: ");
            double.TryParse(Output.Read(), out width);
            double height;
            Output.Write("Enter height of rectangle: ");
            double.TryParse(Output.Read(), out height);
            double x;
            Output.Write("Enter X coordinate of rectangle: ");
            double.TryParse(Output.Read(), out x);
            double y;
            Output.Write("Enter Y coordinate of rectangle: ");
            double.TryParse(Output.Read(), out y);
            Rectangle rectangle = new Rectangle { Width = width, Height = height, X = x, Y = y };
            Output.Write($"Perimeter of rectangle = {rectangle.Perimeter(width, height)}");
            Output.Write("----------------------------");
        }
    }
}
