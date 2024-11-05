using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Pregunta
    {

        Data.Pregunta _Pregunta = new Data.Pregunta();
        public Models.Mensaje Preguntas_Agregar(Models.Pregunta pregunta)
        {
            Models.Pregunta NPregunta = _Pregunta.Preguntas_Agregar(pregunta);
            Models.Mensaje mensaje = new Models.Mensaje();

            if (NPregunta.Id != 0)
            {
                mensaje.Respuesta = true;
                mensaje.Contenido = "Tu pregunta a sido registrada, a la brevedad será respondida ";
            }
            else
            {
                mensaje.Respuesta = false;
                mensaje.Contenido = "Problemas al realizar tu registro, inténtelo más tarde.";
            }

            return mensaje;
        }

        public List<Models.Pregunta> Preguntas_Listar()
        {
            List<Models.Pregunta> pregunta = _Pregunta.Preguntas_Listar();
            return pregunta;
        }

    }
}
