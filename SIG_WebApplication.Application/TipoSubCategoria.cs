using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class TipoSubCategoria
    {
        Data.TipoSubCategoria _TipoSubCategoria = new Data.TipoSubCategoria();
        Data.Inmueble _Inmueble = new Data.Inmueble();
        public List<Models.TipoSubCategoria> SubCategoria_Seleccionar(int IdSubCategoria)
        {
            List<Models.TipoSubCategoria> tiposubcategoria = _TipoSubCategoria.TipoSubCategoria_Seleccionar(IdSubCategoria);

            return tiposubcategoria;
        }
        public List<Models.TipoSubCategoria> TipoSubCategoria_Selecionar_Listado()
        {
            List<Models.TipoSubCategoria> tiposubcategoria = _TipoSubCategoria.TipoSubCategoria_Selecionar_Listado();

            return tiposubcategoria;
        }
        public List<Models.TipoSubCategoria> TipoSubCategoria_Seleccionar_Categorias(int IdSubCategoria)
        {
            List<Models.TipoSubCategoria> tiposubcategoria = _TipoSubCategoria.TipoSubCategoria_Seleccionar_Categorias(IdSubCategoria);

            return tiposubcategoria;
        }
        public List<Models.TipoSubCategoria> TipoSubCategoria_Busqueda()
        {
            List<Models.TipoSubCategoria> tiposubcategoria = _TipoSubCategoria.TipoSubCategoria_Busqueda();
            return tiposubcategoria;
        }
        public List<Models.TipoSubCategoria> TipoSubCategoria_Busqueda2()
        {
            List<Models.TipoSubCategoria> tiposubcategoria = _TipoSubCategoria.TipoSubCategoria_Busqueda2();
            return tiposubcategoria;
        }
        public List<Models.TipoSubCategoria> TipoSubCategoria_Inmuebles_Total()
        {
            List<Models.TipoSubCategoria> tiposubcategoria = _TipoSubCategoria.TipoSubCategoria_Inmuebles_Total();
            return tiposubcategoria;

        }
    }
}
