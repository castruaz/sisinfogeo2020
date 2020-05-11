using System;

// Ejemplo de delagado simple

namespace p31.Delegados1
{
    // Declarando un delagado
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d; // Se instancia delegado

            Console.Clear();

            // Delegado invoca al metodo Mensaje1 de la clase Mensajes
            d = Mensajes.Mensaje1;
            d("Juan");

            // Delegdo invoca al metodo Mensaje2 de la clase Mensajes
            d = Mensajes.Mensaje2;
            d("Jose");

            // Delegado invoca a una expresion lambada 
            d = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d("Carlos");

            Console.WriteLine();
        }
    }

    public class Mensajes {
        public static void Mensaje1(string msj) {
            Console.WriteLine($"{msj} - lleva el pastel");
        }
        public static void Mensaje2(string msj) {
            Console.WriteLine($"{msj} - fue el culpable se cancela la fiesta");
        }
    }
}
