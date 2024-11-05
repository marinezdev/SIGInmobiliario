using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG_WebApplication.Controllers
{
    public class EmailController : Controller
    {
        [HttpPost]
        public JsonResult LlamarJson(Models.CorreoEmail correoEmail, Application.EnviarCorreo enviarCorreo)
        {
            if (correoEmail != null)
            {
                return Json(enviarCorreo.ProcesaDatos(correoEmail));
            }
            else
            {
                return Json("An Error Has occoured");
            }
        }

        [HttpPost]
        public JsonResult LlamarJsonEmail(Models.CorreoEmail correoEmail, Application.EnviarCorreo enviarCorreo)
        {
            if (correoEmail != null)
            {
                return Json(enviarCorreo.ProcesaDatosEmail(correoEmail));
            }
            else
            {
                return Json("An Error Has occoured");
            }
        }
    }
}
