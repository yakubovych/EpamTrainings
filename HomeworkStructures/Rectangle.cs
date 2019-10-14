namespace HomeworkStructures
{
    public struct Rectangle : ISize, ICoordinates
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Perimeter(double width, double height)
        {
            return 2 * (width + height);
        }
    }
}
