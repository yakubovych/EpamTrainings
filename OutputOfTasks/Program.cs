namespace OutputOfTasks
{
    using System;
    using LibraryOfProject;

    class Program
    {
        private static bool isCheckedHomework;

        static void Main(string[] args)
        {
            var runnerStructures = new HomeworkStructures.OutputTasks(new Output());
            var runnerEnums = new HomeworkEnums.OutputTasks(new Output());
            var runnnerExceptions = new HomeworkExceptions.OutputTasks(new Output());
            var runnerIoStreams = new HomeworkIoStreams.OutputTasks(new Output());

            while (!isCheckedHomework)
            {
                Console.WriteLine("-----Offline part tasks-----");
                Console.WriteLine(
                    "Select homework: \n" +
                    "(1) Check tasks with Structures;\n" +
                    "(2) Check tasks with Enums;\n" +
                    "(3) Check tasks with Exceptions;\n" +
                    "(4) Check tasks with IOStreams;\n" +
                    "(0)  Exit.\n");
                Console.WriteLine("What action do you choose?");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        runnerStructures.RunTasks();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        runnerEnums.RunTasks();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        runnnerExceptions.RunTasks();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        runnerIoStreams.RunTasks();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        isCheckedHomework = true;
                        break;
                    default:
                        Console.WriteLine("Input error!");
                        break;
                }
            }
        }
    }
}
