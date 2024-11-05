using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class cat_poblaciones
    {
        Data.cat_poblaciones _cat_poblaciones = new Data.cat_poblaciones();
        public List<Models.cat_poblaciones> Poblacion_Seleccionar(int IdEstdo)
        {
            List<Models.cat_poblaciones> cat_Poblaciones = _cat_poblaciones.Poblacion_Seleccionar(IdEstdo);
            return cat_Poblaciones;
        }
        public Models.cat_poblaciones cat_Poblacion_SelecionarId(string poblacion, int IdEstado)
        {
            Models.cat_poblaciones poblaciones = _cat_poblaciones.cat_Poblacion_SelecionarId(poblacion, IdEstado);
            return poblaciones;
        }

        public Models.cat_poblaciones cat_poblaciones_selecionar_Ids(string poblacion, int IdEstado)
        {
            Models.cat_poblaciones poblaciones = _cat_poblaciones.cat_poblaciones_selecionar_Ids(poblacion, IdEstado);
            return poblaciones;
        }
    }
}
