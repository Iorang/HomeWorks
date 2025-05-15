using System.Runtime.CompilerServices;

namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double triangleSide1;
            double triangleSide2;
            double triangleSide3;

            double triangleSide4;
            double triangleSide5;
            double triangleSide6;


            Console.WriteLine("Треугольник 1:");

            Console.Write("Сторона A = ");
            triangleSide1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона B = ");
            triangleSide2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона C = ");
            triangleSide3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Треугольник 2:");

            Console.Write("Сторона A = ");
            triangleSide4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона B = ");
            triangleSide5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона C = ");
            triangleSide6 = Convert.ToDouble(Console.ReadLine());

            double triangleSquare1;
            double triangleSquare2;

            triangleSquare1 = Square(triangleSide1, triangleSide2, triangleSide3);
            Console.WriteLine("Площадь треугольника 1 = " + triangleSquare1.ToString());

            triangleSquare2 = Square(triangleSide4, triangleSide5, triangleSide6);
            Console.WriteLine("Площадь треугольника 2 = " + triangleSquare2.ToString());

            Console.WriteLine();

            if (triangleSquare1 > triangleSquare2)
            {
                Console.WriteLine("Площадь треугольника 1 больше чем треугольника 2");
            }
            else
            {
                Console.WriteLine("Площадь треугольника 2 больше чем треугольника 1");
            }
        }

        private static double Square(double a, double b, double c)
        {
            double p;
            double s;

            p = (a + b + c)/2;

            s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

            return s;
        }
    }
}
