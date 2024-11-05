using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG_WebApplication.Controllers
{
    public class CompararController : Controller
    {
        // GET: Comparar
        public ActionResult Index(Application.Coo_Comparar coo_Comparar, Application.Comparar comparar)
        {
            List<Models.Inmueble> inmuebles = new List<Models.Inmueble>();
            List<Models.Comparar> Listcomparar = new List<Models.Comparar>();
            string dt = "";

            if (Request.Cookies["Comparar"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Comparar"].Value.ToString());
                inmuebles = coo_Comparar.Comparar_Selecionar_Inmuebles(dt);
                Listcomparar = comparar.Comparar_Seleccionar(dt);
            }
            ViewBag.Total = inmuebles.Count;
            ViewBag.Inmuebles = inmuebles;
            ViewBag.Listcomparar = Listcomparar;
            return View();
        }
        public ActionResult Comparar(Application.Coo_Comparar coo_Comparar, Application.Comparar comparar)
        {
            List<Models.Inmueble> inmuebles = new List<Models.Inmueble>();
            List<Models.Comparar> Listcomparar = new List<Models.Comparar>();
            string dt = "";

            if (Request.Cookies["Comparar"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Comparar"].Value.ToString());
                inmuebles = coo_Comparar.Comparar_Selecionar_Inmuebles(dt);
                Listcomparar = comparar.Comparar_Seleccionar(dt);
            }
            ViewBag.Total = inmuebles.Count;
            ViewBag.Inmuebles = inmuebles;
            ViewBag.Listcomparar = Listcomparar;
            return View();
        }

        public ActionResult Interes(Application.Coo_Comparar coo_Comparar)
        {
            List<Models.Inmueble> inmuebles = new List<Models.Inmueble>();
            string dt = "";

            if (Request.Cookies["Comparar"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Comparar"].Value.ToString());
                inmuebles = coo_Comparar.Comparar_Selecionar_Inmuebles(dt);
            }

            ViewBag.Inmuebles = inmuebles;
            return View();
        }
        public JsonResult AgregarComparar(Models.ConsultarComparar consultarComparar, Application.Coo_Comparar coo_Comparar)
        {
            Models.Mensaje mensaje = new Models.Mensaje();

            string dt = "";
            if (Request.Cookies["Comparar"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Comparar"].Value.ToString());
                mensaje = coo_Comparar.Comparar_Registrar_Inmueble(dt, consultarComparar.Comparar.IdInmueble);
            }
            else
            {
                Models.Coo_Comparar coo_Comparar1 = coo_Comparar.coo_Comparar_Registrar();
                Response.Cookies["Comparar"].Value = Application.UrlCifrardo.Encrypt(coo_Comparar1.Clave);
                mensaje = coo_Comparar.Comparar_Registrar_Inmueble(coo_Comparar1.Clave, consultarComparar.Comparar.IdInmueble);
            }

            return Json(mensaje);
        }
        public JsonResult Comparar_Consultar(Application.Coo_Comparar coo_Comparar)
        {
            Models.Comparar comp = new Models.Comparar();
            string dt = "";
            comp.Total = 0;
            if (Request.Cookies["Comparar"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Comparar"].Value.ToString());
                comp = coo_Comparar.Comparar_Consultar_Total(dt);
            }
            return Json(comp);
        }
        public JsonResult MostrarInmuebleId(Models.ConsultaInmueble consultaInmueble)
        {
            Models.Inmueble inmueble = new Models.Inmueble();
            inmueble.IdCf = Application.UrlCifrardo.Encrypt(consultaInmueble.Inmueble.Id.ToString());

            return Json(inmueble);
        }
        public JsonResult QuitarInmueble(Models.ConsultaInmueble consultaInmueble, Application.Coo_Comparar coo_Comparar)
        {
            Models.Mensaje mensaje = new Models.Mensaje();
            string dt = "";
            if (Request.Cookies["Comparar"] != null)
            {
                dt = Application.UrlCifrardo.Decrypt(Request.Cookies["Comparar"].Value.ToString());
                mensaje = coo_Comparar.Comparar_Desactivar(dt, consultaInmueble.Inmueble.Id);

            }
            return Json(mensaje);
        }
    }
}
