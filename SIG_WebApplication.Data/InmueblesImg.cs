using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class InmueblesImg
    {
        ManejoDatos b = new ManejoDatos();
        public int Agregar(Models.InmueblesImg inmueblesImg)
        {
            b.ExecuteCommandSP("InmueblesImg_Agregar");
            b.AddParameter("@IdInmueble", inmueblesImg.IdInmueble, SqlDbType.Int);
            b.AddParameter("@IdArchivo", inmueblesImg.IdArchivo, SqlDbType.Int);
            b.AddParameter("@NmArchivo", inmueblesImg.NmArchivo, SqlDbType.NVarChar);
            b.AddParameter("@NmOriginal", inmueblesImg.NmOriginal, SqlDbType.NVarChar);
            b.AddParameter("@Descripcion", inmueblesImg.Descripcion, SqlDbType.NVarChar);

            return b.InsertUpdateDeleteWithTransaction();
        }
        public Models.InmueblesImg InmueblesImg_Seleccionar_IdInmueble(int IdInmueble)
        {
            b.ExecuteCommandSP("InmueblesImg_Seleccionar_IdInmueble");
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);

            Models.InmueblesImg resultado = new Models.InmueblesImg();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Descripcion = reader["Descripcion"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.InmueblesImg> InmueblesImgs_Seleccionar_IdInmueble(int IdInmueble)
        {
            b.ExecuteCommandSP("InmueblesImgs_Seleccionar_IdInmueble");
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);
            List<Models.InmueblesImg> resultado = new List<Models.InmueblesImg>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.InmueblesImg item = new Models.InmueblesImg()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    IdArchivo = Convert.ToInt32(reader["IdArchivo"].ToString()),
                    IdInmueble = Convert.ToInt32(reader["IdInmueble"].ToString()),
                    Descripcion = reader["Descripcion"].ToString(),
                    NmArchivo = reader["NmArchivo"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensaje InmueblesImg_Desactivar(int IdArchivo)
        {
            b.ExecuteCommandSP("InmueblesImg_Desactivar");
            b.AddParameter("@IdArchivo", IdArchivo, SqlDbType.Int);

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
        public Models.Mensaje InmueblesImg_cambiarOrden(int IdArchivo1, int IdArchivo2)
        {
            b.ExecuteCommandSP("InmueblesImg_cambiarOrden");
            b.AddParameter("@IdArchivo1", IdArchivo1, SqlDbType.Int);
            b.AddParameter("@IdArchivo2", IdArchivo2, SqlDbType.Int);

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
    }
}
