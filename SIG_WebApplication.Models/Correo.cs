using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class ConsultaCorreo
    {
        public Correo correo { get; set; }
    }
    public class Correo
    {
        public int IdInmueble { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string NombreContacto { get; set; }
        public string Mensaje { get; set; }
    }
}
