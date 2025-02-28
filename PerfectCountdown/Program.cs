using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Start Number: ");
            int.TryParse(Console.ReadLine(), out int start);
            Console.Write("Step Number: ");
            int.TryParse(Console.ReadLine(), out int step);

            if (start <= 1){
                Console.WriteLine("Out-of-range start or step. Try again.");
            }
            else if (step >= start){
                Console.WriteLine("Start must be higher than step. Try again.");
            }
            else if (start % step != 0) {
                Console.WriteLine("Start not divisible by step. Try again.");
            }
        }
    }
}
