using System;
using System.Net.NetworkInformation;
using System.Net;


namespace pba
{
    class Program
    {
        static void Main(string[] args)
        {

            if( args.Length < 1 ) Menu();
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                switch(int.Parse(args[0])) {
                    case 1: Ping("www.google.com"); break;
                    case 2: DnsAndIPLocal(); break;
                    case 3: InterfacesRed(); break;
                    default: Console.WriteLine("Opcion invalida ...");break;
                }
                Console.ForegroundColor = ConsoleColor.Black;
            }


           
        }

        static void Menu() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[-] Menu de opciones operaciones de red \n");
            Console.WriteLine("[-] Hacer ping a google.com  ....................... [1]");
            Console.WriteLine("[-] Obtener nombre host e ip de mi maquina ......... [2]");
            Console.WriteLine("[-] Obtener interfaces de red de mi mquina ......... [3]");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void Ping(string ipaddr) {
            Ping ping = new Ping();
            Console.WriteLine("Haciendo ping a google.com");
            PingReply reply = ping.Send(ipaddr,1000);
            Console.WriteLine($"Respuesta: {reply.Status.ToString()}");
        }

        static void DnsAndIPLocal() {
            string hostname = Dns.GetHostName();
            string ip = Dns.GetHostEntry(hostname).AddressList[0].ToString();
            Console.WriteLine($"Nombre del host : {hostname}");
            Console.WriteLine($"Ip del host     : {ip}");
        }


        static void InterfacesRed()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine($"Numero de interfaces indentificadas {interfaces.Length}");
            foreach(NetworkInterface interfaz in interfaces) {
                Console.Write($"{interfaz.Id} - ");
                Console.Write($"{interfaz.NetworkInterfaceType} - ");
                Console.Write($"{interfaz.GetPhysicalAddress()}\n");
                if(interfaz.NetworkInterfaceType == NetworkInterfaceType.Ethernet || 
                    interfaz.NetworkInterfaceType == NetworkInterfaceType.Wireless80211) {
                        PhysicalAddress ips =   interfaz.GetPhysicalAddress();
                        
                }
            }
            Console.WriteLine();
        }
    }
}

