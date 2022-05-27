using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers.Dictionaries.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();

            
                if (input.Length <= 2)
                {
                    Console.WriteLine(string.Join(" ", input));
                }

            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }

            
            
            
        }
    }
}
