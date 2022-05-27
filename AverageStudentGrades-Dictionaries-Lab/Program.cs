using System;
using System.Collections.Generic;
using System.Linq;
namespace AverageStudentGrades_Dictionaries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> output = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!output.Keys.Contains(name))
                {
                    output[name] = new List<decimal>();
                    output[name].Add(grade);
                }
                else
                {
                    output[name].Add(grade);
                }

            }

            foreach (var item in output)
            {

                List<decimal> notes = item.Value;
                
                    Console.WriteLine($"{item.Key} -> {string.Join(" ", notes.Select(n => n.ToString("f2")))} (avg: {notes.Average():f2})");



                
            }
        }
    }
}
