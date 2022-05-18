using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            Queue<int> orders = new Queue<int>(input);
            Console.WriteLine(orders.Max());
            int count = orders.Count;
            for (int i = 0; i < count; i++)
           
            {
                int element = orders.Dequeue();
                if (quantityFood - element < 0)
                {
                    orders.Enqueue(element);
                    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
                    return;
                }
                else
                {


                    quantityFood -= element;
                    
                }
                
            }
            Console.WriteLine("Orders complete");



        }
    }
}
