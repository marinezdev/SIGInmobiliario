using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class SubCategoria
    {
        Data.SubCategoria _subCategoria = new Data.SubCategoria();
        public List<Models.SubCategoria> SubCategoria_Seleccionar()
        {
            List<Models.SubCategoria> subCategoria = _subCategoria.SubCategoria_Seleccionar();

            return subCategoria;
        }
        public List<Models.SubCategoria> SubCategoria_Seleccionar_Listar()
        {
            List<Models.SubCategoria> subCategoria = _subCategoria.SubCategoria_Seleccionar_Listar();

            return subCategoria;
        }
        public List<Models.SubCategoria> SubCategoria_Busqueda()
        {
            List<Models.SubCategoria> subCategoria = _subCategoria.SubCategoria_Busqueda();

            return subCategoria;
        }
        public List<Models.SubCategoria> SubCategoria_Seleccionar_Editar()
        {
            List<Models.SubCategoria> subCategoria = _subCategoria.SubCategoria_Seleccionar_Editar();

            return subCategoria;
        }
    }
}
