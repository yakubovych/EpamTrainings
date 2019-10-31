namespace HomeworkVariantTwoFolderComparer
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FolderComparer : IFolderComparer
    {
        private HashSet<string> unique = new HashSet<string>();

        private HashSet<string> duplicate = new HashSet<string>();

        public FolderComparer(string firstPathToCompare, string secondPathToCompare)
        {
            unique = GetUniqueFiles(firstPathToCompare, secondPathToCompare);
            duplicate = GetDuplicateFiles(firstPathToCompare, secondPathToCompare);
        }

        public ICollection<string> UniqueFiles()
        {
            return unique;
        }

        public ICollection<string> DuplicateFiles()
        {
            return duplicate;
        }

        public int NumberOfDuplicateFiles()
        {
            return duplicate.Count;
        }

        public HashSet<string> ReceiveAllFilesInSpecificFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new ArgumentException("Incorrect path to file!");
            }

            var directoryInfo = new DirectoryInfo(path);
            var filesInfo = directoryInfo.GetFiles();
            var files = new HashSet<string>();

            foreach (var item in filesInfo)
            {
                files.Add(Path.GetFileName(item.FullName));
            }

            return files;
        }

        public HashSet<string> GetUniqueFiles(string firstPathToCompare, string secondPathToCompare)
        {
            var uniqueFiles = ReceiveAllFilesInSpecificFolder(firstPathToCompare);
            uniqueFiles.UnionWith(ReceiveAllFilesInSpecificFolder(secondPathToCompare));
            uniqueFiles.ExceptWith(duplicate);
            return uniqueFiles;
        }

        public HashSet<string> GetDuplicateFiles(string firstPathToCompare, string secondPathToCompare)
        {
            var duplicateFiles = ReceiveAllFilesInSpecificFolder(firstPathToCompare);
            duplicateFiles.IntersectWith(ReceiveAllFilesInSpecificFolder(secondPathToCompare));
            return duplicateFiles;
        }
    }
}
