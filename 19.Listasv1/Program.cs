using System;
using System.Collections.Generic;

namespace _19.Listasv1
{
    class Program
    {
        static void Main(string[] args)
        {
             // Definir una lista con valores iniciales
             List<string> mats = new List<string>() {
                 "Calculo I",
                 "Redaccion Avanzada",
                 "Introduccion a la Ingenieria"
             };

             // Agregar elementos a la lista
             mats.Add("Matematicas Discretas");
             mats.Add("Compiladores e Intepretadores");

             Imprime(mats);

             // Agregar un rango de materias
             string[] mopt = {
                "Sistemas de Info Geo (op)",
                "Seguridad en Redes (op)",
                "Topicos Selectos de Redes (op)"
             };
             mats.AddRange(mopt);
             Imprime(mats);

             // Invertir los elementos de la lista
            mats.Reverse();
            Imprime(mats);

            // Ordernar la lista
            mats.Sort();
            Imprime(mats);

            // Buscar un elemeto en la lista, en base a una condicion
            Console.WriteLine("Buscar una materia que tenga la palabra Discretas");
            string mat = mats.Find(x=>x.Contains("Discretas"));
            Console.WriteLine(mat);

            // Buscar todas las ocurrencias en la lista, en base a una condicion
            Console.WriteLine("Buscar todas las mateterias que contengan (op)");
            var ms = mats.FindAll(x=>x.Contains("(op)"));
            Imprime(ms);

        }

        static void Imprime(List<string> lista) {
            Console.WriteLine("\n\n");
            foreach(string m in lista)
                Console.WriteLine(m);
            Console.WriteLine(lista.Count);
        }


    }
}
