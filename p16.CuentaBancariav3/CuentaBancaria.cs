using System;
namespace _14.CuentaBancaria {
     
 [Serializable()]
    class CuentaBancaria {

        protected double saldo; // podra ser accedido por las clases derivadas

        public CuentaBancaria(double saldo) {
            this.saldo=saldo;
        }
        
        public double Saldo {
            get { return saldo;}
        }

        public void Deposita(double cant) {
            saldo+=cant;
        }

        // metodo virtual que podra ser sobrecargado por las clases derivadas
        public virtual bool Retira(double cant) {
            if(saldo>=cant) {
                saldo-=cant;
                return true;
            } else return false;
        }
    }


}