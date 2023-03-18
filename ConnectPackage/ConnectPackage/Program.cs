using System;
using System.Collections;
using PowerCollections;

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
