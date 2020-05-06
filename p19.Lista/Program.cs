using System;
using System.Collections.Generic;

namespace p18.Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> materias = new List<string>() {
                "Calculo I",
                "Redaccion Avanzada",
                "Introduccion a la Ingenieria en Computacion"
            };
            
            materias.Add("Matemáticas Discretas");
            materias.Add("Compipadores e Interpretadores");
            
            Console.Clear();

            // Capacidad
            Console.WriteLine("Cuenta: {0}", materias.Count);

            // Agregar un rango de elementos a la lista
            string[] materias_optativas = {
                "Seguridad en Redes de Computadoras (op)",
                "Sistemas de Información Geográficos (op)",
                "Fundamentos de Robotica (op)",
                "Topicos Selectos de Redes (op)"
            };

            materias.AddRange(materias_optativas);

            Console.WriteLine("Cuenta: {0}", materias.Count);

            // Iterar sobre los elementos de la lista
            Console.WriteLine("\nMaterias:\n");
            Imprime(materias);

            // Invertir la lista
            Console.WriteLine("\nMaterias en orden inverso:\n");
            materias.Reverse();
            Imprime(materias);

            // Ordenar
            Console.WriteLine("\nMaterias Ordenadas:\n");
            materias.Sort();
            Imprime(materias);
            
            // Buscar un elemento
            Console.WriteLine("Que buscas");
            var t = materias.Find(x=>x.Contains("Discretas"));
            Console.Write($"es: {t}");

            // Buscar un Todos
            Console.WriteLine("Que buscas");
            var t1 = materias.FindAll(x=>x.Contains("(op)"));
            Imprime(t1);

            // El rango
            Console.WriteLine("El rango:\n");
            var rango = materias.GetRange(1,3);
            Imprime(rango);

            // Remover un rango las ultimas 2
            Console.WriteLine("Despues de Remover los 2 ultimos");
            materias.RemoveRange(materias.Count-2,2);
            Imprime(materias);

        }

        public static void Imprime(List<string> mats) {
            foreach(string materia in mats)
                Console.WriteLine($"{materia}");
        }


    }
}
