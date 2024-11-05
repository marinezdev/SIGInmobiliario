using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class UnidadMedida
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.UnidadMedida> UnidadMedida_Seleccionar_Listado()
        {
            b.ExecuteCommandSP("UnidadMedida_Seleccionar_Listado");
            List<Models.UnidadMedida> resultado = new List<Models.UnidadMedida>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.UnidadMedida item = new Models.UnidadMedida()
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
