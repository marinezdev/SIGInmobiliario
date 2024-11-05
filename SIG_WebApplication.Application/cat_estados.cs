using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class cat_estados
    {
        Data.cat_estados _cat_Estados = new Data.cat_estados();
        public List<Models.cat_estados> Estados_Seleccionar()
        {
            List<Models.cat_estados> cat_Estados = _cat_Estados.Estados_Seleccionar();
            return cat_Estados;
        }
        public List<Models.cat_estados> cat_estados_Seleccionar_Busqueda()
        {
            List<Models.cat_estados> cat_Estados = _cat_Estados.cat_estados_Seleccionar_Busqueda();
            return cat_Estados;
        }
        public Models.cat_estados cat_estados_SelecionarId(string estado)
        {
            Models.cat_estados cat_Estados = _cat_Estados.cat_estados_SelecionarId(estado);
            return cat_Estados;
        }

        public Models.cat_estados cat_estados_Selecionar_Ids(string IdEstado)
        {
            Models.cat_estados cat_Estados = _cat_Estados.cat_estados_Selecionar_Ids(IdEstado);
            return cat_Estados;
        }

        public List<Models.cat_estados> Cat_estados_Selecionar_Editar()
        {
            List<Models.cat_estados> cat_Estados = _cat_Estados.Cat_estados_Selecionar_Editar();
            return cat_Estados;
        }
    
    }
}
