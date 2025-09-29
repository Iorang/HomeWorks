namespace Task12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int>("F-986","Война и мир", "Лев Николаевич Толстой", 1869),
                new Book<string, int>("F-1015","Десять книг об архитектуре", "Марк Витрувий Поллион",-16),
                new Book<string, int>("F-1234","Тихий Дон", "Михаил Александрович Шолохов",1940)
            };

            Book<int, string>[] books2 = new Book<int, string>[]
            {
                new Book<int, string>(12,"Война и мир", "Лев Николаевич Толстой","XIX век"),
                new Book<int, string>(42,"Десять книг об архитектуре", "Марк Витрувий Поллион","I век до н.э."),
                new Book<int, string>(69,"Тихий Дон", "Михаил Александрович Шолохов","XX век ")
            };

            Book<string, int> book1 = FindBook<string, int>(books1, "F-1234");
            Book<int, string> book2 = FindBook<int, string>(books2, 42);


            Console.WriteLine(book1?.ToString() ?? "Код книги не найден");
            Console.WriteLine();

            Console.WriteLine(book2?.ToString() ?? "Код книги не найден");
            Console.WriteLine();


            Console.ReadKey();
        }

        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T bookCode)
        {
            foreach (var book in books)
            {
                if (book.Code.Equals(bookCode))
                    return book;
            }
            return null;
        }
    }
}
