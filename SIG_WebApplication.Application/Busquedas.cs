using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Busquedas
    {
        public string BusquedaIndeX(Models.Busquedas busquedas)
        {
            Models.Busquedas busquedas1 = new Models.Busquedas();
            busquedas1.tipSubBus = Application.UrlCifrardo.Encrypt(busquedas.tipSubBus);
            string variables = "";
            try
            {
                busquedas1.tipSubBus = Application.UrlCifrardo.Encrypt(busquedas.tipSubBus);
                busquedas1.DirecionesBusqueda = Application.UrlCifrardo.Encrypt(busquedas.DirecionesBusqueda);
            }
            catch
            {
                busquedas1.tipSubBus = Application.UrlCifrardo.Encrypt(busquedas.tipSubBus);
            }


            variables = "?ti="+busquedas1.tipSubBus+"&dir="+ busquedas1.DirecionesBusqueda;

            return variables;
        }
    }
}
