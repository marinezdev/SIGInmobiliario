using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class Mensajes_Inmuebles
    {
        public int Id { get; set; }
        public int IdInmueble { get; set; }
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mensajes { get; set; }
        public string Asunto { get; set; }
        public int Num { get; set; }

        public string TipoCategoria { get; set; }
        public string TipoSubCategoria { get; set; }
        public string PrecioFinalText { get; set; }
        public string Titulo { get; set; }
        public int Total { get; set; }

    }
}
