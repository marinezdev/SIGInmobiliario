using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class InmueblesImg
    {
        Data.InmueblesImg _inmueblesImg = new Data.InmueblesImg();
        public Models.InmueblesImg Nuevo_InmuebleInicia(int IdInmueble)
        {
            Models.InmueblesImg inmueblesImg = _inmueblesImg.InmueblesImg_Seleccionar_IdInmueble(IdInmueble);

            return inmueblesImg;
        }
        public List<Models.InmueblesImg> InmueblesImgs_Seleccionar_IdInmueble(int IdInmueble)
        {
            List<Models.InmueblesImg> inmueblesImgs = _inmueblesImg.InmueblesImgs_Seleccionar_IdInmueble(IdInmueble);
            return inmueblesImgs;
        }
        public Models.Mensaje InmueblesImg_Desactivar(int IdArchivo)
        {
            Models.Mensaje mensaje = _inmueblesImg.InmueblesImg_Desactivar(IdArchivo);
            return mensaje;
        }
        public Models.Mensaje InmueblesImg_cambiarOrden(int IdArchivo1, int IdArchivo2)
        {
            Models.Mensaje mensaje = _inmueblesImg.InmueblesImg_cambiarOrden(IdArchivo1, IdArchivo2);
            return mensaje;
        }
        public int Agregar(Models.InmueblesImg inmueblesImg)
        {
            int resultado = _inmueblesImg.Agregar(inmueblesImg);
            return resultado;
        }
    }
}
