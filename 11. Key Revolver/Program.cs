using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfEachBullet = int.Parse(Console.ReadLine());
            int theSizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            int count = 0;
            Stack<int> bullets = new Stack<int>(arr);
            Queue<int> locks = new Queue<int>(arr2);
            int currentShoots = theSizeOfGunBarrel;
            while (bullets.Count > 0 && locks.Count > 0)
            {
                currentShoots--;
               
                
                if (bullets.Peek() <= locks.Peek())
                {
                        Console.WriteLine("Bang!");
                        bullets.Pop();
                        locks.Dequeue();
                       
                }
                else
                    {
                        Console.WriteLine("Ping!");
                        bullets.Pop();

                       
                    }
                    count++;
                
                if (bullets.Count > 0 && currentShoots ==0)
                {
                    Console.WriteLine("Reloading!");
                    currentShoots = theSizeOfGunBarrel;
                }

            }
            if(locks.Count>0 && bullets.Count<=0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else if( locks.Count <=0 )
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueOfIntelligence - count*priceOfEachBullet}");
            }
        }
    }
}
