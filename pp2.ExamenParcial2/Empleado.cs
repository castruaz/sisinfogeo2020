using System;

namespace p24.ImportarCVS
{
    public class Empleado
    {
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Area {get; set;}
        public double Salario {get; set;}
        public override string ToString() => $"{Rfc,-11}{Nombre,-38}{Area,-18}{Salario:0,000.00}";
    }
}
