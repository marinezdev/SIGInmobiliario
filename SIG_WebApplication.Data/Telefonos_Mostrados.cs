using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class Telefonos_Mostrados
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Inmueble Telefonos_Mostrados_Agregar(int IdInmueble, int IdUsuario)
        {
            b.ExecuteCommandSP("Telefonos_Mostrados_Agregar");
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            Models.Inmueble resultado = new Models.Inmueble();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Telefono = reader["Telefono"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Telefonos_Mostrados Telefonos_Mostrados_IdUsuario(int IdUsuario)
        {
            b.ExecuteCommandSP("Telefonos_Mostrados_IdUsuario");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            Models.Telefonos_Mostrados resultado = new Models.Telefonos_Mostrados();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Num = Convert.ToInt32(reader["Num"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Telefonos_Mostrados> Telefonos_Mostrados_Totales(int IdUsuario)
        {
            b.ExecuteCommandSP("Telefonos_Mostrados_Totales");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            List<Models.Telefonos_Mostrados> resultado = new List<Models.Telefonos_Mostrados>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Telefonos_Mostrados item = new Models.Telefonos_Mostrados()
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
        
    }
}
