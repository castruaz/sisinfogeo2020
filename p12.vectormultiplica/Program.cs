using System;

namespace p12.vectormultiplica
{
    class Program
    {
       static void Main(string[] args)
        {
            const int MAX=3;

            double[] A = new double[MAX];
            double[] B = new double[MAX];
            double[] C = new double[MAX];

            Console.WriteLine("Introduce los elementos de A");
            leer(A);
            Console.WriteLine("Introduce los elementos de B");
            leer(B);

            for(int i=0; i<MAX; i++) {
                C[i]=A[i]+B[(MAX-1)-i];
            }

            Console.WriteLine("Los 3 vectores");
            imprime(A);
            imprime(B);
            imprime(C);
            
             
        }

        static void leer(double[] v)
        {
            for(int i=0; i<v.Length; i++) {
                Console.Write($"Elemento[{i+1}]= ");
                v[i]=double.Parse(Console.ReadLine());
            }
        }


        static void imprime(double[] v) {
                for(int i=0; i<v.Length; i++)
                    Console.Write($"{v[i]} ");
                Console.WriteLine();
            }

    }

    }

