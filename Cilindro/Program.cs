using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Altura: ");
            double.TryParse(Console.ReadLine(), out double altura);
            Console.Write("Raio: ");
            double.TryParse(Console.ReadLine(), out double raio);
        }
    }
}
