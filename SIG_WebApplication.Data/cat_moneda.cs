using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class cat_moneda
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.cat_moneda> cat_moneda_seleccionar()
        {
            b.ExecuteCommandSP("cat_moneda_seleccionar");
            List<Models.cat_moneda> resultado = new List<Models.cat_moneda>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.cat_moneda item = new Models.cat_moneda()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
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
