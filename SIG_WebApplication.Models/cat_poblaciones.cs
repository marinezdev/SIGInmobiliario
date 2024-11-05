using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class ConsultaPoblaciones
    {
        public cat_poblaciones cat_Poblaciones { get; set; }
    }
    public class cat_poblaciones
    {
        public int Id { get; set; }
        public int IdEstado { get; set; }
        public string Poblacion { get; set; }

    }
}
