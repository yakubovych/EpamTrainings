namespace HomeworkEnums
{
    using System;

    public static class ColorsExtension
    {
        public static void SortedColors()
        {
            foreach (var i in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{i} = {(int)i}");
            }
        }
    }
}
