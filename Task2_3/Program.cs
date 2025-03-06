namespace HW_2.Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Объявление и инициализация переменных
            const double cmInInch = 2.54;

            double valueInInches;
            double valueInCm;

            int meter;
            int centimeter;
            int millimeter;
            #endregion

            #region Сбор данных
            Console.WriteLine("Введите значение в дюймах:");
            valueInInches = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Расчет
            valueInCm = valueInInches * cmInInch;

            meter = Convert.ToInt32((int)valueInCm / 100);
            centimeter = Convert.ToInt32(valueInCm % 100);
            millimeter = Convert.ToInt32((valueInCm*10) % 10);
            #endregion

            #region Вывод даннных
            Console.WriteLine("В метрической системе это:");
            Console.WriteLine("{0}м {1}см {2}мм", meter, centimeter, millimeter);
            Console.ReadLine();
            #endregion
        }
    }
}
