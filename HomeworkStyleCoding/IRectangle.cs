namespace HomeworkStyleCoding
{
    public interface IRectangle
    {
        void Move(int l, int h, ref int x, ref int y);

        void Union(int x1, int x2, int y1, int y2, int width1, int width2, int height1, int height2);

        void Change(int x, int y, ref int width, ref int height);
    }
}
