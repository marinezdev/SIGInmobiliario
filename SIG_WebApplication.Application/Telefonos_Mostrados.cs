using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Telefonos_Mostrados
    {
        Data.Telefonos_Mostrados _Telefonos_Mostrados = new Data.Telefonos_Mostrados();
        public Models.Inmueble Telefonos_Mostrados_Agregar(int IdInmueble, int IdUsuario)
        {
            Models.Inmueble inmueble = _Telefonos_Mostrados.Telefonos_Mostrados_Agregar(IdInmueble, IdUsuario);
            return inmueble;
        }
        public Models.Telefonos_Mostrados Telefonos_Mostrados_IdUsuario(int IdUsuario)
        {
            Models.Telefonos_Mostrados telefonos_Mostrados = _Telefonos_Mostrados.Telefonos_Mostrados_IdUsuario(IdUsuario);
            return telefonos_Mostrados;
        }
        public List<Models.Telefonos_Mostrados> Telefonos_Mostrados_Totales(int IdUsuario)
        {
            List<Models.Telefonos_Mostrados> telefonos_Mostrados = _Telefonos_Mostrados.Telefonos_Mostrados_Totales(IdUsuario);
            return telefonos_Mostrados;
        }
    }

}
