using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Auto
    {
        protected double _velocidad = 0;
        private string _marca;
        private string _modelo;
        private string _color;


        public Auto(string marca, string modelo, string color)
        {
            _marca = marca;
            _modelo = modelo;
            _color = color;
        }

        public double Velocidad { get { return _velocidad; } }
        public string Marca { get { return _marca; } set { _marca = value; } }
        public string Modelo { get { return _modelo; } set { _modelo = value; } }
        public string Color { get { return _color; } set { _color = value; } }


        public void Acelerar(double cantidad)
        {
            Console.WriteLine("-- Incrementando velocidad en {0} km/h", cantidad);
            _velocidad += cantidad;
        }

        public void Girar(double cantidad)
        {
            Console.WriteLine("-- Girando {0} grados", cantidad);
        }

        public void Frenar(double cantidad)
        {
            Console.WriteLine("-- Reduciendo velocidad en {0} km/h", cantidad);
            _velocidad -= cantidad;
        }

        public void Estacionar()
        {
            Console.WriteLine("-- Estacionando auto");
            _velocidad = 0;
        }

    }
    
    
     class Program
    {
        static void Main(string[] args)
        {
            Auto MiAuto = new Auto("Renault", "Duster", "Rojo");
            Console.WriteLine("Los datos de mi coche son:");
            Console.WriteLine("   Marca: {0}", MiAuto.Marca);
            Console.WriteLine("   Modelo: {0}", MiAuto.Modelo);
            Console.WriteLine("   Color: {0}", MiAuto.Color);
            Console.WriteLine();


            MiAuto.Acelerar(100);
            Console.WriteLine("La velocidad actual es de {0} km/h", MiAuto.Velocidad);

            MiAuto.Frenar(75);
            Console.WriteLine("La velocidad actual es de {0} km/h", MiAuto.Velocidad);

            MiAuto.Girar(45);

            MiAuto.Estacionar();
            Console.WriteLine("La velocidad actual es de {0} km/h", MiAuto.Velocidad);

            Console.ReadKey();

        }
    }
    
}
