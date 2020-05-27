using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>();
            string[] incoming = Console.ReadLine().Split(", ");
            foreach (var element in incoming)
            {
                songs.Enqueue(element);
            }

            string song = Console.ReadLine();
            while (true)
            {
                if (song == "Play")
                {
                    songs.Dequeue();
                    if (songs.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        return;
                    }
                }
                else if (song == "Show")
                {
                    if(songs.Count !=0) Console.WriteLine(string.Join(", ", songs));
                }
                else if ( song.Substring(0,3) == "Add")
                {
                    string songName = song.Substring(4);
                    if (songs.Contains(songName)) Console.WriteLine($"{songName} is already contained!");
                    else songs.Enqueue(songName);
                }                
                song = Console.ReadLine();
            }            
        }
    }
}