using System;
using System.Collections.Generic;

namespace _14.CuentaBancaria
{
    class Program
    {
        // Prueba Clase Banco
        static void Main() {
            Banco mibanco = new Banco("El cocinito","Mac Pato");
                 
            mibanco.AgregarCliente(new Cliente("Juan Camaney")); 
            mibanco.AgregarCliente(new Cliente("Jessica Alba")); 
            mibanco.AgregarCliente(new Cliente("Tony Soprano")); 
            mibanco.AgregarCliente(new Cliente("Jack Bauer"));

            mibanco.Clientes[0].Cuenta = new CuentaBancaria(100);
            mibanco.Clientes[1].Cuenta = new CuentaBancaria(200);
            mibanco.Clientes[2].Cuenta = new CuentaBancaria(300);
            mibanco.Clientes[3].Cuenta = new CuentaBancaria(0);
            mibanco.Clientes[2].Cuenta.Retira(100);
            mibanco.Clientes[3].Cuenta.Deposita(50);

            Console.WriteLine("Reporte General \n");
            Console.WriteLine($"Banco {mibanco.Nombre} propiedade de {mibanco.Propietario}");
            foreach(Cliente cte in mibanco.Clientes) {
                Console.WriteLine($"El cliente {cte.Nombre}");
                Console.WriteLine($"Tiene una cuenta con saldo {cte.Cuenta.Saldo}\n");
            }
        }


        // Prueba Clase CuentaBancaria
        static void PruebaCuentaBancaria(string[] args)
        {
            CuentaBancaria chelines = new CuentaBancaria(1000);
            Console.WriteLine($"Saldo al crear {chelines.Saldo}");
            chelines.Deposita(500);
            Console.WriteLine($"Saldo despues del domingo {chelines.Saldo}");
            if(chelines.Retira(600)) 
                Console.WriteLine($"Saldo despues la peda {chelines.Saldo}");
            else
                Console.WriteLine("No puedes andar organizando fiestas si no tienes dinero");
        }
    
        // Prueba Clase Cliente
        static void PruebaCliente(string[] args) {
            CuentaBancaria cuenta = null;
            
            Console.WriteLine("Creando al cliente Juan Perez"); 
            Cliente clientazo = new Cliente("Juan Perez");

            Console.WriteLine("Creando una cuenta con saldo de 500"); 
            clientazo.Cuenta=new CuentaBancaria(500);       
            cuenta = clientazo.Cuenta;

            Console.WriteLine("Retiro de 150"); 
            cuenta.Retira(150);
            Console.WriteLine("Deposito de 22.50"); 
            cuenta.Deposita(22.5);
            Console.WriteLine("Retiro de 47.62"); 
            cuenta.Retira(47.62);
            // Imprime saldo final de la cuenta
            Console.WriteLine($"Cliente {clientazo.Nombre} tiene un saldo de {cuenta.Saldo}");
        }
    }
}
