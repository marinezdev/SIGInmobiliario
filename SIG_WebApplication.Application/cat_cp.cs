using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class cat_cp
    {
        Data.cat_cp _cat_cp = new Data.cat_cp();
        public List<Models.cat_cp> CP_Seleccionar(int IdPoblacion)
        {
            List<Models.cat_cp> cat_cp = _cat_cp.CP_Seleccionar(IdPoblacion);
            return cat_cp;
        }
    }
}
