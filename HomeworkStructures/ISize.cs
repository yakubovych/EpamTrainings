namespace HomeworkStructures
{
    public interface ISize
    {
        double Width { get; set; }

        double Height { get; set; }

        double Perimeter(double width, double height);
    }
}
