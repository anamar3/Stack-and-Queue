using System;
using System.Collections;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string stuff = Console.ReadLine();
            int index = 0;
            Stack<int> stack = new Stack<int>();
            foreach (var item in stuff)
            {
                
                if (item == '(')
                {
                    stack.Push(index);
                }
                if(item ==')')
                {
                    int temp = stack.Pop();
                    for (int i = temp; i < index +1 ; i++)
                    {
                        Console.Write(stuff[i]);
                    }
                    Console.WriteLine();
                }
                index++;
            }
        }
    }
}
