using System;

namespace EuclidianCS
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, z1, z2;
            x1 = 12d;
            x2 = 13d;
            y1 = 11d;
            y2 = 10d;
            z1 = 14d;
            z2 = 15d;
            var distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            var distance3D = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
            Console.WriteLine(distance);
            Console.WriteLine(distance3D);
        }
    }
}
