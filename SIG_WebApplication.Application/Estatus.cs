using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Estatus
    {
        Data.Estatus _Estatus = new Data.Estatus();
        public List<Models.Estatus> Estatus_Inmuebles_Totales()
        {
            List<Models.Estatus> estatuses = _Estatus.Estatus_Inmuebles_Totales();
            
            return estatuses;
        }
    }
}
