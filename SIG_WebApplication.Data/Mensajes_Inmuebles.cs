using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class Mensajes_Inmuebles
    {
        ManejoDatos b = new ManejoDatos();

        public Models.Mensajes_Inmuebles Mensajes_Inmuebles_Agregar(Models.Mensajes_Inmuebles mensaje)
        {
            b.ExecuteCommandSP("Mensajes_Inmuebles_Agregar");
            b.AddParameter("@IdInmueble", mensaje.IdInmueble, SqlDbType.Int);
            b.AddParameter("@IdUsuario", mensaje.IdUsuario, SqlDbType.Int);
            b.AddParameter("@Email", mensaje.Email, SqlDbType.NVarChar);
            b.AddParameter("@Nombre", mensaje.Nombre, SqlDbType.NVarChar);
            b.AddParameter("@Telefono", mensaje.Telefono, SqlDbType.NVarChar);
            b.AddParameter("@Mensaje", mensaje.Mensajes, SqlDbType.NVarChar);
            b.AddParameter("@Asunto", mensaje.Asunto, SqlDbType.NVarChar);

            Models.Mensajes_Inmuebles resultado = new Models.Mensajes_Inmuebles();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensajes_Inmuebles Mensajes_Inmuebles_IdUsuario(int IdUsuario)
        {
            b.ExecuteCommandSP("Mensajes_Inmuebles_IdUsuario");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);

            Models.Mensajes_Inmuebles resultado = new Models.Mensajes_Inmuebles();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Num = Convert.ToInt32(reader["Num"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Mensajes_Inmuebles> Mensajes_Inmuebles_Totales(int IdUsuario)
        {
            b.ExecuteCommandSP("Mensajes_Inmuebles_Totales");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            List<Models.Mensajes_Inmuebles> resultado = new List<Models.Mensajes_Inmuebles>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Mensajes_Inmuebles item = new Models.Mensajes_Inmuebles()
                {
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    TipoSubCategoria = reader["TipoSubCategoria"].ToString(),
                    PrecioFinalText = reader["PrecioFinalText"].ToString(),
                    Titulo = reader["Titulo"].ToString(),
                    Total = Convert.ToInt32(reader["Total"].ToString()),
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Mensajes_Inmuebles> Mensajes_Inmuebles_IdInmueble(int IdInmueble)
        {
            b.ExecuteCommandSP("Mensajes_Inmuebles_IdInmueble");
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);
            List<Models.Mensajes_Inmuebles> resultado = new List<Models.Mensajes_Inmuebles>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Mensajes_Inmuebles item = new Models.Mensajes_Inmuebles()
                {
                    Nombre = reader["Nombre"].ToString(),
                    Email = reader["Email"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Mensajes = reader["Mensajes"].ToString(),
                    Asunto = reader["Asunto"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Mensajes_Inmuebles> Mensajes_Inmuebles_Total()
        {
            b.ExecuteCommandSP("Mensajes_Inmuebles_Total");
            List<Models.Mensajes_Inmuebles> resultado = new List<Models.Mensajes_Inmuebles>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Mensajes_Inmuebles item = new Models.Mensajes_Inmuebles()
                {
                    Nombre = reader["Nombre"].ToString(),
                    Total = Convert.ToInt32(reader["Total"].ToString()),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}
