namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("Садовая", 15410, 2020);
            MultiBuilding multiBuilding1 = new MultiBuilding("Зеленая", 10410, 2021, 18, true);
            
           

            Console.WriteLine("Налог = " + building1.CalculateTax());
            building1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Налог = " + multiBuilding1.CalculateTax());
            Console.WriteLine("Средняя площадь на этаж = " + multiBuilding1.AreaPerFloor + " м2");
            multiBuilding1.DisplayInfo();
            Console.WriteLine();

            //Upcasting
            //После Upcasting классом Building вызываются переопределенные методы из класса MultiBuilding. Если подумать, это логично, т.к. объект должен продолжать работать как объект того класса в котором он создан. Но это немного вводит в заблуждение.
            Building building2 = multiBuilding1;
            building2.DisplayInfo();
            Console.WriteLine();

            //Downcasting
            MultiBuilding multiBuilding2 = building2 as MultiBuilding;
            multiBuilding2?.DisplayInfo();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}

