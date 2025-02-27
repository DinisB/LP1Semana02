﻿using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true){
            Console.Write("Start number: ");
            int.TryParse(Console.ReadLine(), out int start);
            Console.Write("Step number: ");
            int.TryParse(Console.ReadLine(), out int step);

            if (start <= 1){
                Console.WriteLine("Out-of-range start or step. Try again.");
                continue;
            }
            else if (step >= start){
                Console.WriteLine("Start must be higher than step. Try again.");
                continue;
            }
            else if (start % step != 0) {
                Console.WriteLine("Start not divisible by step. Try again.");
                continue;
            }
            while (start != 0){
                Console.WriteLine(start);
                start -= step;
            }
            Console.WriteLine(start);
            break;
            }
        }
    }
}
