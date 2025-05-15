namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Война и мир", "Л. Толстой", 1869, 1225);
            book.GetInfo();
            Console.ReadLine();
        }
    }
}
