using System;

namespace _14.CuentaBancaria {
    [Serializable()]
    class CuentaBancaria {

        protected double saldo;  // permite que sea accedio por las clases que herdan

        public CuentaBancaria(double saldo) {
            this.saldo=saldo;
        }
        public double Saldo {
            get { return saldo;}
        }

        public void Deposita(double cantidad) {
            saldo+=cantidad;
        }

        // metodo virtual que podra ser sobrecargado por la clase que lo herede
        public virtual bool Retira(double cant) {
            if(saldo>=cant) {
                saldo-=cant;
                return true;
            } else return false;
        }
    }


}