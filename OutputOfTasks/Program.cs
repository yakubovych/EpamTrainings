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
            var runnerSerialization = new HomeworkSerialization.OutputTasks(new Output());
            var runnerReflection = new HomeworkReflection.OutputTasks(new Output());
            var runnerStyleCoding = new HomeworkStyleCoding.OutputTasks(new Output());
            var runnerSolid = new HomeworkSolid.OutputTasks(new Output());
            var runnerVariantTwo = new HomeworkVariantTwoFolderComparer.OutputTasks(new Output());

            while (!isCheckedHomework)
            {
                Console.WriteLine("-----Offline part tasks-----");
                Console.WriteLine(
                    "Select homework: \n" +
                    "(1) Check tasks with Structures;\n" +
                    "(2) Check tasks with Enums;\n" +
                    "(3) Check tasks with Exceptions;\n" +
                    "(4) Check tasks with IOStreams;\n" +
                    "(5) Check tasks with Serialization;\n" +
                    "(6) Check tasks with Reflection;\n" +
                    "(7) Check tasks with StyleCoding;\n" +
                    "(8) Check tasks with Solid;\n" +
                    "(9) Check tasks with variant 2 - FolderComparer.\n" +
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
                    case "5":
                        runnerSerialization.RunTasks();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        runnerReflection.RunTasks();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "7":
                        runnerStyleCoding.RunTasks();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "8":
                        runnerSolid.RunTasks();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "9":
                        runnerVariantTwo.RunTasks();
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
