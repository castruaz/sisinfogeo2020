using System;
using System.Collections.Generic;
using System.Linq;

namespace p20.Linq1
{
    class Program
    {

        static void Main() {
            // fuente de datos
            int[] numbers = new int[]  {10,25,-1,10,0,320,22,65,800,-4,20,30,1000,2000,-233};

            // consulta
            var qrypares =
                from num in numbers
                where (num % 2) == 0
                select num;

            // Ejecutar consulta
            foreach (int num in qrypares)
                Console.Write("{0} ", num);

            Console.WriteLine("\nNumeros pares: {0}",qrypares.Count());

            // Impares en un arreglo
            var qryimpares = 
                ( from num in numbers 
                where (num%2)!=0 
                select num).ToArray();

            for(int i=0; i<qryimpares.Count(); i++)
                Console.WriteLine(qryimpares[i]);

            // mayors de 100 en una lista
            Console.WriteLine("Mayores de 100: \n");
            var mayores = (from num in numbers where num>=100 select num).ToList();
            mayores.ForEach(n=>Console.WriteLine(n));
        }
    }
}

