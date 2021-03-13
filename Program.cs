using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            string Sobrenome;

            Console.WriteLine("--------------");
            Console.WriteLine("Nome Completo");
            Console.WriteLine("--------------");

            Console.WriteLine();
            Console.Write("digite seu primeiro nome: ");
            Nome = Console.ReadLine();
            Console.Write("digite seu sobrenome: ");
            Sobrenome = Console.ReadLine();
            Console.Write("\n");

            Console.Write($"Nome Completo: {Nome} {Sobrenome}");
            Console.Write("\n");
            Console.WriteLine();
            Console.WriteLine("Veja seu nome em catálogo!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Sobrenome.ToUpper()}, {Nome}");
            Console.Write("\n");
            Console.ResetColor();
            Console.WriteLine();
         
        }
    }
}
