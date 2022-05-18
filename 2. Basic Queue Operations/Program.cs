using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numberOfElToPush = input[0];
            int elementsToPopOut = input[1];
            int toLookFor = input[2];
            Queue<int> queue = new Queue<int>();
            int[] elementsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            for (int i = 0; i < numberOfElToPush; i++)
            {
                queue.Enqueue(elementsInput[i]);
            }
            for (int i = 0; i < elementsToPopOut; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(toLookFor))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int smallest = int.MaxValue;
                foreach (var item in queue)
                {
                    if (item < smallest)
                    {
                        smallest = item;
                    }
                }
                Console.WriteLine(smallest);
            
            }
     
        }
    }
}
