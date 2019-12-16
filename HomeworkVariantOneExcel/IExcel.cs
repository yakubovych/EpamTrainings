namespace HomeworkVariantOneExcel
{
    using System.Collections.Generic;

    public interface IExcel
    {
        void ReadExcel();

        // void WriteToExcel();

        HashSet<string> CompareColumnsAndGetUnique(int FirstColumn, int SecondColumn);
    }
}
