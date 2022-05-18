using System;
using System.Collections.Generic;

namespace hot_potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            int count = int.Parse(Console.ReadLine());
            Queue<string> people = new Queue<string>();
       
            string removed = string.Empty;
            for (int i = 0; i < names.Length; i++)
            {
                people.Enqueue(names[i]);

            }
            
            while (people.Count>1)
            {


                
                for (int i = 0; i < count-1; i++)
                {

                    string removedd = people.Dequeue();
                  
                    people.Enqueue(removedd);
                }
                Console.WriteLine($"Removed {people.Dequeue()}");
                
               
               
            }
            Console.WriteLine($"Last is {people.Dequeue()}");


        }
    }
}
