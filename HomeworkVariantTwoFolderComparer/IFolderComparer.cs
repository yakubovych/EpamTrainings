namespace HomeworkVariantTwoFolderComparer
{
    using System.Collections.Generic;

    interface IFolderComparer
    {
        ICollection<string> UniqueFiles();

        ICollection<string> DuplicateFiles();

        int NumberOfDuplicateFiles();
    }
}
