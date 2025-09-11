using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Clases
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string direccion {  get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }

        public Persona() { }

        public Persona(string nombre, string apPat, string apMat, string dir, string tel, string correo)
        {
            this.nombre = nombre;
            this.apPaterno = apPat;
            this.apMaterno = apMat;
            this.direccion = dir;
            this.telefono = tel;
            this.correo = correo;
        }
    }
}
