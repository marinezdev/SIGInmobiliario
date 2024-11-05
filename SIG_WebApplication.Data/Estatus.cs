using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class Estatus
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.Estatus> Estatus_Inmuebles_Totales()
        {
            b.ExecuteCommandSP("Estatus_Inmuebles_Totales");
            List<Models.Estatus> resultado = new List<Models.Estatus>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Estatus item = new Models.Estatus()
                {
                    Total = Convert.ToInt32(reader["Total"].ToString()),
                    Nombre = reader["Nombre"].ToString(),

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
