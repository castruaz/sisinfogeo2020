using System;

namespace p11.vectorinverso
{
    class Program
    {
          static void Main(string[] args)
        {
            double[] A = new double[15];
            double[] B = new double[15];
            
            Random rnd = new Random();

            for(int i=0; i<A.Length; i++)  {
                A[i]= rnd.Next(1,30);
                B[14-i]=A[i];
                 
            }
            Console.WriteLine("\n El vector A"); imprime(A);
            Console.WriteLine("\n El vector B"); imprime(B);
        }
        static void imprime(double[] v) {
                for(int i=0; i<v.Length; i++)
                    Console.Write($"{v[i]} ");
                Console.WriteLine();
            }

    }
}
