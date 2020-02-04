using System;

namespace p04.ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int op=0, c=0, suma=0;
            Console.Clear();
            Console.WriteLine("\nProgrma sobre el uso de ciclos en c# \n");
            if(args.Length==0) {
                
                Menu();
                return 1;

            }

            op=int.Parse(args[0]);

            switch(op) {
                case 1: {
                    c=1;
                    suma=0;
                    while(c<=100) {
                        Console.Write($"{c} ");
                        suma+=c;
                        c++;
                    }
                    Console.WriteLine($"\n\nLa suma es {suma}\n");
                } break;
                case 2: {
                    c=100;
                    suma=0;
                    while(c>=1) {
                        Console.Write($"{c} ");
                        suma+=c;
                        c--;
                    }
                    Console.WriteLine($"\n\nLa suma es {suma}\n");
                } break;
                case 3: {
                    suma=0;
                    for(c=50; c<=200; c++) {
                        Console.Write($"{c} ");
                        suma+=c;
                    }
                    Console.WriteLine($"\n\nLa suma es {suma}\n");
                } break;
                case 4: {
                    suma=0;
                    for(c=2; c<=100; c+=2) {
                        Console.Write($"{c} ");
                        suma+=c;
                    }
                    Console.WriteLine($"\n\nLa suma es {suma}\n");
                } break;
                case 5: {
                    suma=0;
                    for(c=99; c>=1; c-=2) {
                        Console.Write($"{c} ");
                        suma+=c;
                    }
                    Console.WriteLine($"\n\nLa suma es {suma}\n");
                } break;
                case 6: {
                    c=272;
                    suma=0;
                    while(c>=40) {
                        Console.Write($"{c} ");
                        suma+=c;
                        c-=4;
                    }
                    Console.WriteLine($"\n\nLa suma es {suma}\n");
                } break;
                default: {
                    Console.WriteLine("\n Opcion invalida");
                } break;
            }

            return 0;
        }

        static void Menu() {
            Console.WriteLine("[1] . Números del 1 al 100 con ciclo while");
            Console.WriteLine("[2] . Números del 100 al 1 con ciclo do .. while");
            Console.WriteLine("[3] . Números del 50 al 200 con ciclo for");
            Console.WriteLine("[4] . Números del 2 al 100 solo los pares con ciclo for");
            Console.WriteLine("[5] . Números del 99 al 1 solo los impares con ciclo for");
            Console.WriteLine("[6] . Números del 40 al 272 en decrementos de 4 con ciclo while");

        }

    }
}
