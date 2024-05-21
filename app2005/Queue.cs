using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2005
{
    internal class Queue
    {
        Queue<String> customers;

        public Queue()
        {
            customers = new Queue<String>();
        }

        public void Enqueue(String customer)
        {
            customers.Enqueue(customer);
        }

        public void Dequeue()
        {
            customers.Dequeue();
        }

        public void Print()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("****************************************");
        }


    }
}
