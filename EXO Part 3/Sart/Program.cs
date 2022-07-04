using System;

namespace EXO
{
    class Program
    {
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        }

        static void Main()
        {
            IPoint p = new Point(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);
        }

    }
    interface IPoint
    {
        // Property signatures:
        int X
        {
            get;
            private set;
        }

        int Y
        {
            get;
           private set;
        }

        double Distance
        {
            get;
        }
    }

    class Point : IPoint
    {
        // Constructor:
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Property implementation:
        public int X { get; private set; }

        public int Y { get; private set; }

        // Property implementation
        public double Distance => Math.Sqrt(X * X + Y * Y);

    }
}

// Erreur / change
// RESULT : My Point: x=2, y=3