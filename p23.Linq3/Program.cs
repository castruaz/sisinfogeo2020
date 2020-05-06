using System;
using System.Collections.Generic;
using System.Linq;

namespace p23.Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear la fuente de datos
            List<Estudiante> estudiantes = new List<Estudiante>() {
                new Estudiante { ID=111, Nombre="Juan",
                    Apeido="Perez", 
                    Calle="Principal 123", 
                    Ciudad="Zacatecas",
                    Califs=new List<int> {97,92,81,60} },
                new Estudiante { ID=222, Nombre="Maria", 
                    Apeido="Lopez", 
                    Calle="Principal 124", 
                    Ciudad="Fresnillo",
                    Califs=new List<int> {75,84,91,39} },
                new Estudiante { ID=333, Nombre="Rodrigo", 
                    Apeido="Mata", 
                    Ciudad="Rio Grande",
                    Calle="Principal 125", Califs=new List<int> {88,94,65,91} },
                new Estudiante { ID=444, Nombre="Miguel", 
                    Apeido="Mejia", 
                    Ciudad="Rio Grande",
                    Calle="Principal 125", Califs=new List<int> {70,90,60,40} }
            };

            // Obtener los datos
            Console.WriteLine("\nTodos:\n");
            var todos = (from est in estudiantes select est).ToList();
            todos.ForEach(s=>Console.WriteLine(s.ToString()));

            // Filtrar algunos datos
            Console.WriteLine("\nAlgunos (filtrar con where)\n");
            var algunos = (from est in estudiantes where est.Ciudad=="Fresnillo" select est).ToList();
            algunos.ForEach(s=>Console.WriteLine(s.ToString()));

             // Ordenar descendiente
            Console.WriteLine("\nOrdenar (con orderby)\n");
            var otros = (from est in estudiantes where est.Califs.Average()>=80 orderby est.Nombre descending select est ).ToList();
            otros.ForEach(s=>Console.WriteLine(s.ToString()));

            // Agrupar 
             Console.WriteLine("\n Agrupar (con group)\n");
            var mas = 
                from est in estudiantes
                group est by est.Ciudad;


            foreach(var grp in mas) {
                Console.WriteLine(grp.Key);
                foreach(Estudiante est in grp) {
                    Console.WriteLine(est.ToString());
                }
            }

            // Calculos con los datos, mostrar
            var proms = ( from est in estudiantes select $"nombre={est.Nombre}, prom={est.Califs.Average()}").ToList();
            proms.ForEach(p=>Console.WriteLine(p));

            // Calcular los datos, crear objeto
            var proms2 = ( from est in estudiantes select new { nombre=est.Nombre, prom=est.Califs.Average()}).ToList();
            proms2.ForEach(p=>Console.WriteLine(p));

            // Sintaxis procedural
            Console.WriteLine("Todos de otra forma:\n");
            var todos1 = estudiantes.Select(est=>est).ToList();
            todos1.ForEach(s=>Console.WriteLine(s.ToString()));

            // Filatrados procedural
            Console.WriteLine("Algunos otra forma:\n");
            var algunos1 = estudiantes.Where(est=>est.Ciudad=="Fresnillo").ToList();
            algunos1.ForEach(s=>Console.WriteLine(s.ToString()));

            // Ordenado procedural
            Console.WriteLine("\nOrdenar otra forma\n");
            var otros1 =estudiantes.Where(est=> est.Califs.Average()>=80).OrderBy(est=>est.Nombre).ToList();
            otros1.ForEach(s=>Console.WriteLine(s.ToString()));



            // Agrupar procedural
            Console.WriteLine("\n Agrupar otra forma\n");
            var mas1 = estudiantes.GroupBy(est=>est.Ciudad);

            foreach(var grp in mas1) {
                Console.WriteLine(grp.Key);
                foreach(Estudiante est in grp) {
                    Console.WriteLine(est.ToString());
                }
            }
        

        }



    }
}
