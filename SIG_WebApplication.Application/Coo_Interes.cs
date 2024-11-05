using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Coo_Interes
    {
        Data.Coo_Interes _coo_Interes = new Data.Coo_Interes();
        public Models.Coo_Interes coo_Interes_Registrar()
        {
            Models.Coo_Interes clave = _coo_Interes.coo_Interes_Registrar();
            return clave;
        }
        public Models.Mensaje Interes_Registrar_Inmueble(string Clave, int IdInmueble)
        {
            Models.Mensaje mensaje = _coo_Interes.Interes_Registrar_Inmueble(Clave, IdInmueble);
            return mensaje;
        }
        public Models.Interes Interes_Consultar_Total(string Clave)
        {
            Models.Interes InteresV = _coo_Interes.Interes_Consultar_Total(Clave);
            return InteresV;
        }
        public List<Models.Inmueble> Interes_Selecionar_Inmuebles(string Clave)
        {
            List<Models.Inmueble> inmuebles = _coo_Interes.Interes_Selecionar_Inmuebles(Clave);
            
            return inmuebles;
        }
        public Models.Mensaje Interes_Desactivar(string Clave, int IdInmueble)
        {
            Models.Mensaje mensaje = _coo_Interes.Interes_Desactivar(Clave, IdInmueble);
            return mensaje;
        }
    }
}
