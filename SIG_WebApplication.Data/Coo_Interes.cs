using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class Coo_Interes
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Coo_Interes coo_Interes_Registrar()
        {
            b.ExecuteCommandSP("coo_Interes_Registrar");
            Models.Coo_Interes resultado = new Models.Coo_Interes();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Clave = reader["Clave"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Mensaje Interes_Registrar_Inmueble(string Clave, int IdInmueble)
        {
            b.ExecuteCommandSP("Interes_Registrar_Inmueble");
            b.AddParameter("@Clave", Clave, SqlDbType.NVarChar);
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);
            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Respuesta = Convert.ToBoolean( Convert.ToInt32(reader["Respuesta"].ToString()));
                resultado.RespuestaText = reader["RespuestaText"].ToString();
                resultado.Contenido = reader["Contenido"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Interes Interes_Consultar_Total(string Clave)
        {
            b.ExecuteCommandSP("Interes_Consultar_Total");
            b.AddParameter("@Clave", Clave, SqlDbType.NVarChar);
            Models.Interes resultado = new Models.Interes();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Total = Convert.ToInt32(reader["Total"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;

        }

        public Models.Mensaje Interes_Desactivar(string Clave, int IdInmueble)
        {
            b.ExecuteCommandSP("Interes_Desactivar");
            b.AddParameter("@Clave", Clave, SqlDbType.NVarChar);
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);
            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Respuesta = Convert.ToBoolean(Convert.ToInt32(reader["Respuesta"].ToString()));
                resultado.RespuestaText = reader["RespuestaText"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;

        }

        public List<Models.Inmueble> Interes_Selecionar_Inmuebles(string Clave)
        {
            b.ExecuteCommandSP("Interes_Selecionar_Inmuebles");
            b.AddParameter("@Clave", Clave, SqlDbType.NVarChar);
            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    FechaRegistro = reader["FechaRegistro"].ToString(),
                    Mes = reader["Mes"].ToString(),
                    Dia = Convert.ToInt32(reader["Dia"].ToString()),
                    Titulo = reader["Titulo"].ToString(),
                    Descripcion = reader["Descripcion"].ToString(),
                    Tiempo = reader["Tiempo"].ToString(),
                    NombreEstatus = reader["NombreEstatus"].ToString(),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    SubCategoria = reader["SubCategoria"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Poblacion = reader["Poblacion"].ToString(),
                    Imagen = "http://" + reader["Imagen"].ToString(),

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}
