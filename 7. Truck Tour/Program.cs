using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<List<int>> truck = new Queue<List<int>>();
            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                int amountOfPetrol = input[0];
                int distance = input[1];
                List<int> temp = new List<int>();
                temp.Add(amountOfPetrol);
                temp.Add(distance);

                truck.Enqueue(temp);

                

            }
        }
    }
}
