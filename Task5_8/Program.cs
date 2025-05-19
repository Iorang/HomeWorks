namespace Task5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Объявление и инициализация переменных 
                const int n = 5;
                const int minrnd = 0;
                const int maxrnd = 10;

                int max1 = 0;
                int max2 = 0;

                int minseparator = 0;
                int maxseparator = 5;
                int counter = 0;

                Random rnd = new Random();
                int[] a = new int[n];

                //Заполнение массива
                for (int i = 0; i < n; i++)
                {
                    a[i] = rnd.Next(minrnd, maxrnd);
                }

                //Вывод массива в консоль
                foreach (var item in a)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();


                foreach (var item in a)
                {

                    //Перенос max1 в max2 и запись нового max1
                    if (item > max1)
                    {
                        max2 = max1;
                        max1 = item;
                    }
                    //поиск max2 если max1 оказалось первым в массиве и код при переборе больше не проваливается в первый блок
                    if (item < max1 && item > max2)
                    {
                        max2 = item;
                    }
                }

                //Вывод результата в консоль
                Console.WriteLine("max1 = " + max1);
                Console.WriteLine("max2 = " + max2);

                Console.ReadLine();
            }
        }
    }
}
