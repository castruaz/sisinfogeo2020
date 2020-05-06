using System;

namespace p19.Listav2
{
    class Pieza {
        // Expression Bodied Members
        public Pieza(int id, string nombre) => (Id,Nombre) = (id,nombre);
        public int Id {get; set;}
        public string Nombre {get; set;}
    }
}