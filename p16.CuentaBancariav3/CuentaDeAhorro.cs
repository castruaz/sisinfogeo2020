using System;
using System.Collections.Generic;

namespace _14.CuentaBancaria
{    [Serializable()]
    class CuentaDeAhorro : CuentaBancaria {
        private double tasaDeIneres;
        
        public CuentaDeAhorro(double saldo, double tasaDeIneres) 
            : base(saldo)
        {
            this.tasaDeIneres=tasaDeIneres;
        }
        public void CalcularInteres() {
            saldo+=(tasaDeIneres*saldo);
        }
    }
}