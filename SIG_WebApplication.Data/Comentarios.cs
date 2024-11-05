using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class Comentarios
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.Comentarios> Comentarios_Selecionar_IdInmueble(int IdInmueble)
        {
            b.ExecuteCommandSP("Comentarios_Selecionar_IdInmueble");
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);
            List<Models.Comentarios> resultado = new List<Models.Comentarios>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Comentarios item = new Models.Comentarios()
                {
                    Comentario = reader["Comentario"].ToString(),
                    Nombre = reader["Nombre"].ToString()
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
