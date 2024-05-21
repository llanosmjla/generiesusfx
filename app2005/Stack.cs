using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2005
{
    internal class Stack<T>
    {
        Stack<T> books;

        public Stack()
        {
            books = new Stack<T>();
        }

        public void Push(T book)
        {
            books.Push(book);
        }

        public void Pop()
        {
            books.Pop();
        }


        public void Print()
        {

            Console.WriteLine(books);
        }
    }
}
