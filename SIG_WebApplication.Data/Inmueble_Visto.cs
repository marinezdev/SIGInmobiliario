using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class Inmueble_Visto
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Inmueble_Visto Inmueble_Visto_Agregar(Models.Inmueble_Visto inmueble_Visto)
        {
            b.ExecuteCommandSP("Inmueble_Visto_Agregar");
            b.AddParameter("@IdInmueble", inmueble_Visto.IdInmueble, SqlDbType.Int);
            b.AddParameter("@IdUsuario", inmueble_Visto.IdUsuario, SqlDbType.Int);

            Models.Inmueble_Visto resultado = new Models.Inmueble_Visto();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Inmueble_Visto Inmueble_Visto_IdUsuario(int IdUsuario)
        {
            b.ExecuteCommandSP("Inmueble_Visto_IdUsuario");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);

            Models.Inmueble_Visto resultado = new Models.Inmueble_Visto();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Num = Convert.ToInt32(reader["Num"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble_Visto> Inmueble_Visto_Totales(int IdUsuario)
        {
            b.ExecuteCommandSP("Inmueble_Visto_Totales");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            List<Models.Inmueble_Visto> resultado = new List<Models.Inmueble_Visto>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble_Visto item = new Models.Inmueble_Visto()
                {
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    TipoSubCategoria = reader["TipoSubCategoria"].ToString(),
                    PrecioFinalText = reader["PrecioFinalText"].ToString(),
                    Titulo = reader["Titulo"].ToString(),
                    Total = Convert.ToInt32(reader["Total"].ToString()),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Inmueble_Visto> Inmueble_Visto_Inmueble_Total()
        {
            b.ExecuteCommandSP("Inmueble_Visto_Inmueble_Total");
            List<Models.Inmueble_Visto> resultado = new List<Models.Inmueble_Visto>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble_Visto item = new Models.Inmueble_Visto()
                {
                    Nombre =  reader["Nombre"].ToString(),
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
