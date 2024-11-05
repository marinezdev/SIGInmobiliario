using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Coo_Comparar
    {
        Data.Coo_Comparar _coo_Comparar = new Data.Coo_Comparar();
        public Models.Coo_Comparar coo_Comparar_Registrar()
        {
            Models.Coo_Comparar clave = _coo_Comparar.coo_Comparar_Registrar();
            return clave;
        }
        public Models.Mensaje Comparar_Registrar_Inmueble(string Clave, int IdInmueble)
        {
            Models.Mensaje mensaje = _coo_Comparar.Comparar_Registrar_Inmueble(Clave, IdInmueble);
            return mensaje;
        }
        public Models.Comparar Comparar_Consultar_Total(string Clave)
        {
            Models.Comparar InteresV = _coo_Comparar.Comparar_Consultar_Total(Clave);
            return InteresV;
        }
        public List<Models.Inmueble> Comparar_Selecionar_Inmuebles(string Clave)
        {
            List<Models.Inmueble> inmuebles = _coo_Comparar.Comparar_Selecionar_Inmuebles(Clave);

            return inmuebles;
        }
        public Models.Mensaje Comparar_Desactivar(string Clave, int IdInmueble)
        {
            Models.Mensaje mensaje = _coo_Comparar.Comparar_Desactivar(Clave, IdInmueble);
            return mensaje;
        }
    }
}
