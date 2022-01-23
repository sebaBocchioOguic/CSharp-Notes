using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{

internal class Persona
    {
        // Creo los atributos de la clase Persona
        private string apellido;
        private string nombre;
        private int dni;
        private int telefono;

        // Constructor de la Clase Persona
        public Persona(string p_apellido, string p_nombre, int p_dni, int p_telefono)
        {
            apellido = p_apellido;
            nombre = p_nombre;
            dni = p_dni;
            telefono = p_telefono;
        }

        // Propiedades
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Telefono
        {
            get { return telefono;}
            set { telefono = value; }
        }
        
    }
    
   
       internal class Alumno:Persona
    {
        // Constructor que invoca al constructor de la Clase Base
        public Alumno(string p_apellido, string p_nombre, int p_dni, int p_telefono): base(p_apellido, p_nombre, p_dni, p_telefono) { }

        // Atributos
        private int curso;
        private int horario;

        //Propiedades
        public int Curso { get { return curso; } set { curso = value; } }
        public int Horario { get { return horario; } set { horario = value; } }

    }
    
        internal class Profesor:Persona
    {

        // Constructor que invoca al constructor de la Clase Base
        public Profesor(string p_apellido, string p_nombre, int p_dni, int p_telefono) : base(p_apellido, p_nombre, p_dni, p_telefono) { }

        // Atributos
        private int curso;
        private int dia;

        // Propiedades
        public int Curso { get { return curso; } set { curso = value; } }
        public int Dia { get { return dia; } set { dia = value; } }

    }
    
        internal class Director:Profesor
    {
        // Constructor que invoca al constructor de la Clase Base
        public Director(string p_apellido, string p_nombre, int p_dni, int p_telefono) : base(p_apellido, p_nombre, p_dni, p_telefono) { }

        private int nroInstituto;

        public int NroInstituto { get { return nroInstituto; } set { nroInstituto = value; } }

    }
    
    


    public class Program
    {
        static void Main(string[] args)
        {
            // Variables Temporales
            string apellidoConsola;
            string nombreConsola;
            int dniConsola;
            int telefonoConsola;
            

            // Inicio el programa
            Console.WriteLine("Comienza el programa");
            Console.WriteLine("********************\n");


            // Ingreso de Datos
            Console.Write("Ingrese el nombre: ");
            nombreConsola = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            apellidoConsola = Console.ReadLine();

            Console.Write("Ingrese el documento: ");
            dniConsola = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el telefono: ");
            telefonoConsola = Convert.ToInt32(Console.ReadLine());

            Alumno alumno1 = new Alumno(apellidoConsola, nombreConsola, dniConsola, telefonoConsola);

            Console.Write($"Se ingresó al Alumno 1: {alumno1.Nombre} {alumno1.Apellido} - Dni {alumno1.Dni} - Telefono {alumno1.Telefono}\n");

            Console.WriteLine("Ingrese el curso para el alumno: ");
            
            alumno1.Curso = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Se ingresó al Alumno {alumno1.Nombre} {alumno1.Apellido} en el curso {alumno1.Curso}");

            Console.ReadKey();


        }
    }
}
