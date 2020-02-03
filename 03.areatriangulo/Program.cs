using System;

namespace _03.areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float labase, laaltura, elarea;


            Console.WriteLine("Programa que calcula el area de un triangulo");

            Console.WriteLine("Dame la base :");
            labase=float.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura :");
            laaltura=float.Parse(Console.ReadLine());

            elarea = (labase*laaltura) /2;

            Console.WriteLine($"El area es {elarea}");
          



        }
    }
}
