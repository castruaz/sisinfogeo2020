using System;

namespace p35.Delegados5
{
    // Ejemplo de delegado como parámetro

    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado del; // Se crea instancia de MiDelegado

            Console.Clear();
            
            del= ClaseA.MetodoA; 
            Invocadelegado(del); // Se invoca al delegado

            del = ClaseB.MetodoB;
            Invocadelegado(del); // Se invoca al delegado

            del = (string msj) => Console.WriteLine($"Llamando expresion Lambada: {msj}");
            Invocadelegado(del); // Se invoca al delegado

            Console.WriteLine();

        }

        // Este método recibe como parámetro un delegado
        static void Invocadelegado(MiDelegado del) {
            del("Hola Mundo"); // se invoca al delegado
        }
    }

    class ClaseA {
        public static void MetodoA(string msj) {
            Console.WriteLine($"Llamando MetodoA de ClaseA : {msj}");
        }
    }

    class ClaseB {
        public static void MetodoB(string msj) {
            Console.WriteLine($"Llamando MetodoB de ClaseB : {msj}");
    }
}

}