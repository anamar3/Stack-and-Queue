using System;
using System.Collections.Generic;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] given = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songs = new Queue<string>(given);
            

            while(songs.Count!=0)
            {
                string commands = Console.ReadLine();
                string newSong = string.Empty;
                string command = string.Empty;
                if(commands.Contains("Add"))
                {
                    command = commands.Substring(0, 3);
                    newSong = commands.Substring(4);
                }
                if(commands == "Play")
                {
                    songs.Dequeue();
                }
                else if(commands == "Show")
                {
                    
                        Console.WriteLine($"{string.Join(", ",songs)}");
                   
                   
                }
                else if(command == "Add")
                {

                    
                    if(!songs.Contains(newSong))
                    {
                        songs.Enqueue(newSong);
                    }
                    else
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
