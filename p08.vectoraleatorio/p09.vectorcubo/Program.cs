using System;

namespace p09.vectorcubo
{
    class Program
    {
         static void Main(string[] args)
        {
            double[] A = new double[20];
            double[] B = new double[20];
            
            Random rnd = new Random();

            for(int i=0; i<A.Length; i++)  {
                A[i]= rnd.Next(1,30);
                B[i]= Math.Pow(A[i],3);
                 
            }
            Console.WriteLine("\n El vector A"); imprime(A);
            Console.WriteLine("\n El vector B"); imprime(B);
        }
        static void imprime(double[] v) {
                for(int i=0; i<v.Length; i++)
                    Console.Write($"{v[i]} ");
            }
    }
}
