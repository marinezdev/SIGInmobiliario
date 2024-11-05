using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class Comentarios
    {
        public int Id { get; set; }
        public int IdInmueble { get; set; }
        public int IdUsuario { get; set; }
        public int Estrellas { get; set; }
        public string Comentario { get; set; }
        public string Nombre { get; set; }
    }
}
