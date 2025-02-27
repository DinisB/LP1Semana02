using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true) {
            Console.Write("Escreve uma pergunta (EXIT para sair): ");
            string input = Console.ReadLine();
            if (input == "exit")
                break;
            
            switch (input) 
            {
                case "que vitamina dão as bananas?":
                    Console.WriteLine("potássio");
                    break;
                case "qual é o queijo mais rançoso?":
                    Console.WriteLine("vieux boulogne");
                    break;
                case "quanto é 0 a dividir por 0?":
                    Console.WriteLine("/bin/rm -f file.log");
                    break;
                case "quem é a coisa mais veloz de sempre?":
                    Console.WriteLine("o faisca ou o sonic");
                    break;
                default:
                    Console.WriteLine("Não entendi, podes repetir?");
                    break;
            }
            }
        }
    }
}
