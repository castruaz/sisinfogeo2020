using System;

namespace p35.Delegados5
{
    // Ejemplo de delegado como parámetro

    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado del;

            Console.Clear();
            
            del= ClaseA.MetodoA;
            Invocadelegado(del);

            del = ClaseB.MetodoB;
            Invocadelegado(del);

            del = (string msj) => Console.WriteLine($"Llamando expresion Lambada: {msj}");
            Invocadelegado(del);

            Console.WriteLine();

        }

        static void Invocadelegado(MiDelegado del) {
            del("Hola Mundo");
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