using System;
using Polimorfismo.Classes;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Megaman m = new Megaman();
            Zero z = new Zero();

Console.WriteLine("Megaman ");
            Console.WriteLine(m.Correr());
            Console.WriteLine(m.Pular());

Console.WriteLine("\nZero ");
            Console.WriteLine(z.Pular());
            Console.WriteLine(z.Correr());
        }
    }
}
