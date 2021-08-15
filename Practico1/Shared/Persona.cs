using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // Constructor
        public Persona(string _Nombre, string _Apellido, string _Documento, DateTime _FechaNacimiento)
        {
            this.Nombre = _Nombre;
            this.Apellido = _Apellido;
            this.Documento = _Documento;
            this.FechaNacimiento = _FechaNacimiento;
        }

        public int DarEdad()
        {
            if (DateTime.Now.Month > this.FechaNacimiento.Month || (DateTime.Now.Month == this.FechaNacimiento.Month && DateTime.Now.Day > this.FechaNacimiento.Day))
            {
                return DateTime.Now.Year - this.FechaNacimiento.Year;
            }

            return DateTime.Now.Year - this.FechaNacimiento.Year - 1;
        }
    }
}
