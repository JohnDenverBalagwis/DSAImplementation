using System;
using System.Collections.Generic;

namespace linkedListImplementation
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);
            numbers.AddFirst(2);
            numbers.AddFirst(3);
            numbers.AddLast(4);
            numbers.AddLast(5);
            numbers.AddLast(6);
            Console.Write("Original Linked List: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            numbers.RemoveFirst();
            numbers.RemoveLast();
            Console.WriteLine();
            Console.Write("\nLinked List after deletion: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}