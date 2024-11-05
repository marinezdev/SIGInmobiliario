using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG_WebApplication.Controllers
{
    public class MiCuentaController : Controller
    {
        Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
        // GET: MiCuenta
        public ActionResult Index(Application.Menu menu, Application.Inmueble inmueble, Application.Telefonos_Mostrados telefonos_Mostrados, Application.Inmueble_Visto inmueble_Visto, Application.Mensajes_Inmuebles mensajes_Inmuebles, Application.Usuario usuario)
        {
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            string cdv = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (menu.ValidacionPagina(Usuairo, url))
            {
                List<Models.Inmueble> inmuebles = inmueble.Inmueble_Selecionar_IdUsuairo(Usuairo.IdUsuario);
                List<Models.Inmueble> inmueblesLitado = inmueble.Inmueble_Selecionar_IdUsuairo_Listar(Usuairo.IdUsuario);
                Models.Telefonos_Mostrados telefonos_Mostrados1 = telefonos_Mostrados.Telefonos_Mostrados_IdUsuario(Usuairo.IdUsuario);
                Models.Inmueble InPublic = inmueble.Inmuebles_publicados(Usuairo.IdUsuario);
                Models.Inmueble_Visto _Visto = inmueble_Visto.Inmueble_Visto_IdUsuario(Usuairo.IdUsuario);
                Models.Mensajes_Inmuebles mensajes_ = mensajes_Inmuebles.Mensajes_Inmuebles_IdUsuario(Usuairo.IdUsuario);
                List<Models.Inmueble_Visto> ListaInmueblesVistos = inmueble_Visto.Inmueble_Visto_Totales(Usuairo.IdUsuario);
                List<Models.Mensajes_Inmuebles> ListaMensajesInmueble = mensajes_Inmuebles.Mensajes_Inmuebles_Totales(Usuairo.IdUsuario);
                List<Models.Telefonos_Mostrados> ListaTelefonosInmueble = telefonos_Mostrados.Telefonos_Mostrados_Totales(Usuairo.IdUsuario);

                Models.Usuarios DtUsuario = usuario.Usuarios_Seleccionar_IdUsuario(Usuairo.IdUsuario);

                ViewBag.Inmuebles = inmuebles;
                ViewBag.InmueblesLitado = inmueblesLitado;
                ViewBag.Num = telefonos_Mostrados1.Num;
                ViewBag.Total = InPublic.Total;
                ViewBag.VieuTotal = _Visto.Num;
                ViewBag.MensajeTotal = mensajes_.Num;
                ViewBag.ListaInmueblesVistos = ListaInmueblesVistos;
                ViewBag.ListaMensajesInmueble = ListaMensajesInmueble;
                ViewBag.ListaTelefonosInmueble = ListaTelefonosInmueble;

                ViewBag.Nombre = DtUsuario.Nombre;
                ViewBag.Apellidos = DtUsuario.Apellidos;
                ViewBag.Email = DtUsuario.Email;
                ViewBag.FechaRegistro = DtUsuario.FechaRegistro;
                ViewBag.Telefono = DtUsuario.Telefono;
                ViewBag.TelefonoMovil = DtUsuario.TelefonoMovil;

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Adm", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(cdv) });
            }
        }

        public ActionResult InmuebleDetalle(Application.Menu menu, Application.Inmueble inmueble, Application.InmueblesImg inmueblesImg, Application.SubCategoria subCategoria, Application.cat_estados cat_Estados, Application.TipoSubCategoria tipoSubCategoria, Application.cat_moneda cat_Moneda, Application.UnidadMedida unidadMedida, Application.Control_Archivos control_Archivos)
        {
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (!String.IsNullOrEmpty(Request.QueryString["Inm"]))
            {
                if (menu.ValidacionPagina(Usuairo, url))
                {
                    int IdEnmueble = 0;
                    try
                    {
                        IdEnmueble = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["Inm"]));
                    }
                    catch
                    {
                        return RedirectToAction("Index", "business");
                    }

                    
                    List<Models.SubCategoria> subCategorias = subCategoria.SubCategoria_Seleccionar_Editar();
                    List<Models.cat_estados> catestados = cat_Estados.Cat_estados_Selecionar_Editar();
                    //List<Models.TipoSubCategoria> tipoSubCategorias = tipoSubCategoria.SubCategoria_Seleccionar(1);
                    List<Models.cat_moneda> catmonedas = cat_Moneda.cat_moneda_seleccionar();
                    List<Models.UnidadMedida> unidadMedidas = unidadMedida.UnidadMedida_Seleccionar_Listado();

                    ViewBag.SubCategorias = subCategorias;
                    ViewBag.CatEstados = catestados;
                    //ViewBag.TipoSubCategoria = tipoSubCategorias;
                    ViewBag.CatMonedas = catmonedas;
                    ViewBag.UnidadMedidas = unidadMedidas;


                    List<Models.InmueblesImg> imgs = inmueblesImg.InmueblesImgs_Seleccionar_IdInmueble(IdEnmueble);
                    Session["Imagenes"] = imgs;

                    Models.Inmueble inmueble1 = inmueble.Inmueble_Seleccionar_Editar_IdInmueble(IdEnmueble);
                    ViewBag.IdSubCategoria = inmueble1.IdSubCategoria;
                    ViewBag.SubCategoria = inmueble1.SubCategoria;
                    ViewBag.TipoCategoria = inmueble1.TipoCategoria;
                    ViewBag.IdTipoSub = inmueble1.IdTipoSub;
                    ViewBag.Tiempo = inmueble1.Tiempo;
                    ViewBag.FechaRegistro = inmueble1.FechaRegistro;
                    ViewBag.Titulo = inmueble1.Titulo;
                    ViewBag.Descripcion = inmueble1.Descripcion;
                    ViewBag.NombreEstatus = inmueble1.NombreEstatus;
                    ViewBag.IdEstado = inmueble1.IdEstado;
                    ViewBag.Estado = inmueble1.Estado;
                    ViewBag.Poblacion = inmueble1.Poblacion;
                    ViewBag.IdPoblacion = inmueble1.IdPoblacion;
                    ViewBag.CP = inmueble1.CP;
                    ViewBag.IdCP = inmueble1.IdCP;
                    ViewBag.Colonia = inmueble1.Colonia;
                    ViewBag.IdColonia = inmueble1.IdColonia;
                    ViewBag.WC = inmueble1.WC;
                    ViewBag.Estacionamientos = inmueble1.Estacionamientos;
                    ViewBag.Superficie = inmueble1.Superficie;
                    ViewBag.SuperficieT = inmueble1.SuperficieT;
                    ViewBag.Precio = inmueble1.Precio;
                    ViewBag.IdMoneda = inmueble1.IdMoneda;
                    ViewBag.NombreMoneda = inmueble1.NombreMoneda;
                    ViewBag.NombreUsuario = inmueble1.NombreUsuario;
                    ViewBag.Correo = inmueble1.Correo;
                    ViewBag.Telefono = inmueble1.Telefono;
                    ViewBag.TelefonoMovil = inmueble1.TelefonoMovil;
                    ViewBag.IdUnidadMedida = inmueble1.IdUnidadMedida;
                    ViewBag.UnidadMedida = inmueble1.UnidadMedida;
                    ViewBag.UnidadMedidaAbre = inmueble1.UnidadMedidaAbre;
                    ViewBag.Id = IdEnmueble;


                    ViewBag.Imgs = imgs;

                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Micuenta", new { @Inm = Request.QueryString["Inm"] });
                }
            }
            else
            {
                return RedirectToAction("Index", "Micuenta");
            }


        }
        public JsonResult CargaImagenes(Models.NuevoInmueblesImg nuevoInmueblesImg)
        {
            List<Models.InmueblesImg> LstInmuebleImg = new List<Models.InmueblesImg>();

            if (Session["Imagenes"] != null)
            {
                LstInmuebleImg = (List<Models.InmueblesImg>)Session["Imagenes"];
            }

            return Json(LstInmuebleImg);
        }
        public JsonResult EliminarImagen(Models.NuevoInmueblesImg nuevoInmueblesImg, Application.InmueblesImg inmueblesImg)
        {
            string DirectorioUsuario = Server.MapPath("~") + "\\Inmuebles\\" + Usuairo.IdUsuario + "\\";
            List<Models.InmueblesImg> LstInmuebleImg = new List<Models.InmueblesImg>();
            if (Session["Imagenes"] != null)
            {
                LstInmuebleImg = (List<Models.InmueblesImg>)Session["Imagenes"];
            }

            for (int i = 0; i < LstInmuebleImg.Count; i++)
            {
                if (LstInmuebleImg[i].IdArchivo == nuevoInmueblesImg.InmueblesImg.IdArchivo)
                {
                    inmueblesImg.InmueblesImg_Desactivar(LstInmuebleImg[i].IdArchivo);
                    System.IO.File.Delete(DirectorioUsuario + LstInmuebleImg[i].NmArchivo);
                    LstInmuebleImg.Remove(LstInmuebleImg[i]);
                }
            }

            Session["Imagenes"] = LstInmuebleImg;

            return Json(LstInmuebleImg);
        }
        public JsonResult OrdenarImagenes(Models.NuevoInmueblesImg nuevoInmueblesImg, Application.InmueblesImg inmueblesImg)
        {
            List<Models.InmueblesImg> LstInmuebleImg = new List<Models.InmueblesImg>();
            List<Models.InmueblesImg> LstInmuebleImgNuevo = new List<Models.InmueblesImg>();

            int IdArchivo1 = 0;
            int IdArchivo2 = 0;

            if (Session["Imagenes"] != null)
            {
                LstInmuebleImg = (List<Models.InmueblesImg>)Session["Imagenes"];
            }

            IdArchivo1 = LstInmuebleImg[0].IdArchivo;
            IdArchivo2 = nuevoInmueblesImg.InmueblesImg.IdArchivo;

            inmueblesImg.InmueblesImg_cambiarOrden(IdArchivo1, IdArchivo2);

            // TOMA LA IMAGEN ESCOGIDA
            for (int i = 0; i < LstInmuebleImg.Count; i++)
            {
                if (LstInmuebleImg[i].IdArchivo == nuevoInmueblesImg.InmueblesImg.IdArchivo)
                {
                    LstInmuebleImgNuevo.Add(LstInmuebleImg[i]);
                }
            }

            // LLEGA EL LSITADO
            for (int i = 0; i < LstInmuebleImg.Count; i++)
            {
                if (LstInmuebleImg[i].IdArchivo != nuevoInmueblesImg.InmueblesImg.IdArchivo)
                {
                    LstInmuebleImgNuevo.Add(LstInmuebleImg[i]);
                }
            }

            return Json(LstInmuebleImgNuevo);
        }
        public JsonResult Inmueble_Actualizar(Models.ConsultaInmueble consultaInmueble, Application.Inmueble inmueble)
        {
            List<Models.InmueblesImg> LstInmuebleImg = new List<Models.InmueblesImg>();
            Models.Mensaje mensaje = new Models.Mensaje();

            if (Session["Imagenes"] != null)
            {
                LstInmuebleImg = (List<Models.InmueblesImg>)Session["Imagenes"];
            }

            if (LstInmuebleImg.Count > 0)
            {
                mensaje = inmueble.Inmueble_Actualizar(consultaInmueble.Inmueble);
            }
            else
            {
                mensaje.Respuesta = false;
                mensaje.RespuestaText = "Debes de agregar por lómenos 1 imagen del inmueble ";
            }

            return Json(mensaje);
        }
        public JsonResult CargaImagen(Application.Control_Archivos control_Archivos, Application.InmueblesImg inmueblesImg)
        {
            string DirectorioUsuario = Server.MapPath("~") + "\\Inmuebles\\" + Usuairo.IdUsuario + "\\";
            string DirectorioURL = System.Web.HttpContext.Current.Request.Url.Authority + "\\Inmuebles\\" + Usuairo.IdUsuario + "\\";

            List<Models.InmueblesImg> LstInmuebleImg = new List<Models.InmueblesImg>();

            if (Session["Imagenes"] != null)
            {
                LstInmuebleImg = (List<Models.InmueblesImg>)Session["Imagenes"];
            }

            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];
                Models.InmueblesImg _inmueblesImg = new Models.InmueblesImg();
                _inmueblesImg = control_Archivos.NuevoArchivo(file, DirectorioUsuario, DirectorioURL);

                if (_inmueblesImg.NmArchivo != null)
                {
                    _inmueblesImg.IdInmueble = LstInmuebleImg[0].IdInmueble;
                    inmueblesImg.Agregar(_inmueblesImg);
                    LstInmuebleImg.Add(_inmueblesImg);
                }
            }

            Session["Imagenes"] = LstInmuebleImg;

            return Json(LstInmuebleImg);
        }
        public JsonResult DesactivarInmueble(Models.ConsultaInmueble consultaInmueble, Application.Inmueble inmueble)
        {
            Models.Mensaje Resultado = inmueble.Inmueble_Desactivar(consultaInmueble.Inmueble.Id);
            return Json(Resultado);
        }
        public JsonResult VendidoInmueble(Models.ConsultaInmueble consultaInmueble, Application.Inmueble inmueble)
        {
            Models.Mensaje Resultado = inmueble.Inmueble_Vendido(consultaInmueble.Inmueble.Id);
            return Json(Resultado);
        }
        public JsonResult RentadoInmueble(Models.ConsultaInmueble consultaInmueble, Application.Inmueble inmueble)
        {
            Models.Mensaje Resultado = inmueble.Inmueble_Rentado(consultaInmueble.Inmueble.Id);
            return Json(Resultado);
        }
        public JsonResult EliminarInmueble(Models.ConsultaInmueble consultaInmueble, Application.Inmueble inmueble)
        {
            Models.Mensaje Resultado = inmueble.Inmueble_Eliminar(consultaInmueble.Inmueble.Id);
            return Json(Resultado);
        }
        public JsonResult PublicarInmueble(Models.ConsultaInmueble consultaInmueble, Application.Inmueble inmueble)
        {
            Models.Mensaje Resultado = inmueble.Inmueble_Publicar(consultaInmueble.Inmueble.Id);
            return Json(Resultado);
        }
        public JsonResult ConsultaMensajes(Models.ConsultaInmueble consultaInmueble, Application.Mensajes_Inmuebles mensajes_Inmuebles)
        {
            List<Models.Mensajes_Inmuebles> mensajes_Inmuebles1 = mensajes_Inmuebles.Mensajes_Inmuebles_IdInmueble(consultaInmueble.Inmueble.Id);
            return Json(mensajes_Inmuebles1);
        }

        public JsonResult ActualizarUsuario(Models.NuevoRegistro NuevoUsuario, Application.Usuario usuario)
        {
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            NuevoUsuario.usuarios.IdUsuario = Usuairo.IdUsuario;

            Models.Mensaje Dtmensaje = usuario.Usuario_Actualizar(NuevoUsuario.usuarios);
            return Json(Dtmensaje);
        }

        public JsonResult Actualizarpassword(Models.NuevoRegistro NuevoUsuario, Application.Usuario usuario)
        {
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            NuevoUsuario.usuarios.IdUsuario = Usuairo.IdUsuario;

            Models.Mensaje Dtmensaje = usuario.Usuario_Actualizar_Password(NuevoUsuario.usuarios);
            return Json(Dtmensaje);
        }
    }
}
