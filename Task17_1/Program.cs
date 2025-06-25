using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Task17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ЗАПУСК ПРОГРАММЫ");

                CreateRandomArrayAsync(2, 6, 1, 9, 2);

                Console.WriteLine("Запуск задачи продолжения");
                Task<int[]> task1 = Task.Run(() => CreateRandomArray(2, 6, 1, 9, 1));
                Task<double> task2 = task1.ContinueWith(t =>
                {
                    int[] a = t.Result;
                    return ArithmeticMeanOfArray(a, 1);
                });
                Console.WriteLine("Среднее арифметическое массива 1 = " + task2.Result);
                Console.WriteLine("Завершение задачи продолжения");

                Console.WriteLine("ЗАВЕРШЕНИЕ ПРОГРАММЫ");
                Console.ReadKey();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Создает массив с указанными характеристиками
        /// </summary>
        /// <param name="minSize">Минимально возможный размер массива</param>
        /// <param name="maxSize">Максимально возможный размер массива</param>
        /// <param name="minValue">Минимальное значение числа в массиве</param>
        /// <param name="maxValue">Максимальное значение числа в массиве</param>
        /// <param name="arrayNumber">Номер массива</param>
        /// <returns></returns>
        static int[] CreateRandomArray(uint minSize, uint maxSize, int minValue, int maxValue, int arrayNumber)
        {
            Random random = new Random();

            int arraySize = random.Next((int)minSize, (int)maxSize);

            int[] resultArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                resultArray[i] = random.Next(minValue, maxValue);
                Console.WriteLine($"В массив {arrayNumber} добавлено число: " + resultArray[i]);
                Thread.Sleep(1000);
            }
            return resultArray;
        }

        /// <summary>
        /// Находит среднее арифметическое всех чисел в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="arrayNumber">Номер массива</param>
        /// <returns></returns>
        static double ArithmeticMeanOfArray(int[] array, int arrayNumber)
        {
            double result = 0;

            foreach (var number in array)
            {
                result += number;
                Thread.Sleep(1000);
                Console.WriteLine("Суммирование в массиве " + arrayNumber);
            }

            Console.WriteLine("Расчет среднего арифметического в массиве " + arrayNumber);
            Thread.Sleep(1200);
            result /= array.Length;

            return result;
        }


        /// <summary>
        /// Создает массив с указанными характеристиками и считает среднее арифметическое
        /// </summary>
        /// <param name="minSize">Минимально возможный размер массива</param>
        /// <param name="maxSize">Максимально возможный размер массива</param>
        /// <param name="minValue">Минимальное значение числа в массиве</param>
        /// <param name="maxValue">Максимальное значение числа в массиве</param>
        /// <param name="arrayNumber">Номер массива</param>
        /// <returns></returns>
        static async Task CreateRandomArrayAsync(uint minSize, uint maxSize, int minValue, int maxValue, int arrayNumber)
        {
            Console.WriteLine("Запуск асинхронного метода");

            int[] a = await Task<int[]>.Run(() => CreateRandomArray(minSize, maxSize, minValue, maxValue, arrayNumber));
            double b = await Task<double>.Run(() => ArithmeticMeanOfArray(a, arrayNumber));

            Console.WriteLine($"Среднее арифметическое массива {arrayNumber} = " + b);

            Console.WriteLine("Завершение асинхронного метода");
        }
    }
}
