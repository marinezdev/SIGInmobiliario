using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class cat_colonias
    {
        ManejoDatos b = new ManejoDatos();

        public List<Models.cat_colonias> cat_colonias_Seleccionar(int IdCP)
        {
            b.ExecuteCommandSP("cat_colonias_seleccionar");
            b.AddParameter("@IdCP", IdCP, SqlDbType.Int);
            List<Models.cat_colonias> resultado = new List<Models.cat_colonias>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.cat_colonias item = new Models.cat_colonias()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Colonia = reader["Colonia"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.cat_colonias> Cat_Colonias_Selecionar_Poblacion(int IdPoblacion)
        {
            b.ExecuteCommandSP("Cat_Colonias_Selecionar_Poblacion");
            b.AddParameter("@IdPoblacion", IdPoblacion, SqlDbType.Int);
            List<Models.cat_colonias> resultado = new List<Models.cat_colonias>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.cat_colonias item = new Models.cat_colonias()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Colonia = reader["Colonia"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.cat_colonias Cat_Colonias_SelecionarId(string Colonia, string CP, int IdPoblacion)
        {
            b.ExecuteCommandSP("Cat_Colonias_SelecionarId");
            b.AddParameter("@Colonia", Colonia, SqlDbType.NVarChar);
            b.AddParameter("@CP", CP, SqlDbType.NVarChar);
            b.AddParameter("@IdPoblacion", IdPoblacion, SqlDbType.Int);

            Models.cat_colonias resultado = new Models.cat_colonias();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
                resultado.Colonia = reader["Colonia"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.cat_colonias Cat_Colonias_Selecionar_Ids(string IdColonia)
        {
            b.ExecuteCommandSP("Cat_Colonias_Selecionar_Ids");
            b.AddParameter("@IdColonia", IdColonia, SqlDbType.NVarChar);

            Models.cat_colonias resultado = new Models.cat_colonias();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
                resultado.Colonia = reader["Colonia"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
