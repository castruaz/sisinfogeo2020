using System;
using System.Collections.Generic;
using System.Linq;

namespace p20.Linq1
{
    class Program
    {

        static void Main() {
            
           string[] frutas = new string[] {"pera","melon","sandia","durazo","manzana","platano"};

    
            var mfrutas  = 
                from fruta in frutas 
                where fruta.StartsWith('m') 
                select fruta;

            foreach(var f in mfrutas) Console.WriteLine("{0}",f);

            var anfrutas = 
                from fruta in frutas 
                where fruta.Contains("an") 
                select fruta;

            foreach(var f in anfrutas) Console.WriteLine("{0}",f);

            var x = (from fruta in frutas where fruta.EndsWith('a') select fruta).ToArray();
            Console.WriteLine("\nTerminan en a:\n");
            for(int i=0; i<x.Count(); i++)
                Console.WriteLine(x[i]);


            var x2 = (from fruta in frutas where fruta.EndsWith('a') select fruta).ToList();
            Console.WriteLine("\nZopas:\n");
            x2.ForEach(f=>Console.WriteLine(f));
        

        }


       
}
}

