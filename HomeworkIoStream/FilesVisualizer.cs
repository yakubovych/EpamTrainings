namespace HomeworkIoStreams
{
    using System;
    using System.IO;
    using LibraryOfProject.Interfaces;

    class FilesVisualizer : IOperation
    {
        private string nameOfDirectory;

        public FilesVisualizer(string NameOfDirectory)
        {
            this.nameOfDirectory = NameOfDirectory;
        }

        public void GetVisualize()
        {
            var files = Directory.EnumerateFiles(nameOfDirectory, "*", SearchOption.AllDirectories);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }
    }
}
