using System;

namespace p06.tablas
{
    class Program
    {
        static int Main(string[] args)
        {
            if(args.Length==0) Menu();

            int op    = int.Parse(args[0]), 
                tabla = int.Parse(args[1]),
                desde = int.Parse(args[2]),
                hasta = int.Parse(args[3]);

            switch(op) {
                case 1:{
                    for(int i=desde; i<=hasta; i++) 
                        Console.WriteLine($"{tabla} x {i} = {tabla * i}");
                } break;
                
                case 2:{
                    for(int j=1; j<=tabla; j++) {
                        for(int i=desde; i<=hasta; i++) 
                            Console.WriteLine($"{j} x {i} = {j * i}");
                        Console.WriteLine();
                    }
                    
                } break;
            }

            return 0;
        }

        static void Menu() {
            Console.WriteLine("Progrma que imprime tablas de multiplicar \n");
            Console.WriteLine("[1] . Imprimir una tabla de multiplicar específica hasta cierto número (ej. la tabla del 5 , del 1 al 10)");
            Console.WriteLine("[2] . Imprimir las tablas deseadas hasta el número deseado. (ej. hasta la table del 5, del 1 al 11)");
            Console.WriteLine("\n Especificar:  <opcion> <tabla> <desde> <hasta>");
        }

        

    }
}
