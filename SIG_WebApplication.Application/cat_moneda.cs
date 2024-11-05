using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class cat_moneda
    {
        Data.cat_moneda _cat_moneda = new Data.cat_moneda();
        public List<Models.cat_moneda> cat_moneda_seleccionar()
        {
            List<Models.cat_moneda> cat_Monedas = _cat_moneda.cat_moneda_seleccionar();

            return cat_Monedas;
        }
    }
}
