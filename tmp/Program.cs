using System;

namespace tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje="Hola mundo";

            char[] m2 = mensaje.ToCharArray();

            Console.WriteLine(mensaje[0]);

            foreach(char c in m2)
            Console.WriteLine(c);

            for(int i=0; i<mensaje.Length; i++)
                Console.WriteLine(mensaje[i]);

            Console.WriteLine(mensaje.Contains("mundo"));

            mensaje.

        }
    }
}
