using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class ConsultaTipoSubCategoria
    {
        public TipoSubCategoria tipoSubCategoria { get; set; }
    }
    public class TipoSubCategoria
    {
        public int Id { get; set; }
        public int IdSubCategoria { get; set; }
        public string Nombre { get; set; }

        public int Total { get; set; }
    }
}
