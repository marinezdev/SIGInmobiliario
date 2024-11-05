using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Comentarios
    {
        Data.Comentarios _comentarios = new Data.Comentarios();
        public List<Models.Comentarios> Comentarios_Selecionar_IdInmueble(int IdUsuario)
        {
            List<Models.Comentarios> ListaComentarios = _comentarios.Comentarios_Selecionar_IdInmueble(IdUsuario);
            return ListaComentarios;
        }
    }
}
