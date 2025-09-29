namespace Task15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> playerList = new List<string>();

            playerList.Add("Иванов"); 
            playerList.Add("Петров");
            playerList.Add("Сидоров");

            playerList.Insert(1, "Козлов");

            Console.WriteLine("Есть ли игрок Петров в команде? " + playerList.Contains("Петров"));

            playerList.Remove("Сидоров");

            Console.WriteLine("Индекс игрока 'Козлов': " + playerList.IndexOf("Козлов"));

            playerList.Sort();

            Console.WriteLine("Текущий cостав команды:");
            for (int i = 0; i < playerList.Count; i++)
            {
                Console.WriteLine((i+1) + ". " + playerList[i]);
            }

            Console.WriteLine("Команда пуста? " + (playerList.Count <= 0));

            playerList.Clear();

            Console.WriteLine("Количество игроков после очистки: " + playerList.Count );

            Console.ReadKey();
        }
    }
}
