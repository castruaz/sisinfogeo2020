using System;

// Ejemplo de delegado multicast

namespace p32.Delegados2
{
    // Declarando un delagado
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            // Se declaran tres delegados
            MiDelegado d1;
            MiDelegado d2;
            MiDelegado d3;

            MiDelegado d; // Se declara delegado multicast

            Console.Clear();

            // Asocia d1 a Mensaje1 y d2 a Mensaje2
            d1 = Delegados.Mensaje1;
            d2 = Delegados.Mensaje2;

            d = d1+d2; // Combina delegado d1 y delagado d2
            d("El Peje");
            Console.WriteLine();

            d3 = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d += d3; // Agrega delegado d3
            d("El borolas");
            Console.WriteLine();

            d -= d2; // Quita delegado d2 
            d("Peña");
            Console.WriteLine();

            d -= d1; // Quita delegado d1
            d("Tello");
            Console.WriteLine();
        }
    }
}
