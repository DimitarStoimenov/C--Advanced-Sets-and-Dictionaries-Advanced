using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array_Dictionaries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Dictionary<double, int> output = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!output.Keys.Contains(input[i]))
                {
                    output.Add(input[i], 1);
                }
                else
                {
                    output[input[i]] += 1;
                }
            }



            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
