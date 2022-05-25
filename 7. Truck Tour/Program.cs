using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Truck_Tour
{
    class pump
    {
        public pump(int amountOfPetrol, int distance, int i)
        {
            AmountofPetrol = amountOfPetrol;
            Distance = distance;
            Number = i;
        }

        public int AmountofPetrol { get; set; }
        public int Distance { get; set; }
        public int Number { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<pump> pumps = new Queue<pump>();
        
            for (int i = 0; i < numberOfPumps; i++)
            {
              
                int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                int amountOfPetrol = input[0];
                int distance = input[1];
                pump pumP = new pump(amountOfPetrol,distance,i);

                pumps.Enqueue(pumP);
              

                
                
            }

            int startIndex = 0;
            while (true)
            {
                bool isValidPump = true;

                int totalLitters = 0;
                foreach (var item in pumps)
                {

                    int litters = item.AmountofPetrol;
                    totalLitters += litters;
                    int distance = item.Distance;
                    if (totalLitters - distance < 0)
                    {
                        startIndex += 1;
                        pump currentPum = pumps.Dequeue();
                        pumps.Enqueue(currentPum);
                        isValidPump = false;
                        break;
                    }
                    totalLitters -= distance;
                }
                if (isValidPump)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
            }
    }
}
