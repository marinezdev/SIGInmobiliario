using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class ConsultaColonias
    {
        public cat_colonias cat_colonias { get; set; }
    }
    public class cat_colonias
    {
        public int Id { get; set; }
        public int IdCP { get; set; }
        public string Colonia { get; set; }
    }
}
