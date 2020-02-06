using System;

namespace p07.vectorpromedio
{
    class Program
    {
         static void Main(string[] args)
        {
            int[] vector = {
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100
            };

            int suma=0, nmp=0;
            float promedio=0;

            Console.WriteLine("Los elementos del arreglo son: \n");
            for(int i=0; i<vector.Length; i++) {
                Console.Write($"{vector[i]} ");
                suma += vector[i];
            }
            
            promedio = suma / vector.Length;
            Console.WriteLine($"\n El promedio es {promedio} \n");

            Console.WriteLine("\n Numeros mayores que el promedio: \n");
            for(int i=0; i<vector.Length; i++) {
                if(vector[i]>promedio) {
                    Console.Write($"{vector[i]} ");
                    nmp++;
                }
            }

            Console.WriteLine($"\nMayores que el promedio {nmp}");
             
        }
    }
}