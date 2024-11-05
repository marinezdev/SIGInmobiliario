using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class NuevoInmueblesImg
    {
        public InmueblesImg InmueblesImg { get; set; }
    }

    public class InmueblesImg
    {
        public int Id { get; set; }
        public int IdInmueble { get; set; }
        public int IdArchivo { get; set; }
        public string NmArchivo { get; set; }
        public string NmOriginal { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public int Activo { get; set; }
        public int Rechazos { get; set; }
    }
}
