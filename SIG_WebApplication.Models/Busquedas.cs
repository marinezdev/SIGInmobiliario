using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class BusquedaConsultar
    {
        public Busquedas Busquedas { get; set; }
    }

    public class Busquedas
    {
        public string tipSubBus { get; set; }
        public string DirecionesBusqueda { get; set; }
    
        public string TipoSubCategoria { get; set; }
        public string Direccion { get; set; }

        public string Estado { get; set; }
        public string Poblacion { get; set; }
        public string CP { get; set; }
        public string Colonia { get; set; }

        public string TipoOperacion { get; set; }
        public string wc { get; set; }

        public string Esta { get; set; }
    }
}
