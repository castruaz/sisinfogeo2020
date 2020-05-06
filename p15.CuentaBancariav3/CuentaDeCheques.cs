using System;
using System.Collections.Generic;

namespace _14.CuentaBancaria
{
    class CuentaDeCheques : CuentaBancaria {
        private double proteccionSobregiro;
        
        public CuentaDeCheques(double saldo, double proteccionSobregiro) 
            : base(saldo)
        {
            this.proteccionSobregiro=proteccionSobregiro;
        }
     
        public override bool Retira(double cantidad)
        {
            bool resultado = true; if (cantidad > saldo) {
            double proteccionRequerida = cantidad - saldo; 
            if (proteccionSobregiro < proteccionRequerida)
                return false;
            else {
                saldo = 0.0;
                proteccionSobregiro -= proteccionRequerida; }
            }
            else {
                saldo -= cantidad;
                return true;
            }
            return resultado;
        }
        
    }
}