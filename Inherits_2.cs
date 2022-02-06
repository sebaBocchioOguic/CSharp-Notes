using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Auto
    {
        // Atributes
        protected int VelocMax;
        protected string Marca;
        protected string Modelo;

        // Constructor
        public Auto()
        {
            VelocMax = 0;
            Marca = "??";
            Modelo = "??";
        }

        // 2nd Constructor
        public Auto(string marca, string modelo, int velocMax)
        {
            Marca = marca;
            Modelo = modelo;
            VelocMax = velocMax;
        }

        // Show Function
        public virtual void MuestraAuto()
        {
            Console.WriteLine(Marca + " " + Modelo + " (" + VelocMax + " km/h)");
        }

        // Override Function ToString
        public override string ToString()
        {
            return (Marca + " " + Modelo + " (" + VelocMax + " km/h)");
        }

    }// end class Auto
    
    
    // Class Taxi inherits Auto
    public class Taxi:Auto
    {

        // Atributes
        private string CodLicencia;

        // Constructor
        public Taxi(): base() { }

        // 2nd Constructor
        public Taxi(string marca, string modelo, int velocMax, string codLicencia) : base(marca, modelo, velocMax)
        {
            CodLicencia = codLicencia;
        }

        // Property
        public string Licencia { get { return CodLicencia; } }

        // Override Function ToString
        public override string ToString()
        {
            return (base.ToString() + "\n Licencia: " + Licencia);
        }

        // Show Function
        public override void MuestraAuto()
        {
            Console.WriteLine(Marca + " " + Modelo + " (" + VelocMax + " km/h)");
        }

    } // End Class Taxi
    
    
       internal class Program
    {
        static void Main(string[] args)
        {
            // Create Objects Autos
            Auto MiAuto = new Auto("Citroen", "Xsara Picasso", 220);
            Auto MiAuto2 = new Auto("Opel", "Corsa", 190);
            Auto MiAuto3 = new Auto();

            // Muestro Autos
            Console.WriteLine("Mi Auto 1:");
            MiAuto.MuestraAuto();
            Console.WriteLine("Mi Auto 2:");
            MiAuto2.MuestraAuto();
            Console.WriteLine("Mi Auto 3:");
            MiAuto3.MuestraAuto();

            // Create Object Taxi Default
            Taxi MiTaxi = new Taxi();

            // Muestro Taxi
            Console.WriteLine("Mi Taxi 1:" + MiTaxi);
            //MiTaxi.MuestraAuto();


            // Create Object Taxi Defined
            Taxi MiTaxi2 = new Taxi("Citroen", "C5", 250, "GR1234");
            Console.WriteLine("Mi Taxi 2:" + MiTaxi2);
            /*MiTaxi2.MuestraAuto();
            Console.WriteLine("Licencia: {0}", MiTaxi2.Licencia);*/

            // Pause for reading
            Console.ReadKey();


        }
    }
    
}
