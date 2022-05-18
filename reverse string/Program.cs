using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();
            foreach (var item in nums)
            {
                numbers.Push(item);
            }
            string command = string.Empty;
            while((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] splitteed = command.Split(' ');
                if(splitteed[0].ToLower() == "add")
                {
                    int first = int.Parse(splitteed[1]);
                    int second = int.Parse(splitteed[2]);
                    numbers.Push(first);
                    numbers.Push(second);
                }
                else if (splitteed[0].ToLower() == "remove" && int.Parse(splitteed[1]) <= numbers.Count)
                {
                    for (int i = 0; i < int.Parse(splitteed[1]); i++)
                    {
                        numbers.Pop();
                    }
                }

            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
