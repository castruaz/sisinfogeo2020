using System;
using System.Collections.Generic;

namespace p19.Listav2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pieza> partes = new List<Pieza>();

            partes.Add(new Pieza(1234,"tuerca rosca interior"));
            partes.Add(new Pieza(5678,"tornillo cabeza grande"));
            partes.Add(new Pieza(9345,"bateria 12 v"));

            // Agregar un rango de pieza nuevas
            var nuevas = new List<Pieza>()  
                { new Pieza(8888,"tornillo de cabeza pequena"),
                  new Pieza(9999,"cables para pasar corriente de acero "),
                  new Pieza(6666, "tridente el diablo")
                };
            partes.AddRange(nuevas);

            Imprime(partes);

            // Buscar elemento en la lista
            Console.WriteLine("Cual buscas");
            var p = partes.Find(x => x.Id.Equals(9999));
            Console.WriteLine(p.ToString());


             // Buscar elemento en la lista que cumplan condicion (varios)
            Console.WriteLine("Todos los que incluyen cabeza: \n");
            var pa = partes.FindAll(x => x.Nombre.Contains("cabeza"));
            Imprime(pa);

            // Eliminar
            Console.WriteLine("Elimina elemento");
            partes.RemoveAt(partes.Count-1);
            Imprime(partes);

            // Insertar en la 2da posicion
            Console.WriteLine("Insertar un elemento en la posicion 2 \n");
            partes.Insert(1, new Pieza(2222,"caja de velocidades"));
            Imprime(partes);

            // Verdadero para todos?
            Console.WriteLine("Todas las partes que contiene la palabra \"de\" ?");
            var de = partes.TrueForAll(x => x.Nombre.Contains("de"));
            Console.WriteLine(de);

            // Otra forma de imprimir la lista
            Console.WriteLine("Otra forma de imprimir la lista");
            Imprime2(partes);



        }

        public static void Imprime(List<Pieza> lista) 
        {
            foreach (Pieza p in lista)
                Console.WriteLine($"{p.ToString()}");
        
        }

        public static void Imprime2(List<Pieza> lista) 
        {
            lista.ForEach(p => Console.WriteLine(p.ToString()));
        }

    }
}
