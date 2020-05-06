using System;
using System.Collections.Generic;

namespace p17.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diccionarios
           // Dictionary<string,string> dias = new Dictionary<string, string>();
            SortedDictionary<string,string> dias = new SortedDictionary<string, string>();
            dias.Add("txt","Archivo de Texto");
            dias.Add("jpg","Archivo de Imagen JPEG");
            dias.Add("mp3","Archivo de sonido mp3");
            dias.Add("htm","Archivo de Texto HTML");
            dias.Add("exe","Archivo Ejecutable");
            dias.Add("lll","Archivo de tipo desconocido");

            // Acceder un elemento individual por llave
             Console.WriteLine(dias["htm"]);


            // Verifica si la entrada no existe y la agrega (no puede haber entradas repetidas")
            if(!dias.ContainsKey("elf"))
                dias.Add("elf","Archivo ejecutable de Linux");

             // Iterar por el diccionario
            Console.WriteLine("\nLlave - Valor");
             foreach(KeyValuePair<string,string> val in dias) 
                Console.Write($"{val.Key} - {val.Value}\n");

            // Verifica si la entrada existe, de ser asi la borra
            if(dias.ContainsKey("lll"))
                dias.Remove("lll");

            // Iterar por las llaves
            Console.WriteLine("\nLlaves:");
            foreach(string llave in dias.Keys) 
                Console.WriteLine($"{llave}");

            // Iterar por las llaves
            Console.WriteLine("\nValores: ");
            foreach(string valor in dias.Values)
                Console.WriteLine($"{valor}");

           


        }
    }
}
