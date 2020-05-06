using System;
using System.IO; // Libreria para StreamREader y StreamWriter
using CsvHelper; // Libreria para trabajar con archivos cvs
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p24.ImportarCVS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> registros=ObtenerDatos("data.cvs");

            if(args.Count()<1) 
                Menu();
            else {
                int op=int.Parse(args[0]);
                switch(op) {
                    case 1: {
                        Console.WriteLine("\nListado de nomina orden original:\n");
                        var rs = (from r in registros select r).ToList();
                        rs.ForEach(r=>Console.WriteLine(r.ToString()));
                        Console.WriteLine($"Tota:{rs.Count}");
                    } break;
                    case 2: {
                        Console.WriteLine("\nListado de nomina orden por nombre:\n");
                        var rs = (from r in registros orderby r.Nombre select r).ToList();
                        rs.ForEach(r=>Console.WriteLine(r.ToString()));
                        Console.WriteLine($"Tota:{rs.Count}");
                    } break;
                    case 3: {
                        Console.WriteLine("\nListado de nomina orden por salario:\n");
                        var rs = (from r in registros orderby r.Salario descending select r).ToList();
                        rs.ForEach(r=>Console.WriteLine(r.ToString()));
                        Console.WriteLine($"Tota:{rs.Count}");
                    } break;
                    case 4: {
                        Console.WriteLine("\nListado de nomina con salario>2500:\n");
                        var rs = (from r in registros where r.Salario>3500 select r).ToList();
                        rs.ForEach(r=>Console.WriteLine(r.ToString()));
                        Console.WriteLine($"Tota:{rs.Count}");
                    } break;
                    case 5: {
                        Console.WriteLine("\nListado de nomina con 77 en el Rfc:\n");
                        var rs = (from r in registros where r.Rfc.Contains("77") select r).ToList();
                        rs.ForEach(r=>Console.WriteLine(r.ToString()));
                        Console.WriteLine($"Tota:{rs.Count}");
                    } break;
                    case 6: {
                        Console.WriteLine("\nListado de nomina con los JUBILADOS:\n");
                        var rs = (from r in registros where r.Area=="JUBILADOS" select r).ToList();
                        rs.ForEach(r=>Console.WriteLine(r.ToString()));
                        Console.WriteLine($"Tota:{rs.Count}");
                    } break;
                    case 7: {
                        Console.WriteLine("\nListado de nomina agrupado por area:\n");
                        var rs = from r in registros orderby r.Nombre
                        group r by r.Area;
                        double st=0;
                        foreach(var area in rs) {
                            double s=0;
                            Console.WriteLine($"\n{area.Key}:");
                            foreach(var r in area) {
                                Console.WriteLine(r.ToString());
                                s+=r.Salario;
                            }
                            Console.WriteLine($"Total:{area.Count()} - {s:0,000.00}");
                            st+=s;
                        }
                        Console.WriteLine($"\nTotal Areas:{rs.Count()} - {st:0,000.00}");   
                    } break;
                }
            }           
        }

        public static void Menu() {
            Console.Clear();
            Console.WriteLine("Listado de nomina orden original......... [1]");
            Console.WriteLine("Listado de nomina ordenado por nombre ... [2]");
            Console.WriteLine("Listado de nomina ordenado por salario .. [3]");
            Console.WriteLine("Listado de nomina con salario > 3500 .... [4]");
            Console.WriteLine("Listado de nomina con 77 en el Rfc....... [5]");
            Console.WriteLine("Listado de nomina con los JUBILADOS...... [6]");
            Console.WriteLine("Listado de nomina agrupado por area...... [7]");
        }

        public static List<Empleado> ObtenerDatos(string archivo) {
            List<Empleado> registros = new List<Empleado>();
            registros=Leer(archivo);
            registros.Add(new Empleado {Rfc="CARC771123", Nombre="CARLOS CASTANEDA RODRIGUEZ",Area="JUBILADOS",Salario=5456.66});
            registros.Add(new Empleado {Rfc="SOBR711202", Nombre="ROCIO SOTO BOTELLO",Area="JUBILADOS",Salario=6423.66});
            registros.Add(new Empleado {Rfc="SUGA791124", Nombre="ARACELI SUSTAITA GOMEZ",Area="PROMOCION",Salario=2380.00});
            registros.Add(new Empleado {Rfc="DEAM690813", Nombre="MARGARITA DELGADILLO ARCE",Area="PROMOCION",Salario=1858.00});
            registros.Add(new Empleado {Rfc="PETT670521", Nombre="PEREZ TORRES MARIA TRINIDAD",Area="PROMOCION",Salario=1851.00});
            registros.Add(new Empleado {Rfc="ROLE771004", Nombre="ERIKA FRANCISCA ROBLES LOPEZ",Area="JUBILADOS",Salario=4691.44});
            registros.Add(new Empleado {Rfc="LERK911214", Nombre="KARELY GUADALUPE LEAL RAMOS",Area="DEPORTE",Salario=1223.66});
            registros.Add(new Empleado {Rfc="BEAY911116", Nombre="YESICA BERUMEN ACOSTA",Area="CULTURA",Salario=6423.66});
            Grabar(registros,"nomina.cvs");
            return registros;
        }

        public static List<Empleado> Leer(string file) {
            using (var  reader = new StreamReader(file))
            using (var cvs = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                cvs.Configuration.HasHeaderRecord=false;
                cvs.Read();
                var records=cvs.GetRecords<Empleado>().ToList();
                return records;
            }
        }

        public static void Grabar(List<Empleado> records, string file) {
             using (var writer = new StreamWriter(file))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }           
        }

    }
}
