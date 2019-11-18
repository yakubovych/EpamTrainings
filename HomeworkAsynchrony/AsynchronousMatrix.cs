namespace HomeworkAsynchrony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    class AsynchronousMatrix
    {
        private Random random = new Random();
        private int[,] array;
        public int Rows = 1000;
        public int Columns = 1000;
        private int ThreadsToDivide = 3;

        public AsynchronousMatrix()
        {
            array = new int[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }
        }

        public void ReceiveParallelSumOfElementsOfArray()
        {
            int columnInOneThread = Columns / ThreadsToDivide;
            Task[] tasks = new Task[ThreadsToDivide];
            List<int> sumOfElements = new List<int>();
            for (int k = 0; k < ThreadsToDivide; k++)
            {
                int x = k;
                tasks[x] = new Task(() =>
                {
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = x * columnInOneThread; j < columnInOneThread * (x + 1); j++)
                        {
                            sumOfElements.Add(array[i, j]);
                        }
                    }
                });
            }

            foreach (var item in tasks)
            {
                item.Start();
            }

            Task.WaitAll(tasks);
            Console.WriteLine($"Sum of elements of array = {sumOfElements.Sum()}.");
        }
    }
}
