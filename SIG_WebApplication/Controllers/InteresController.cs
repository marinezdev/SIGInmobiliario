using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG_WebApplication.Controllers
{
    public class InteresController : Controller
    {
        // GET: Interes
        public ActionResult Index(Application.Coo_Interes coo_Interes)
        {
            List<Models.Inmueble> inmuebles = new List<Models.Inmueble>();
            string dt = "";

            if (Request.Cookies["Intereses"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Intereses"].Value.ToString());
                inmuebles = coo_Interes.Interes_Selecionar_Inmuebles(dt);
            }

            ViewBag.Total = inmuebles.Count;

            ViewBag.Inmuebles = inmuebles;
            return View();
        }
        public ActionResult Interes(Application.Coo_Interes coo_Interes)
        {
            List<Models.Inmueble> inmuebles = new List<Models.Inmueble>();
            string dt = "";

            if (Request.Cookies["Intereses"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Intereses"].Value.ToString());
                inmuebles = coo_Interes.Interes_Selecionar_Inmuebles(dt);
            }

            ViewBag.Inmuebles = inmuebles;
            return View();
        }
        public JsonResult AgregarInteres(Models.ConsultarInteres consultarInteres, Application.Coo_Interes coo_Interes)
        {
            Models.Mensaje mensaje = new Models.Mensaje();

            string dt = ""; 
            if (Request.Cookies["Intereses"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Intereses"].Value.ToString());
                mensaje = coo_Interes.Interes_Registrar_Inmueble(dt, consultarInteres.Interes.IdInmueble);
            }
            else
            {
                Models.Coo_Interes coo_Interes1 = coo_Interes.coo_Interes_Registrar();
                Response.Cookies["Intereses"].Value = Application.UrlCifrardo.Encrypt(coo_Interes1.Clave);
                mensaje = coo_Interes.Interes_Registrar_Inmueble(coo_Interes1.Clave, consultarInteres.Interes.IdInmueble);
            }

            return Json(mensaje);
        }
        public JsonResult Interes_Consultar(Application.Coo_Interes coo_Interes)
        {
            Models.Interes inter = new Models.Interes();

            string dt = "";
            inter.Total = 0;
            if (Request.Cookies["Intereses"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Intereses"].Value.ToString());
                inter = coo_Interes.Interes_Consultar_Total(dt);
            }

            return Json(inter);
        }
        public JsonResult MostrarInmuebleId(Models.ConsultaInmueble consultaInmueble)
        {
            Models.Inmueble inmueble = new Models.Inmueble();
            inmueble.IdCf = Application.UrlCifrardo.Encrypt(consultaInmueble.Inmueble.Id.ToString());

            return Json(inmueble);
        }
        public JsonResult QuitarInmueble(Models.ConsultaInmueble consultaInmueble, Application.Coo_Interes coo_Interes)
        {
            Models.Mensaje mensaje = new Models.Mensaje();
            string dt = "";
            if (Request.Cookies["Intereses"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Intereses"].Value.ToString());
                mensaje = coo_Interes.Interes_Desactivar(dt, consultaInmueble.Inmueble.Id);

            }

            return Json(mensaje);
        }
    }
}
