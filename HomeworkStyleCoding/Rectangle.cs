namespace HomeworkStyleCoding
{
    using System;

    public class Rectangle
    {
        private int x;
        private int y;
        private int width;
        private int height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void Move(int l, int h, ref int x, ref int y)
        {
            x -= l;
            y -= h;
            Console.WriteLine("x = {0}, y = {1}, width = {2}, height = {3}", x, y, width, height);
        }

        public void Union(int x1, int x2, int y1, int y2, int width1, int width2, int height1, int height2)
        {

            if (x1 > x2)
            {
                int bubble = x1;
                x1 = x2;
                x2 = bubble;
            }

            if (x1 + width1 < x2 + width2)
            {
                x = x1;
                width = x2 - x1 + width2;
            }
            else
            {
                x = x1;
                width = width2;
            }

            if (y1 > y2)
            {
                int bubble = y1;
                y1 = y2;
                y2 = bubble;
            }

            if (y1 + height1 < y2 + height2)
            {
                y = y1;
                height = y2 - y1 + height2;
            }
            else
            {
                y = y1;
                height = height2;
            }

            Console.WriteLine("x = {0}, y = {1}, width = {2}, height = {3}", x, y, width, height);
        }

        public void Change(int x, int y, ref int width, ref int height)
        {
            width -= x;
            height -= y;
            Console.WriteLine("x = {0}, y = {1}, width = {2}, height = {3}", x, y, width, height);
        }
    }
}