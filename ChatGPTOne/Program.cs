using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Escreve uma pergunta");
            string input = Console.ReadLine();
            switch (input) 
            {
                case "que vitamina dão as bananas?":
                    Console.WriteLine("potássio");
                    break;
            }
        }
    }
}
