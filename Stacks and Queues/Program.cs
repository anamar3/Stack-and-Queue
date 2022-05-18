using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues
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
            Stack<int> elements = new Stack<int>();
            int[] elementsInput = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            for (int i = 0; i < numberOfElToPush; i++)
            {
                elements.Push(elementsInput[i]);
            }
            for (int i = 0; i < elementsToPopOut; i++)
            {
                elements.Pop();
            }
            if(elements.Contains(toLookFor))
            {
                Console.WriteLine("true");
            }
            else if(elements.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int smallest = int.MaxValue;
                foreach (var item in elements)
                {
                    if(item < smallest)
                    {
                        smallest = item;
                    }
                }
                Console.WriteLine(smallest);
            }
            

        }
    }
}
