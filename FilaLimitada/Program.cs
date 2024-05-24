using System;

namespace FilaLimitada
{
    class Program
    {
        static void Main(string[] args)
        {
            LimitedQueue<int> queue = new LimitedQueue<int>(5);
            
            for (int i = 1; i <= 7; i++)
            {
                queue.Add(i);
                Console.WriteLine($"Added {i}: Count = {queue.Count}");
            }

            Console.WriteLine("Queue contents:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Contains 3: {queue.Contains(3)}");
            Console.WriteLine($"Contains 1: {queue.Contains(1)}");

            queue.Remove(3);
            Console.WriteLine("After removing 3:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Clear();
            Console.WriteLine($"Queue cleared: Count = {queue.Count}");
        }
    }
}

