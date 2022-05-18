﻿using System;
using System.Collections.Generic;

namespace traffic_jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            string input = string.Empty;
            int count = 0;
            while((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if(cars.Count<1)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

            }
            Console.WriteLine($"{count} cars passed the crossroads.");
           
        }
    }
}
