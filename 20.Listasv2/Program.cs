using System;
using System.Collections.Generic;

namespace _20.Listasv2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de tipo Pieza
            List<Pieza> mp = new List<Pieza>();

            // Agregar elementos a la lista
            mp.Add(new Pieza(1234,"tuerca de rosca interior"));
            mp.Add(new Pieza(5678,"tornillo cabeza grade"));
            mp.Add(new Pieza(9345,"bateria 12 v"));

            // Agregar un rango de elementos
            var proveedor = new List<Pieza>() {
                new Pieza(8888,"tornillo de cabeza pequena"),
                new Pieza(9999,"cables para pasar corrinte"),
                new Pieza(6666,"tridente del diablo")
            };
            mp.AddRange(proveedor);

            // Usar el metodo foreach integrado en la lista para imprimir so contenido
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            // Eliminar el ultimo elemento de la lista
            mp.RemoveAt(mp.Count-1);

            // Insertar un elemento en la 2da posicion
            Console.WriteLine("Insertar un elemento en la posicion 2");
            mp.Insert(1, new Pieza(2222,"caja de 8 velocidas"));
            mp.ForEach(p=>Console.WriteLine(p.ToString()));      

            // Buscar todas las piezas que tengan la palabra tornillo
            Console.WriteLine("Piezas que contienen tornillo");
            var t=mp.FindAll(x=>x.Nombre.Contains("tornillo"));
            t.ForEach(p=>Console.WriteLine(p.ToString())); 

            // Bucar todas las piezas cuyo ID es menor que 5000
            Console.WriteLine("Piezas con id > 5000");
            var t1=mp.FindAll(x=>x.Id>5000);
            t1.ForEach(p=>Console.WriteLine(p.ToString())); 


        }
    }
}
