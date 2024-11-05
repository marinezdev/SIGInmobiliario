using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class ConsultarPreguntas
    {
        public Pregunta pregunta { get; set; }
    }
    public class Pregunta
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string pregunta { get; set; }
        public string respuesta { get; set; }
    }
}
