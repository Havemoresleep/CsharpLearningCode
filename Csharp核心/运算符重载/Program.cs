namespace 运算符重载
{
    class Point 
    { 
        public int X; public int Y;

        public static Point operator +(Point p1, Point p2) 
        { 
            Point p = new Point();
            p.X = p1.X + p2.X;
            p.Y = p1.Y + p2.Y;
            return p;
        }

        public static Point operator +(Point p1, int value)
        {
            Point p = new Point();
            p.X = p1.X + value;
            p.Y = p1.Y + value;
            return p;
        }

        public static Point operator +(int value, Point p1)
        {
            Point p = new Point();
            p.X = p1.X + value;
            p.Y = p1.Y + value;
            return p;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符重载");

            Point p = new Point();
            p.X = 1;
            p.Y = 1;
            Point p2 = new Point();
            p2.X = 2;
            p2.Y = 2;

            Point p3 = p + p2;

            Point p4 = p3 + 2;

            Point p5 = 2 + p3;
        }
    }
}
