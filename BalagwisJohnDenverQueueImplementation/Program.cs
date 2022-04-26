//JOhn Denver Balagwis
//BSI/T- 2F

using System;
using System.Collections.Generic;

namespace BalagwisJohnDenverQueueImplementation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Queue<string> Queue = new Queue<string>();

            Console.WriteLine("Cars waiting in line at a car wash\n");

            Queue.Enqueue("Toyota Vios");
            Queue.Enqueue("Toyota Inova");
            Queue.Enqueue("Honda Civic");
            Queue.Enqueue("Mitsubishi Mirage");
            Queue.Enqueue("Izuzu D- Max");

            Console.WriteLine("Number of cars in queue: {0}.\n", Queue.Count);
            int position = 1;
            foreach (string car in Queue)
            {
                Console.WriteLine("# {0} {1}\n", position++, car);
            }
            while (Queue.Count > 0)
            {
                Console.WriteLine("{0} left the Car wash.", Queue.Dequeue());
            }

            Console.WriteLine("\nNumber of cars left in queue: {0}.", Queue.Count);
            Console.ReadLine();
        }
    }
}