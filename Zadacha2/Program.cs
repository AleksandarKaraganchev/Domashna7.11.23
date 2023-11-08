using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> originalQueue = new Queue<int>();
        originalQueue.Enqueue(1);
        originalQueue.Enqueue(2);
        originalQueue.Enqueue(3);
        Queue<int> copiedQueue = CopyQueue(originalQueue);
        Console.WriteLine("Original Queue: ");
        PrintQueue(originalQueue);
        Console.WriteLine("Copied Queue: ");
        PrintQueue(copiedQueue);
    }
    static Queue<T> CopyQueue<T>(Queue<T> original)
    {
        Queue<T> copiedQueue = new Queue<T>(original);
        return copiedQueue;
    }
    static void PrintQueue<T>(Queue<T> queue)
    {
        foreach (var item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}