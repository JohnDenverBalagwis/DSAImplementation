using System;

namespace DataStructureandAlgorithm
{
    public class Stack
    {
        private int top;
        private int maxSize = 10;
        private int[] myArray = new int[10];

        public static void Main()
        {
            Stack myStack = new Stack()
            {
                top = -1
            };
            int choice = 0;
            Console.WriteLine("\n==============================================");
            Console.WriteLine("\tStack Implementation          ");
            Console.WriteLine("==============================================\n");
            while (choice != 4)
            {
                Console.WriteLine("\nChoose one from the below options.\n");
                Console.WriteLine("\n1.Push");
                Console.WriteLine("\n2.Pop");
                Console.WriteLine("\n3.Show");
                Console.WriteLine("\n4.Exit");
                Console.Write("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            myStack.Push();
                            break;
                        }
                    case 2:
                        {
                            myStack.Pop();
                            break;
                        }
                    case 3:
                        {
                            myStack.Show();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nExiting....");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nPlease Enter a valid choice. ");
                            break;
                        }
                }
            }
        }

        private bool Push()
        {
            int value;
            if (top == maxSize - 1)
            {
                Console.WriteLine("\nOverflow.");
                return false;
            }
            else
            {
                Console.Write("\nEnter the value: ");
                value = Convert.ToInt32(Console.ReadLine());
                top = top + 1;
                myArray[top] = value;
                Console.WriteLine("\nItem pushed successfully.");
                return true;
            }
        }

        private bool Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("\nUnderflow.");
                return false;
            }
            else
            {
                top = top - 1;
                Console.WriteLine("\nItem popped.");
                return true;
            }
        }

        private void Show()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine("\n" + myArray[i]);
            }
            if (top == -1)
            {
                Console.WriteLine("\nStack is empty.");
            }
        }
    }
}