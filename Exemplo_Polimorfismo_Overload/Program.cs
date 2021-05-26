using System;
using Polimorfismo_Overload.Classes;

namespace Polimorfismo_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (int i = 0; i < f.lista.Length; i++)
            {
                Console.WriteLine("Digite um item para a lista: ");
                f.lista[i] = Console.ReadLine();
            }

            Console.WriteLine("\nMostrar sem Argumentos");
            f.Mostrar();
            
            Console.WriteLine("\nMostrar com Argumento int");
            f.Mostrar(2);

            Console.WriteLine("\nMostrar com Argumento string");
            f.Mostrar("manga");
        }
    }
}
