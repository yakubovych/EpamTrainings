namespace HomeworkIoStreams
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
            try
            {
                Output.Write("\n--- Task1 ---");

                Output.Write("Enter path to directory: ");
                string path = Output.Read();
                DirectoriesVisualizer directories = new DirectoriesVisualizer($@"{path}");
                directories.GetVisualize();

                FilesVisualizer files = new FilesVisualizer($@"{path}");
                files.GetVisualize();

                Output.Write("----------------------------");

                Output.Write("\n--- Task2 ---");

                Output.Write("Enter partial name of file: ");
                string partialName = Output.Read();
                FindNotAFullNameFile fullName = new FindNotAFullNameFile($@"{path}", partialName);
                fullName.GetVisualize();

                Output.Write("----------------------------");
            }
            catch (Exception e)
            {
                Output.Write(e.Message);
            }
        }
    }
}
