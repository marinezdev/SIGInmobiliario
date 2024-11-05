using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class ConsultaCP
    {
        public cat_cp cat_cp { get; set; }
    }
    public class cat_cp
    {
        public int Id { get; set; }
        public int IdPoblacion { get; set; }
        public string CP { get; set; }
    }
}
