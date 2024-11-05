using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class cat_poblaciones
    {
        ManejoDatos b = new ManejoDatos();

        public List<Models.cat_poblaciones> Poblacion_Seleccionar(int IdEstado)
        {
            b.ExecuteCommandSP("cat_poblaciones_Selecionar");
            b.AddParameter("@IdEstado", IdEstado, SqlDbType.Int);
            List<Models.cat_poblaciones> resultado = new List<Models.cat_poblaciones>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.cat_poblaciones item = new Models.cat_poblaciones()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Poblacion = reader["Poblacion"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.cat_poblaciones cat_Poblacion_SelecionarId(string poblacion, int IdEstado)
        {
            b.ExecuteCommandSP("cat_poblaciones_selecionarId");
            b.AddParameter("@Poblacion", poblacion, SqlDbType.NVarChar);
            b.AddParameter("@IdEstado", IdEstado, SqlDbType.Int);

            Models.cat_poblaciones resultado = new Models.cat_poblaciones();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
                resultado.Poblacion = reader["Poblacion"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        public Models.cat_poblaciones cat_poblaciones_selecionar_Ids(string poblacion, int IdEstado)
        {
            b.ExecuteCommandSP("cat_poblaciones_selecionar_Ids");
            b.AddParameter("@IdPoblacion", poblacion, SqlDbType.NVarChar);
            b.AddParameter("@IdEstado", IdEstado, SqlDbType.Int);

            Models.cat_poblaciones resultado = new Models.cat_poblaciones();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
                resultado.Poblacion = reader["Poblacion"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
