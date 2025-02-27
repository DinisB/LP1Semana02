using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro-não negativo: ");
            byte.TryParse(Console.ReadLine(), out byte n);
            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            Console.WriteLine(n ^ 6);
            Console.WriteLine(n > 10);
        }
    }
}
