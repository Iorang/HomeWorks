namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            while (true)
            {
                Console.WriteLine("Введите возраст: ");
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    ValidateAge(age);
                    Console.WriteLine("Возраст указан верно\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите целое число");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }
        private static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");
            if (age > 150)
                throw new ArgumentOutOfRangeException("age","Слишком большой возраст");
        }
    }
}
