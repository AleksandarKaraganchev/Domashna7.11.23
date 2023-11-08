using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine("Original Queue: ");
        PrintedQueue(queue);
        ReversedQueue(queue);
        Console.WriteLine("Reversed Queue: ");
        PrintedQueue(queue);
    }
    static void ReversedQueue<T>(Queue<T> queue)
    {
        Stack<T> stack = new Stack<T>();
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }
    }

    static void PrintedQueue<T>(Queue<T> queue)
    {
        foreach (var item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}