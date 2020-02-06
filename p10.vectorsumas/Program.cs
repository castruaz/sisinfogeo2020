using System;

namespace p10.vectorsumas
{
    class Program
    {
         static void Main(string[] args)
        {
            double[] A = new double[30];
            int pos=0, neg=0, cer=0;
           
            
            Random rnd = new Random();

            for(int i=0; i<A.Length; i++)  {
                A[i]= rnd.Next(-30,30);
                if(A[i]>0) pos++;
                    else if(A[i]==0) cer++;
                    else neg++; 
            }

            Console.WriteLine("\n El vector A"); imprime(A);
            Console.WriteLine();
            Console.WriteLine($"Positivos {pos}");
            Console.WriteLine($"Ceros     {cer}");
            Console.WriteLine($"Negativos {neg}");
             
        }
        static void imprime(double[] v) {
                for(int i=0; i<v.Length; i++)
                    Console.Write($"{v[i]} ");
            }
    }
}

