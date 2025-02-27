namespace HW_2.Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Объявление переменных
            int degree;
            int minute;
            int second;

            double decimalDegree;
            double radians;
            #endregion

            #region Сбор данных
            Console.WriteLine("Введите градусы");
            degree = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Введите минуты");
            minute = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Введите секунды");
            second = Convert.ToInt16(Console.ReadLine());
            #endregion

            #region Расчет
            decimalDegree = (degree + (minute + second / 60) / 60) % 360;

            radians = decimalDegree * (Math.PI / 180);
            #endregion

            #region Вывод даннных
            Console.WriteLine("Радианы: " + radians);
            Console.ReadLine();
            #endregion
        }
    }
}
