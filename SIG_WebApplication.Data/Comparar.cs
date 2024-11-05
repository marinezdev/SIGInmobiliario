using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class Comparar
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.Comparar> Comparar_Seleccionar(string Clave)
        {
            b.ExecuteCommandSP("Comparar_Seleccionar");
            b.AddParameter("@Clave", Clave, SqlDbType.NVarChar);
            List<Models.Comparar> resultado = new List<Models.Comparar>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Comparar item = new Models.Comparar()
                {
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    TipoSubCategoria = reader["TipoSubCategoria"].ToString(),
                    PrecioFinalText = reader["PrecioFinalText"].ToString(),
                    PrecioFinal = reader["PrecioFinal"].ToString(),
                    Superficie = reader["Superficie"].ToString(),
                    SuperficieT = reader["SuperficieT"].ToString(),
                    SuperficieText = reader["SuperficieText"].ToString(),
                    SuperficieTText = reader["SuperficieTText"].ToString(),
                    WC = reader["WC"].ToString(),
                    Estacionamientos = reader["Estacionamientos"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
