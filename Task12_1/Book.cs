using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_1
{
    public class Book<T,U>
    {
        public T Code { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public U PublicationYear { get; set; }


        public Book(T code, string title, string author, U publicationYear)
        {
            Code = code;
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }

        public override string ToString()
        {
            return $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
        }

       
    }
}
