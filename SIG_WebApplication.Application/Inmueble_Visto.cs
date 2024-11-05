using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Inmueble_Visto
    {
        Data.Inmueble_Visto _inmueble_Visto = new Data.Inmueble_Visto();
        public Models.Inmueble_Visto Inmueble_Visto_Agregar(Models.Inmueble_Visto inmueble_Visto)
        {
            Models.Inmueble_Visto _Visto = _inmueble_Visto.Inmueble_Visto_Agregar(inmueble_Visto);
            return _Visto;
        }

        public Models.Inmueble_Visto Inmueble_Visto_IdUsuario(int IdUsuario)
        {
            Models.Inmueble_Visto _Visto = _inmueble_Visto.Inmueble_Visto_IdUsuario(IdUsuario);
            return _Visto;
        }

        public List<Models.Inmueble_Visto> Inmueble_Visto_Totales(int IdUsuario)
        {
            List<Models.Inmueble_Visto> inmueble_Vistos = _inmueble_Visto.Inmueble_Visto_Totales(IdUsuario);
            return inmueble_Vistos;
        }

        public List<Models.Inmueble_Visto> Inmueble_Visto_Inmueble_Total()
        {
            List<Models.Inmueble_Visto> inmueble_Vistos = _inmueble_Visto.Inmueble_Visto_Inmueble_Total();
            return inmueble_Vistos;
        }
    }
}
 