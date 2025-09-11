using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Clases
{
    public class datosJson
    {
        public List<Persona> datos { get; set; }
        public DateTime ultimaActualizacion;
        public int totalRegistros {  get; set; }

        public datosJson() { 
            datos = new List<Persona>();
            ultimaActualizacion = DateTime.Now;
        }
    }
}
