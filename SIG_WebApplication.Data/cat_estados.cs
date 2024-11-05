using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class cat_estados
    {
        ManejoDatos b = new ManejoDatos();

        public List<Models.cat_estados> Estados_Seleccionar()
        {
            b.ExecuteCommandSP("Cat_estados_Selecionar");
            
            List<Models.cat_estados> resultado = new List<Models.cat_estados>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.cat_estados item = new Models.cat_estados()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Estado = reader["Estado"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.cat_estados> cat_estados_Seleccionar_Busqueda()
        {
            b.ExecuteCommandSP("cat_estados_Seleccionar_Busqueda");

            List<Models.cat_estados> resultado = new List<Models.cat_estados>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.cat_estados item = new Models.cat_estados()
                {
                    Direccion = reader["Direccion"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.cat_estados cat_estados_SelecionarId(string estado)
        {
            b.ExecuteCommandSP("cat_estados_SelecionarId");
            b.AddParameter("@Estado", estado, SqlDbType.NVarChar);

            Models.cat_estados resultado = new Models.cat_estados();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
                resultado.Estado = reader["Estado"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.cat_estados cat_estados_Selecionar_Ids(string IdEstado)
        {
            b.ExecuteCommandSP("cat_estados_Selecionar_Ids");
            b.AddParameter("@IdEstado", IdEstado, SqlDbType.NVarChar);

            Models.cat_estados resultado = new Models.cat_estados();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
                resultado.Estado = reader["Estado"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.cat_estados> Cat_estados_Selecionar_Editar()
        {
            b.ExecuteCommandSP("Cat_estados_Selecionar_Editar");

            List<Models.cat_estados> resultado = new List<Models.cat_estados>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.cat_estados item = new Models.cat_estados()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Estado = reader["Estado"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
