using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class cat_colonias
    {
        Data.cat_colonias _cat_colonias = new Data.cat_colonias();
        public List<Models.cat_colonias> cat_colonias_Seleccionar(int IdCP)
        {
            List<Models.cat_colonias> cat_Colonias = _cat_colonias.cat_colonias_Seleccionar(IdCP);
            return cat_Colonias;
        }
        public List<Models.cat_colonias> Cat_Colonias_Selecionar_Poblacion(int IdPoblacion)
        {
            List<Models.cat_colonias> cat_Colonias = _cat_colonias.Cat_Colonias_Selecionar_Poblacion(IdPoblacion);
            return cat_Colonias;
        }

        public Models.cat_colonias Cat_Colonias_SelecionarId(string Colonia, string CP, int IdPoblacion)
        {
            Models.cat_colonias cat_Colonias = _cat_colonias.Cat_Colonias_SelecionarId(Colonia, CP, IdPoblacion);
            return cat_Colonias;
        }

        public Models.cat_colonias Cat_Colonias_Selecionar_Ids(string IdColonia)
        {
            Models.cat_colonias cat_Colonias = _cat_colonias.Cat_Colonias_Selecionar_Ids(IdColonia);
            return cat_Colonias;
        }
    }
}
