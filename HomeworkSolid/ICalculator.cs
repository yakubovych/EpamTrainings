namespace HomeworkSolid
{
    public interface ICalculator
    {
        void CalculateToConsole(int x, int y, char operation);

        void CalculateToFile(int x, int y, char operation);

        void ReadFromFile();
    }
}