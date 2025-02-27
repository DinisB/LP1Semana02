using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro: ");
            sbyte.TryParse(Console.ReadLine(), out sbyte n);
            Console.WriteLine(--n);
            Console.WriteLine(++n);
        }
    }
}
