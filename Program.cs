using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite algo para sair como o cebolinha diria: ");
            string fala = Console.ReadLine();
            Console.WriteLine(fala.Replace("rr","l").Replace("r","l").Replace("R","L"));
            Console.ReadKey();
        }
    }
}
