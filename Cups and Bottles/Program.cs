using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bottlesFilled = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int wasted = 0;
            Queue<int> cups = new Queue<int>(cupsCapacity);
            Stack<int> bottles = new Stack<int>(bottlesFilled);
            while(cups.Count>0 && bottles.Count>0)
            {
                int currCup = cups.Peek();
                int currBottle = bottles.Peek();
                if(currCup <= currBottle)
                {
                    cups.Dequeue();
                    wasted += currBottle - currCup;
                    bottles.Pop();
                }
                else
                {
                    currCup -= currBottle;
                    bottles.Pop();
                    cups.Dequeue();
                    cups.Enqueue(currCup);
                }
            }
            if(bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wasted}");
        }
    }
}
