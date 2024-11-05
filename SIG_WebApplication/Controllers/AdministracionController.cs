using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG_WebApplication.Controllers.Administracion
{
    public class AdministracionController : Controller
    {
        Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];

        // GET: Administracion
        public ActionResult Index(Application.Menu menu, Application.Estatus estatus, Application.Inmueble_Visto inmueble_Visto, Application.Inmueble inmueble, Application.TipoSubCategoria tipoSubCategoria, Application.Mensajes_Inmuebles mensajes_Inmuebles)
        {
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (menu.ValidacionPagina(Usuairo, url))
            {
                List<Models.Estatus> estatuses = estatus.Estatus_Inmuebles_Totales();
                List<Models.Inmueble_Visto> inmueble_Vistos = inmueble_Visto.Inmueble_Visto_Inmueble_Total();
                List<Models.Inmueble> inmuebles = inmueble.Inmueble_Listar_Pendientes();
                List<Models.TipoSubCategoria> tipoSubCategorias = tipoSubCategoria.TipoSubCategoria_Inmuebles_Total();
                List<Models.Mensajes_Inmuebles> mensajes_Inmuebles1 = mensajes_Inmuebles.Mensajes_Inmuebles_Total();

                ViewBag.Estatus = estatuses;
                ViewBag.InmueblesVistos = inmueble_Vistos;
                ViewBag.InmueblesCategorias = tipoSubCategorias;
                ViewBag.inmueble = inmuebles;
                ViewBag.InmueblesMensajes = mensajes_Inmuebles1;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Adm");
            }
        }
        public ActionResult Pendientes(Application.Menu menu, Application.Inmueble inmueble)
        {
            List<Models.Inmueble> inmuebles = inmueble.Inmueble_Listar_Pendientes();

            ViewBag.inmueble = inmuebles;
            return View();
        }
        public ActionResult EvaluarInmueble(Application.Menu menu, Application.Inmueble inmueble, Application.InmueblesImg inmueblesImg)
        {
            string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            string cdv = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;

            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (menu.ValidacionPagina(Usuairo, url))
            {
                if (!String.IsNullOrEmpty(Request.QueryString["Inm"]))
                {
                    int IdEnmueble =  Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["Inm"]));

                    Models.Inmueble inmueble1 = inmueble.Inmueble_Seleccionar_IdInmueble(IdEnmueble);
                    ViewBag.SubCategoria = inmueble1.SubCategoria;
                    ViewBag.TipoCategoria = inmueble1.TipoCategoria;
                    ViewBag.Tiempo = inmueble1.Tiempo;
                    ViewBag.FechaRegistro = inmueble1.FechaRegistro;
                    ViewBag.Titulo = inmueble1.Titulo;
                    ViewBag.Descripcion = inmueble1.Descripcion;
                    ViewBag.NombreEstatus = inmueble1.NombreEstatus;
                    ViewBag.Estado = inmueble1.Estado;
                    ViewBag.Poblacion = inmueble1.Poblacion;
                    ViewBag.CP = inmueble1.CP;
                    ViewBag.Colonia = inmueble1.Colonia;
                    ViewBag.WC = inmueble1.WC;
                    ViewBag.Estacionamientos = inmueble1.Estacionamientos;
                    ViewBag.Superficie = inmueble1.Superficie;
                    ViewBag.SuperficieT = inmueble1.SuperficieT;
                    ViewBag.Precio = inmueble1.Precio;
                    ViewBag.NombreMoneda = inmueble1.NombreMoneda;
                    ViewBag.NombreUsuario = inmueble1.NombreUsuario;
                    ViewBag.Correo = inmueble1.Correo;
                    ViewBag.Telefono = inmueble1.Telefono;
                    ViewBag.TelefonoMovil = inmueble1.TelefonoMovil;
                    ViewBag.Id = inmueble1.Id;

                    List<Models.InmueblesImg> imgs = inmueblesImg.InmueblesImgs_Seleccionar_IdInmueble(IdEnmueble);

                    ViewBag.Imgs = imgs;

                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Administracion");
                }
            }
            else
            {
                return RedirectToAction("Login", "Adm", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(cdv) });
            }
        }
        public JsonResult Procesar_Inmueble(Models.ConsultaInmueble consultaInmueble, Application.Inmueble inmueble)
        {
            //string IdEnmueble = Application.UrlCifrardo.Decrypt(consultaInmueble.Inmueble.IdCf);
            string IdEnmueble = consultaInmueble.Inmueble.IdCf;

            Models.Inmueble datos = inmueble.SIG_InmuebleProcesar( Convert.ToInt32(IdEnmueble), Usuairo.IdUsuario);
            Models.Mensaje mensaje = new Models.Mensaje();

            if (datos.Id > 0)
            {
                mensaje.Respuesta = true;
                mensaje.Contenido = "Inmueble publicado!";
            }

            return Json(mensaje);
        }
        public JsonResult Procesar_Inmueble_Rechazo(Models.ConsultaInmueble consultaInmueble, Application.Inmueble inmueble)
        {
            string IdEnmueble = consultaInmueble.Inmueble.IdCf;

            Models.Inmueble datos = inmueble.SIG_InmuebleProcesar_Rechazar(Convert.ToInt32(IdEnmueble), Usuairo.IdUsuario);
            Models.Mensaje mensaje = new Models.Mensaje();

            if (datos.Id > 0)
            {
                mensaje.Respuesta = true;
                mensaje.Contenido = "Inmueble rechazado!";
            }

            return Json(mensaje);
        }
        public ActionResult Inmuebles(Application.Inmueble inmueble)
        {
            List<Models.Inmueble> inmuebles = inmueble.Inmuebles_Listar();
            ViewBag.inmueble = inmuebles;
            return View();
        }
        public ActionResult Usuarios(Application.Usuario usuario)
        {
            List<Models.Usuarios> usuarios = usuario.Usuarios_Listar();
            ViewBag.usuarios = usuarios;
            return View();
        }
    }
}
