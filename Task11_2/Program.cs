namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyableObjects = { new Bird(5000), new Airplane(12000, 180) };

            foreach (var flyableObject in flyableObjects)
            {
                flyableObject.Fly();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
