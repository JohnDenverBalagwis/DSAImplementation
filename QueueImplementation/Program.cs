using System;
using System.Collections;

namespace QueueImplementation
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            Console.Write("Original queue: ");
            foreach (int number in myQueue)
            {
                Console.Write(number + " ");
            }
            myQueue.Dequeue();
            myQueue.Dequeue();
            Console.WriteLine();
            Console.Write("\nQueue after Dequeue operation: ");
            foreach (int number in myQueue)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}