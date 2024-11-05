using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Comparar
    {
        Data.Comparar _comparar = new Data.Comparar();
        public List<Models.Comparar> Comparar_Seleccionar(string Clave)
        {
            List<Models.Comparar> inmuebles = _comparar.Comparar_Seleccionar(Clave);

            return inmuebles;
        }
    }
}
