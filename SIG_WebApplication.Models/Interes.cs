using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class ConsultarInteres
    {
        public Interes Interes { get; set; }
    }
    public class Interes
    {
        public int IdInmueble { get; set; }
        public string FechaRegistrado { get; set; }
        public int Total { get; set; }
    }
}
