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
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            double superficie = 2 * Math.PI * raio * (raio + altura);
            Console.WriteLine("Volume do cilindro: {0:F3}", volume);
            Console.WriteLine("Area da superficie do cilindro: {0:F3}", superficie);
        }
    }
}
