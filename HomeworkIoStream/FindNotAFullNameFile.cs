﻿namespace HomeworkIoStreams
{
    using System;
    using System.IO;
    using LibraryOfProject.Interfaces;

    class FindNotAFullNameFile : IOperation
    {
        private string partialName = "ep";
        private string nameOfDirectory;

        public FindNotAFullNameFile(string NameOfDirectory)
        {
            this.nameOfDirectory = NameOfDirectory;
        }

        public void GetVisualize()
        {
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(nameOfDirectory);
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");
            foreach (FileInfo foundFile in filesInDir)
            {
                string fullName = foundFile.FullName;
                Console.WriteLine(fullName);
            }
        }
    }
}