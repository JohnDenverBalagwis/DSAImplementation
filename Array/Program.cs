using System;

namespace Array
{
    internal static class Program
    {
        private static string[] heroList = { "Layla", "Nana", "Karina", "Khufra", "Lunox", "Harley", "Gusion" };

        private static void Main(string[] args)
        {
            ArrayImplentation();
            Console.ReadLine();
        }

        private static void ArrayImplentation()
        {
            Console.WriteLine("Your turn to pick! Please pick a hero:\n");
            for (int i = 0; i < heroList.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {heroList[i]}");
            }
            Console.Write("\nYour Pick: ");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '1':
                    Console.WriteLine("\nYou have chosen " + heroList[0]);
                    break;

                case '2':
                    Console.WriteLine("\nYou have chosen " + heroList[1]);
                    break;

                case '3':
                    Console.WriteLine("\nYou have chosen " + heroList[2]);
                    break;

                case '4':
                    Console.WriteLine("\nYou have chosen " + heroList[3]);
                    break;

                case '5':
                    Console.WriteLine("\nYou have chosen " + heroList[4]);
                    break;

                case '6':
                    Console.WriteLine("\nYou have chosen " + heroList[5]);
                    break;

                case '7':
                    Console.WriteLine("\nYou have chosen " + heroList[6]);
                    break;

                default:
                    Console.Write("\nThere is no such thing in the hero pool.");
                    break;
            }
            Console.WriteLine("\nWelcome to Mobile Legends!! 5 seconds till the enemy reaches the battlefield!!");
            Console.WriteLine("\nAll troops deployed!! Smash them!!");
        }
    }
}