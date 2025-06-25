namespace Task15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> subscribers = new HashSet<string>();

            subscribers.Add("alice@example.com");
            subscribers.Add("bob@example.com");
            subscribers.Add("charlie@example.com");

            Console.WriteLine("Дубликат alice@example.com добавлен? " + subscribers.Add("alice@example.com"));

            Console.WriteLine("Есть ли bob@example.com в подписчиках? " + subscribers.Contains("bob@example.com"));

            Console.WriteLine("Есть ли dave@example.com в подписчиках? " + subscribers.Contains("dave@example.com"));

            HashSet<string> newSubscribers = new HashSet<string>() { "bob@example.com", "dave@example.com", "eve@example.com" };

            string[] subscribersArray = new string[3];

            subscribers.CopyTo(subscribersArray);

            subscribers.UnionWith(newSubscribers);

            Console.WriteLine("Подписчики после объединения: ");
            foreach (var subscriber in subscribers)
            {
                Console.WriteLine("- " + subscriber);
            }

            newSubscribers.IntersectWith(subscribersArray);
            
            Console.WriteLine("Общие подписчики: ");
            foreach (var subscriber in newSubscribers)
            {
                Console.WriteLine("- " + subscriber);
            }

            Console.WriteLine("Удалили charlie@example.com? " + subscribers.Remove("alice@example.com"));

            Console.WriteLine("Всего подписчиков: " + subscribers.Count);

            HashSet<string> testGroup = new HashSet<string>() { "bob@example.com", "dave@example.com", "eve@example.com" };

            Console.WriteLine("testGroup является подмножеством? " + subscribers.IsSupersetOf(testGroup));

            subscribers.Clear();

            Console.WriteLine("Подписчиков после очистки: " + subscribers.Count);

            Console.ReadKey();







        }
    }
}
