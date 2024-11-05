using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG_WebApplication.Controllers
{
    public class AdmController : Controller
    {
        //Application.Usuario usuario = new Application.Usuario();

        // GET: Adm
        public ActionResult Login(Application.Usuario usuario)
        {
            try
            {
                if (Request.Cookies["SesionDT"].Value != "")
                {
                    //Request.Cookies["SesionDT"].Value = null;
                    string Clave = Application.UrlCifrardo.Decrypt(Request.Cookies["SesionDT"].Value.ToString());
                    Models.Usuarios DtUsuer = usuario.coo_Session_Seleccionar(Clave);

                    Models.Usuarios DataUser = usuario.Iniciar(DtUsuer);
                    if (DataUser.IdUsuario > 0)
                    {
                        Session["Sesion"] = DataUser;

                        if (DataUser.IdRol == 1)
                        {
                            return RedirectToAction("Index", "Administracion");
                        }
                        else if (DataUser.IdRol == 2)
                        {
                            return RedirectToAction("Index", "Administracion");
                        }
                        else if (DataUser.IdRol == 3)
                        {
                            return RedirectToAction("Index", "business");
                        }

                    }
                }
            }
            catch
            {

            }
            

            ViewBag.rd = Request.QueryString["rd"];
            ViewBag.rdv = Request.QueryString["rdv"];
            return View();
        }
        public ActionResult Registrar()
        {
            return View();
        }
        public ActionResult Autentificar(Application.Usuario usuario)
        {
            if (Request["com"] != null)
            {
                try
                {
                    string Token = Application.UrlCifrardo.Decrypt(HttpUtility.UrlDecode(Request["com"]));
                    Models.Usuarios data = usuario.ValidarUsuarioToken(Token);

                    if (data.Email.Length > 1)
                    {
                        ViewBag.Resultado = 1;
                        ViewBag.Nombre = data.Nombre;
                        ViewBag.Apellidos = data.Apellidos;
                        ViewBag.Email = data.Email;
                        ViewBag.Telefono = data.Telefono;
                        ViewBag.TelefonoMovil = data.TelefonoMovil;
                        ViewBag.Password = data.Password;
                    }
                    else
                    {
                        ViewBag.Resultado = 4;
                    }
                }
                catch (Exception)
                {
                    ViewBag.Resultado = 2;
                }
            }
            else
            {
                ViewBag.Resultado = 3;
            }

            return View();
        }
        public ActionResult Decline(Application.Usuario usuario)
        {
            if (Request["com"] != null)
            {
                try
                {
                    string Token = Application.UrlCifrardo.Decrypt(HttpUtility.UrlDecode(Request["com"]));
                    Models.Usuarios data = usuario.ValidarUsuarioTokenDecline(Token);

                    if (data.Email.Length > 1)
                    {
                        ViewBag.Resultado = 1;
                        ViewBag.Nombre = data.Nombre;
                        ViewBag.Apellidos = data.Apellidos;
                        ViewBag.Email = data.Email;
                        ViewBag.Telefono = data.Telefono;
                        ViewBag.TelefonoMovil = data.TelefonoMovil;
                        ViewBag.Password = data.Password;
                    }
                    else
                    {
                        ViewBag.Resultado = 4;
                    }
                }
                catch (Exception)
                {
                    ViewBag.Resultado = 2;
                }
            }
            else
            {
                ViewBag.Resultado = 3;
            }

            return View();
        }
        [HttpPost]
        public JsonResult RegistrarNuevoUsuario(Models.NuevoRegistro NuevoUsuario, Application.Usuario usuario)
        {
            if (NuevoUsuario != null)
            {
                return Json(usuario.NuevoRegistro(NuevoUsuario.usuarios));
            }
            else
            {
                return Json("Ha ocurrido un problema!");
            }
        }
        [HttpPost]
        public JsonResult Iniciar(Models.NuevoRegistro NuevoUsuario, Application.Usuario usuario, Application.Menu menu)
        {
            if (NuevoUsuario != null)
            {
                Models.Usuarios DataUser = usuario.Iniciar(NuevoUsuario.usuarios);
                if (DataUser.IdUsuario > 0)
                {
                    Session["Sesion"] = DataUser;

                    if (NuevoUsuario.usuarios.Session)
                    {
                        Response.Cookies["SesionDT"].Value = Application.UrlCifrardo.Encrypt(DataUser.ClaveCoo);
                    }
                    
                }
                   

                if (!String.IsNullOrEmpty(NuevoUsuario.usuarios.Ruta))
                {
                    string url = Application.UrlCifrardo.Decrypt(NuevoUsuario.usuarios.Ruta);
                    if (menu.ValidacionPagina(DataUser, url))
                    {
                        string Nu = Application.UrlCifrardo.Decrypt(NuevoUsuario.usuarios.RutaAcceso);
                        DataUser.Ruta = Nu;
                    }
                }
                
                return Json(DataUser);
            }
            else
            {
                return Json("Ha ocurrido un problema!");
            }
        }
        [HttpPost]
        public JsonResult CerrarSesion()
        {
            Models.Usuarios DataUser = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            Response.Cookies["SesionDT"].Value = null;

            Session.Abandon();

            if (DataUser != null)
            {
                return Json(DataUser);
            }
            else
            {
                return Json("Ha ocurrido un problema!");
            }
        }
        public JsonResult EnviarCorreo(Models.NuevoRegistro NuevoUsuario, Application.Usuario usuario)
        {
            if (NuevoUsuario != null)
            {
                return Json(usuario.EnviarNuevoCorreo(NuevoUsuario.usuarios));
            }
            else
            {
                return Json("Ha ocurrido un problema!");
            }
        }
        public ActionResult RecuperarPassword()
        {
            return View();
        }

        public JsonResult RecuperPassword(Models.NuevoRegistro NuevoUsuario, Application.Usuario usuario)
        {
            Models.Usuarios DataUser = usuario.Usuario_Selecionar_Password(NuevoUsuario.usuarios);
            return Json(DataUser);
        }
    }
}
