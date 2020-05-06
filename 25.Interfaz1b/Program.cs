using System;

namespace _25.Interfaz1b
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Perro perro = new Perro("Sabuesa");
            Console.WriteLine($"{perro.Nombre}");
            perro.Llorar();

            Gato gato = new Gato("Manchas");
            Console.WriteLine($"{gato.Nombre}");
            gato.Llorar();

        }
    }
}
