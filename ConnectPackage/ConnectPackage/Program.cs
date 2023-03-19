using System;
using System.Collections;
using PowerCollections;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 1; i < Capacity; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("Стек содержит:");

            foreach (int num in stack)
            {
                Console.WriteLine(num);
            }

            Stack stack2 = new Stack();
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int number = random.Next(0, 101);
                stack2.Push(number);
            }

            Console.WriteLine("Стек содержит:");
            foreach (var item in stack2)
            {
                Console.WriteLine(item);
            }
        }
    }
}

