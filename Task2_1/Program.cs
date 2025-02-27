namespace HW_2.Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            byte b = 2;
            byte c = 3;
            byte storage;

            //Значения переменных до обмена 
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            //Обмен значениями c использованием переменной хранилища
            storage = a;
            a = c;
            c = b;
            b = storage;

            //Значения переменных после обмена 
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            Console.ReadLine();
        }
    }
}
