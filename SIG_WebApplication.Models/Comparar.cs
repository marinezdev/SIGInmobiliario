using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class ConsultarComparar
    {
        public Comparar Comparar { get; set; }
    }
    public class Comparar
    {
        public int IdInmueble { get; set; }
        public string FechaRegistrado { get; set; }
        public int Total { get; set; }



        public string TipoCategoria { get; set; }
        public string TipoSubCategoria { get; set; }

        public string PrecioFinalText { get; set; }
        public string PrecioFinal { get; set; }
        public string Superficie { get; set; }
        public string SuperficieT { get; set; }
        public string SuperficieText { get; set; }
        public string SuperficieTText { get; set; }
        public string WC { get; set; }
        public string Estacionamientos { get; set; }
    }
}
