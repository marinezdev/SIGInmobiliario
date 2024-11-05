using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Mensajes_Inmuebles
    {
        Data.Mensajes_Inmuebles _mensajes_inmuebles = new Data.Mensajes_Inmuebles();

        public Models.Mensajes_Inmuebles Mensajes_Inmuebles_Agregar(Models.Mensajes_Inmuebles mensaje)
        {
            Models.Mensajes_Inmuebles mensajes_ = _mensajes_inmuebles.Mensajes_Inmuebles_Agregar(mensaje);
            return mensajes_;
        }

        public Models.Mensajes_Inmuebles Mensajes_Inmuebles_IdUsuario(int IdUsuario)
        {
            Models.Mensajes_Inmuebles mensajes_ = _mensajes_inmuebles.Mensajes_Inmuebles_IdUsuario(IdUsuario);
            return mensajes_;
        }

        public List<Models.Mensajes_Inmuebles> Mensajes_Inmuebles_Totales(int IdUsuario)
        {
            List<Models.Mensajes_Inmuebles> mensajes_Inmuebles = _mensajes_inmuebles.Mensajes_Inmuebles_Totales(IdUsuario);
            return mensajes_Inmuebles;
        }

        public List<Models.Mensajes_Inmuebles> Mensajes_Inmuebles_IdInmueble(int IdInmueble)
        {
            List<Models.Mensajes_Inmuebles> mensajes_Inmuebles = _mensajes_inmuebles.Mensajes_Inmuebles_IdInmueble(IdInmueble);
            return mensajes_Inmuebles;
        }

        public List<Models.Mensajes_Inmuebles> Mensajes_Inmuebles_Total()
        {
            List<Models.Mensajes_Inmuebles> mensajes_Inmuebles = _mensajes_inmuebles.Mensajes_Inmuebles_Total();
            return mensajes_Inmuebles;
        }

    }
}
