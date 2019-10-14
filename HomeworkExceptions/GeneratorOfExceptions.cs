namespace HomeworkExceptions
{
    using System;

    public class GeneratorOfExceptions
    {
        public static void GenerateStackOverflowException()
        {
            throw new StackOverflowException();
        }

        public static void GenerateIndexOutOfRangeException()
        {
            int[] array = { 10, 5, 6, 12 };
            Console.WriteLine(array[6]);
        }

        public static void DoSomeMath(int a, int b)
        {
            if (a < 0)
            {
                throw new ArgumentException("Parameter should be greater than 0", "a");
            }

            if (b > 0)
            {
                throw new ArgumentException("Parameter should be less than 0", "b");
            }
        }
    }
}
