using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Personas = new List<Persona>();
            string opcion = "";

            do
            {
                Menu();
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("-----< Personas >-----");

                        Imprimir(Personas);

                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("-----< Ingresar Persona >-----");
                        Console.WriteLine("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Apellido: ");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Documento: ");
                        string documento = Console.ReadLine();
                        Console.WriteLine("Fecha Nacimiento: ");
                        string fecha = Console.ReadLine();

                        Persona aux = new Persona(nombre, apellido, documento, DateTime.Parse(fecha));
                        Personas.Add(aux);

                        Console.WriteLine("Persona Creada");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("-----< Filtrar >-----");
                        Console.WriteLine("Nombre: ");
                        string n = Console.ReadLine();
                        Console.WriteLine("Documento: ");
                        string d = Console.ReadLine();

                        List<Persona> filtrada = Personas.Where(persona => persona.Nombre.StartsWith(n) && persona.Documento.StartsWith(d)).ToList();

                        Imprimir(filtrada);

                        Console.ReadLine();
                        break;

                    default:
                        break;
                }
                Console.Clear();
            } while (opcion != "4");
        }

        private static void Menu()
        {
            Console.WriteLine("-----< PRACTICO 1 >-----");
            Console.WriteLine("1. Listar Personas");
            Console.WriteLine("2. Ingresar Persona");
            Console.WriteLine("3. Filtrar");
            Console.WriteLine("4. Salir");
        }

        private static void Imprimir(List<Persona> Personas)
        {
            if (Personas.Count() > 0)
            {
                Personas.ForEach(persona =>
                    Console.WriteLine("Nombre: " + persona.Nombre + ", Apellido: " + persona.Apellido + ", Documento: " + persona.Documento + ", FechaNacimiento: " + persona.FechaNacimiento.ToString("d") + ", Edad: " + persona.DarEdad())
                );
            }
            else
            {
                Console.WriteLine("No hay personas...");
            }
        }
    }
}
