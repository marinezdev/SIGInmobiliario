using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG_WebApplication.Controllers
{
    public class RedirecController : Controller
    {
        // GET: Redirec
        public ActionResult Index()
        {
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string URL = "";

            if (!String.IsNullOrEmpty(Request.QueryString["aspxerrorpath"]))
            {
                URL = Request.QueryString["aspxerrorpath"].ToString();
            }

            try
            {
                if (Usuairo.Nombre == null)
                {
                    ViewBag.URL = URL;
                    return View();
                }
                else
                {
                    return RedirectToAction("IndexSesion", "Redirec", new { @aspxerrorpath = Request.QueryString["aspxerrorpath"] });
                }
            }
            catch
            {
                ViewBag.URL = URL;
                return View();
            }
        }
  
        public ActionResult IndexSesion()
        {
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string URL = "";

            if (!String.IsNullOrEmpty(Request.QueryString["aspxerrorpath"]))
            {
                URL = Request.QueryString["aspxerrorpath"].ToString();
            }

            try
            {
                if (Usuairo.Nombre == null)
                {
                    ViewBag.URL = URL;
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Redirec", new { @aspxerrorpath = Request.QueryString["aspxerrorpath"] });
                }
            }
            catch
            {
                ViewBag.URL = URL;
                return View();
            }
        }
    }
}
