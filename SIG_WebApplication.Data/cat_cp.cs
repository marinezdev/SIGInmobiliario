using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class cat_cp
    {
        ManejoDatos b = new ManejoDatos();

        public List<Models.cat_cp> CP_Seleccionar(int IdPoblacion)
        {
            b.ExecuteCommandSP("cat_cp_Seleccionar");
            b.AddParameter("@IdPoblacion", IdPoblacion, SqlDbType.Int);
            List<Models.cat_cp> resultado = new List<Models.cat_cp>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.cat_cp item = new Models.cat_cp()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    CP = reader["CP"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
