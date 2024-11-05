using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class Pregunta
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Pregunta Preguntas_Agregar(Models.Pregunta pregunta)
        {
            b.ExecuteCommandSP("Preguntas_Agregar");
            b.AddParameter("@nombre", pregunta.nombre, SqlDbType.NVarChar);
            b.AddParameter("@email", pregunta.email, SqlDbType.NVarChar);
            b.AddParameter("@pregunta", pregunta.pregunta, SqlDbType.NVarChar);

            Models.Pregunta resultado = new Models.Pregunta();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Pregunta> Preguntas_Listar()
        {
            b.ExecuteCommandSP("Preguntas_Listar");
            List<Models.Pregunta> resultado = new List<Models.Pregunta>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Pregunta item = new Models.Pregunta()
                {
                    pregunta = reader["Pregunta"].ToString(),
                    respuesta = reader["Respuesta"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
