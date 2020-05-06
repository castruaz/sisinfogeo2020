using System;

namespace _26.Interfaz26b
{
    public class Organismo {
        public void Respiracion() {
            Console.WriteLine("Respiración");
        }
        public void Movimiento() {
            Console.WriteLine("Movimiento");
        }
        public void Crecimiento() {
            Console.WriteLine("Crecimiento");
        }
    }

    public interface IAnimales {
        void MultiCelular();
        void SangreCaliente();
    }

    public interface ICanino : IAnimales {
        void Corre();
        void CuatroPatas();
    }

    public interface IPajaro: IAnimales {
        void Vuela();
        void Dospatas();
    }

    public class Perro : Organismo, ICanino
    {
        public void MultiCelular() =>  Console.WriteLine("MultiCelular");
        public void SangreCaliente() =>  Console.WriteLine("Sangre Caliente");
        public void Corre() => Console.WriteLine("Corre");
        public void CuatroPatas() => Console.WriteLine("Cuatro Patas");
    }

    public class Perico : Organismo, IPajaro {
        public void MultiCelular() => Console.WriteLine("Multicelular");
        public void SangreCaliente() => Console.WriteLine("Sangre Caliente");
        public void Vuela() => Console.WriteLine("Vuela");
        public void Dospatas() => Console.WriteLine("Dos Patas");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Perro perro=new Perro();
            Console.WriteLine("\nCaracteristicas del Perro\n");
            perro.Respiracion();
            perro.Movimiento();
            perro.Crecimiento();
            perro.MultiCelular();
            perro.SangreCaliente();
            perro.Corre();
            perro.CuatroPatas();

            Perico perico=new Perico();
            Console.WriteLine("\nCaracteristicas del Perico\n");
            perico.Respiracion();
            perico.Movimiento();
            perico.Crecimiento();
            perico.MultiCelular();
            perico.SangreCaliente();
            perico.Vuela();
            perico.Dospatas();
        }
    }
}
