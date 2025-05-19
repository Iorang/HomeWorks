namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double edgeLength;
            Console.Write("Введите длину строны куба: ");
            edgeLength = Convert.ToDouble(Console.ReadLine());

            CalcCube(edgeLength, out double volume, out double surfaceArea);
            Console.WriteLine($"Объем куба: {volume}"); 
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}"); 
            Console.ReadLine();
        }
        private static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            volume = edgeLength * edgeLength * edgeLength;
            surfaceArea = (edgeLength* edgeLength) * 6;
        }
    }
}
