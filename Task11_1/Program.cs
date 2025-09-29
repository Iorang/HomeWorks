namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = [new Cat(), new Dog()];

            foreach (var animal in animals)
            {
                animal.ShowInfo();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
