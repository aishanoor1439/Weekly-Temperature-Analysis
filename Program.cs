using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Temperature_Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] temperatures = new double[7];
            Console.WriteLine("Enter temperatures for 7 days:");
            for (int i = 0; i < 7; i++)
            {
                temperatures[i] = Convert.ToDouble(Console.ReadLine());
            }

            double total = 0, highest = temperatures[0], lowest = temperatures[0];
            for (int i = 0; i < 7; i++)
            {
                total += temperatures[i];
                if (temperatures[i] > highest)
                {
                    highest = temperatures[i];
                }
                if (temperatures[i] < lowest)
                {
                    lowest = temperatures[i];
                }
            }
            double average = total / 7;

            Console.WriteLine($"Average: {average:F2}, Highest: {highest}, Lowest: {lowest}");
            Console.WriteLine("Days with temperatures above average:");
            for (int i = 0; i < 7; i++)
            {
                if (temperatures[i] > average) Console.WriteLine($"Day {i + 1}");
            }
        }
    }
}
