namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            while (true)
            {
                Console.WriteLine("Введите строку:");

                sentence = Console.ReadLine();

                string[] splitSentence = sentence.Split(' ');

                string longestWord = string.Empty;

                foreach (string word in splitSentence)
                {
                    if (longestWord.Length < word.Length)
                        longestWord = word;
                }
                Console.WriteLine("Первое самое длинное слово в строке: " + longestWord);
                Console.WriteLine();
            }
        }
    }
}
