using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> word = new Stack<string>();
            Console.WriteLine("Please enter a word:");
            string entry = Console.ReadLine();
            int count = 1;
            string rentry = null;
            bool done = false;
            while (done == false)
            {
                if (entry.Length >= count)
                {
                    rentry = rentry + entry.Substring(entry.Length - count, 1);
                    count++;
                }
                else
                {
                    done = true;
                }
            }
            Console.WriteLine(rentry);
            done = false;
            while (done == false)
            {
                int i = 0;
                if (i < entry.Length)
                {
                    word.Push(entry.Substring(i, 1));
                    i++;
                }
                else
                {
                    done = true;
                }

            }
            
        }
    }
}