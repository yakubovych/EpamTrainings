namespace HomeworkIoStreams
{
    using System;
    using System.IO;
    using LibraryOfProject.Interfaces;

    class DirectoriesVisualizer : IOperation
    {
        private string nameOfDirectory;

        public DirectoriesVisualizer(string NameOfDirectory)
        {
            this.nameOfDirectory = NameOfDirectory;
        }

        public void GetVisualize()
        {
            var direcotories = Directory.EnumerateDirectories(nameOfDirectory, "*", SearchOption.AllDirectories);
            foreach (var item in direcotories)
            {
                Console.WriteLine(item);
            }
        }
    }
}
