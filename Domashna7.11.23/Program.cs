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
        queue.Enqueue(2);
        queue.Enqueue(4);
        int targetVal = 2;
        int ct = CountElementsWithSpecificVal(queue, targetVal);
        Console.WriteLine($"Number of elements with value --> {targetVal} : {ct}");
    }
    static int CountElementsWithSpecificVal(Queue<int> queue, int targetVal)
    {
        int ct = 0;
        foreach (var item in queue)
        {
            if (item == targetVal)
            {
                ct++;
            }
        }
        return ct;
    }
}