using System;

namespace p05.pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            if(args.Length==0) Menu();
            else Procesar(args);
            
            return 0;

        }

        static void Procesar(string[] args) {
            
           char tam, cub, par;
           string [] ings;

           string tamano="", ingredientes="", cubierta="", para="";

           // Tamano
           tam = char.Parse(args[0]);
           if(tam=='P') tamano="Pequena" ;
           else if(tam=='M') tamano="Mediana";
           else tamano="Grande";

           // Ingredientes
           ings = args[1].Split("+");
           foreach(string i in ings) {
               switch(char.Parse(i)) {
                   case 'E' : ingredientes+="Etraqueso ";break;
                   case 'C' : ingredientes+="Champinones";break;
                   case 'P' : ingredientes+="Pina ";break;
               }
           }

            // Cubierta
           cub = char.Parse(args[2]);
           if(cub=='D') cubierta="Delgada" ;
           else cubierta="Gruesa";


              // Para
           par = char.Parse(args[3]);
           if(par=='C') para="Comer Aqui" ;
           else para="Llevar";


 
            // Imprimir Pedido
            Console.WriteLine("\n Tu Pizza queda de la siguiente forma");
            Console.WriteLine($"Tamano       : {tamano}");
            Console.WriteLine($"Ingredientes : {ingredientes}");
            Console.WriteLine($"Cubierta     : {cubierta}");
            Console.WriteLine($"PAra         : {para}");


        }

        static void Menu() {
            Console.Clear();
            Console.Write("Programa de venta de pizzas\n");
            Console.WriteLine("Elige las opciones de tu pizza \n");
            Console.WriteLine("tamano:       (P)equena (M)ediana (G)rande");
            Console.WriteLine("ingredientes: (E)xtra Queso, (C)hampinones, (P)ina ");
            Console.WriteLine("cubierta:     (D)elgada o (G)ruesa");
            Console.WriteLine("para:         (C)omer aquí o Para (L)levar.\n");
            Console.WriteLine("Especifica de la siguiente forma: \n");
            Console.WriteLine(" <tamano>  <ing1+ing2...> <cubierta> <para> : \n");
        }
    }
}
