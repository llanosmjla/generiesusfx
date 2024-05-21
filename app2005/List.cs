using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2005
{
    internal class ListDS
    {
        List<int> numbers;

        public ListDS()
        {
            numbers = new List<int>();
        }
        public void Add(int t)
        {
            numbers.Add(t);
        }

        public void Print()
        {
            foreach (var item in numbers)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("****************************************");

        }

        public void Remove(int t)
        {
            numbers.Remove(t);
        }

        public void RemoveFirst()
        {
            numbers.Remove(numbers.First());
        }
        public void RemoveLast()
        {
            numbers.Remove(numbers.Last());
        }
    }
}
