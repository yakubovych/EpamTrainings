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

                DirectoriesVisualizer directories = new DirectoriesVisualizer(@"D:\STEAM\steamapps\common\Stalker Call of Pripyat");
                directories.GetVisualize();

                FilesVisualizer files = new FilesVisualizer(@"D:\STEAM\steamapps\common\Stalker Call of Pripyat");
                files.GetVisualize();

                Output.Write("----------------------------");

                Output.Write("\n--- Task1 ---");

                FindNotAFullNameFile fullName = new FindNotAFullNameFile("D:\\");
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
