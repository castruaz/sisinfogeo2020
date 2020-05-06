using System;

namespace p20.Linq1
{
    class Cliente  {

        public Cliente(string nombre, string pais, string ciudad ) => (Nombre,Pais,Ciudad) = (nombre,pais,ciudad);
        public string Nombre {get; set;}
        public string Pais {get; set;}
        public string Ciudad {get; set;}
    }


}