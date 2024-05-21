using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2005
{
    internal class Combination
    {
        Dictionary<string, List<Book>> books;

        public Combination()
        {
            books = new Dictionary<string, List<Book>>();
        }

        public void Add(string genre, Book book)
        {
            if (!books.ContainsKey(genre))
            {
                books.Add(genre, new List<Book>());
            }
            books[genre].Add(book);
        }

        public void Print()
        {
            foreach (var genre in books)
            {
                Console.WriteLine(genre.Key);

                foreach (var book in genre.Value)
                {
                    Console.WriteLine(book.title);
                }
            }
            Console.WriteLine("****************************************");
        }

        // Remove a book by title from a specified genre
        public void Remove(string genre, string title)
        {
            if (books.ContainsKey(genre))
            {
                books[genre].Remove(books[genre].Find(b => b.title == title));
            }
        }

        // List all books in a specified genre.
        public void List(string genre)
        {
            if (books.ContainsKey(genre))
            {
                foreach (var book in books[genre])
                {
                    Console.WriteLine(book.title);
                }
            }
            Console.WriteLine("****************************************");
        }

        // List all books in the library, grouped by genre
        public void ListAll()
        {
            foreach (var genre in books)
            {
                Console.WriteLine(genre.Key);

                foreach (var book in genre.Value)
                {
                    Console.WriteLine(book.title);
                }
            }
            Console.WriteLine("****************************************");
        }   

    }
}
