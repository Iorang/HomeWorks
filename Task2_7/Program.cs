using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("Введите число a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число b:");
            b = Convert.ToDouble(Console.ReadLine());

            //Значения переменных до обмена 
            Console.WriteLine("Значение переменных до обмена:");
            Console.WriteLine("a = {0}, b = {1}", a, b);

            //Обмен значениями c использованием переменной хранилища
            a = a + b;
            b = a - b;
            a = a - b;

            //Значения переменных после обмена 
            Console.WriteLine("Значение переменных после обмена:");
            Console.WriteLine("a = {0}, b = {1}", a, b);

            Console.ReadLine();

        }
    }
}
