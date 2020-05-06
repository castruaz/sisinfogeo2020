using System;
using System.Collections.Generic;

namespace p23.Linq3
{
    class Estudiante
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apeido {get; set;}
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public List<int> Califs;
        public override string ToString() =>  $"Id:{ID}, Nombre:{Nombre}, Apeido:{Apeido}, Calle:{Calle}, Ciudad:{Ciudad}, Calificaciones: {string.Join(",",Califs)} ";
    }
}