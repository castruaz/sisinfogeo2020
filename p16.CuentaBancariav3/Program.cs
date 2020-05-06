using System;
using System.Collections.Generic;
using System.IO;

namespace _14.CuentaBancaria
{
    class Program
    {
    
        static void Incializa(Banco banco) {
            banco.AgregarCliente(new Cliente("Juan Camaney"));
            banco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(500,0.5));
            banco.Clientes[0].AgregarCuenta(new CuentaDeCheques(1500,300));
            banco.AgregarCliente(new Cliente("Tony Soprano"));
            banco.Clientes[1].AgregarCuenta(new CuentaDeCheques(1500,200));
            banco.AgregarCliente(new Cliente("Jessica Alba"));
            banco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(2500,0.8));
            banco.Clientes[2].AgregarCuenta(new CuentaDeCheques(500,30));
            banco.AgregarCliente(new Cliente("Jack Bauer"));
            banco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(1500,0.9));
            banco.Clientes[3].AgregarCuenta(banco.Clientes[2].Cuentas[1]); 
            banco.CalculaIntereses();
        }

        static void Reporte(Banco banco) {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{banco.Nombre}");
            Console.WriteLine("Reporte de Clientes");
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine($"Total Clientes:{banco.Clientes.Count}\n");
            foreach(Cliente cte in banco.Clientes) {
                Console.WriteLine($"Cliente: {cte.Nombre} tiene {cte.Cuentas.Count} cuentas que son:");
                foreach(CuentaBancaria cta in cte.Cuentas) {
                    Console.Write( (cta is CuentaDeCheques)?"Cuenta de Cheques":"Cuenta de Ahorro ");
                    Console.WriteLine($", Saldo:{cta.Saldo}");
                }
                Console.WriteLine();
            }
        }

        static void Main() {
         
            Banco mibanco;
            string archivo="datos";

            Console.Clear();

            if(File.Exists(archivo)) {
                mibanco=new Banco();
                Utilerias.Cargar(archivo, ref mibanco);
                Console.WriteLine("----- Datos cargados -------");
            } else {
                
                mibanco = new Banco("Mina Grand", "Carlos");
                Incializa(mibanco);
                Utilerias.Grabar(archivo,mibanco);
                Console.WriteLine("----- Datos grabados --------");
            }
            Reporte(mibanco);

        
        }

         
    }
}
