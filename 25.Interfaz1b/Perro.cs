using System;

namespace _25.Interfaz1b
{
    class Perro : IAnimal
    {
        public Perro(string nombre) => Nombre=nombre;
        public string Nombre { get; set ; }
        public void Llorar()
        {
            Console.WriteLine("Woff Woff");
        }
    }
}
