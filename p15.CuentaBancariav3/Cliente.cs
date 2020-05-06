using System;
using System.Collections.Generic;

namespace _14.CuentaBancaria {
    class Cliente {

        private string nombre;
        private CuentaBancaria cuenta;
        private List<CuentaBancaria> cuentas;

        public Cliente(string nombre) {
            this.nombre = nombre;
            cuentas = new List<CuentaBancaria>();
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public CuentaBancaria Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public void AgregarCuenta(CuentaBancaria cuenta) {
            cuentas.Add(cuenta);
        }

        public List<CuentaBancaria> Cuentas {
            get { return cuentas;}
        }      
        
    }
}