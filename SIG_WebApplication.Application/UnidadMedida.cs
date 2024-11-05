using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class UnidadMedida
    {
        Data.UnidadMedida _unidadMedida = new Data.UnidadMedida();
        public List<Models.UnidadMedida> UnidadMedida_Seleccionar_Listado()
        {
            List<Models.UnidadMedida> unidadMedida = _unidadMedida.UnidadMedida_Seleccionar_Listado();

            return unidadMedida;
        }
    }
}
