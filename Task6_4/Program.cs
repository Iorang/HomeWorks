using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Введите данные:");
            Console.Write("Имя: ");
            sb.Append("Имя: " + Console.ReadLine() + ",");
            Console.Write("Возраст: ");
            sb.Append(" Возраст: " + Console.ReadLine() + ",");
            Console.Write("Город: ");
            sb.Append(" Город: " + Console.ReadLine());

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
