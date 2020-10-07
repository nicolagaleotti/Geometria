using System;
using Geometria;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r1 = new Rettangolo(1, 2, 10, 10);
            Rettangolo r2 = new Rettangolo(1, 2, 3, 4);
            Console.WriteLine(r1.CalcolaArea());
            Console.WriteLine(r2.CalcolaArea());
            Console.WriteLine(r1.Contiene(r2));
            Console.WriteLine(r2.Contiene(r1));
        }
    }
}
