namespace HomeworkSolid
{
    public interface ICalculator
    {
        void CalculateToConsole(int x, int y);

        void CalculateToFile(int x, int y);

        void ReadFromFile();
    }
}