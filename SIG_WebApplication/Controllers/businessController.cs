using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG_WebApplication.Controllers.business
{
    public class businessController : Controller
    {
        // GET: business
        public ActionResult Index(Application.Menu menu, Application.TipoSubCategoria tipoSubCategoria, Application.Inmueble inmueble, Application.cat_estados cat_Estados)
        {
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
           
            if(menu.ValidacionPagina(Usuairo, url))
            {
                List<Models.TipoSubCategoria> _tipoSubCategoria = tipoSubCategoria.TipoSubCategoria_Selecionar_Listado();
                List<Models.TipoSubCategoria> _tipoSubCategoriaBusqueda = tipoSubCategoria.TipoSubCategoria_Busqueda();
                List<Models.cat_estados> _cat_estados = cat_Estados.cat_estados_Seleccionar_Busqueda();
                string Contenido = inmueble.Inmuebles_Selecionar();


                ViewBag.tipoSubCategoria = _tipoSubCategoria;
                ViewBag.inmuebles = Contenido;

                ViewBag.tipSubBus = _tipoSubCategoriaBusqueda;
                ViewBag.cat_estados = _cat_estados;


                return View();
            }
            else
            {
                return RedirectToAction("Login", "Adm");
            }
        }

        public JsonResult InmueblesImgs(Models.NuevoInmueblesImg nuevoInmueblesImg, Application.InmueblesImg inmueblesImg)
        {

            List<Models.InmueblesImg> inmueblesImgs = inmueblesImg.InmueblesImgs_Seleccionar_IdInmueble(nuevoInmueblesImg.InmueblesImg.IdInmueble);

            return Json(inmueblesImgs);
        }

        public JsonResult Inmuebles(Models.NuevoInmueblesImg nuevoInmueblesImg, Application.Inmueble inmueble)
        {

            Models.Inmueble DataInmueble = inmueble.Inmueble_Seleccionar_IdInmueble(nuevoInmueblesImg.InmueblesImg.IdInmueble);

            return Json(DataInmueble);

        }

        /**********************************************************************************************************************************************************************/
        public ActionResult InmuebleDetalle(Application.Menu menu, Application.Inmueble inmueble, Application.InmueblesImg inmueblesImg, Application.Comentarios comentarios)
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

                    List<Models.InmueblesImg> imgs = inmueblesImg.InmueblesImgs_Seleccionar_IdInmueble(IdEnmueble);
                    string Contenido = inmueble.Inmuebles_Selecionar_Random();
                    List<Models.Comentarios> _comentarios = comentarios.Comentarios_Selecionar_IdInmueble(IdEnmueble);

                    Models.Inmueble inmueble1 = inmueble.Inmueble_Seleccionar_IdInmueble(IdEnmueble);
                    ViewBag.SubCategoria = inmueble1.SubCategoria.ToUpper();
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
                    ViewBag.Id = IdEnmueble;
                    ViewBag.NombreMoneda = inmueble1.NombreMoneda;
                    ViewBag.UnidadMedidaAbre = inmueble1.UnidadMedidaAbre;

                    ViewBag.Imgs = imgs;
                    ViewBag.inmuebles = Contenido;
                    ViewBag.comentarios = _comentarios;

                    return View();
                }
                else
                {
                    return RedirectToAction("InmuebleDetalle", "Home", new { @Inm = Request.QueryString["Inm"] });
                }
            }
            else
            {
                return RedirectToAction("Index", "business");
            }


        }
        public JsonResult InmuebleContultaId(Models.ConsultaInmueble consultaInmueble)
        {
            string Inmueble = Application.UrlCifrardo.Encrypt(consultaInmueble.Inmueble.Id.ToString());
            return Json(Inmueble);
        }
        public JsonResult MostrarTelefono(Models.ConsultaInmueble consultaInmueble, Application.Telefonos_Mostrados telefonos_Mostrados)
        {
            Models.Inmueble Telefono = telefonos_Mostrados.Telefonos_Mostrados_Agregar(consultaInmueble.Inmueble.Id, 0);
            return Json(Telefono);
        }
        public JsonResult Llamada(Models.ConsultaCorreo consultaCorreo, Application.Inmueble inmueble)
        {
            Models.Usuarios Usuairo = new Models.Usuarios();
            int IdUsuario = 0;
            try
            {
                Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
                IdUsuario = Usuairo.IdUsuario;
            }
            catch
            {
                IdUsuario = 0;
            }
            
            Models.Mensaje mensaje = inmueble.Llamada(consultaCorreo.correo, IdUsuario);

            return Json(mensaje);
        }
        public JsonResult Consulta(Models.ConsultaCorreo consultaCorreo, Application.Inmueble inmueble)
        {
            Models.Usuarios Usuairo = new Models.Usuarios();
            int IdUsuario = 0;
            try
            {
                Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
                IdUsuario = Usuairo.IdUsuario;
            }
            catch
            {
                IdUsuario = 0;
            }

            Models.Mensaje mensaje = inmueble.Consulta(consultaCorreo.correo, IdUsuario);

            return Json(mensaje);
        }
        public JsonResult Agenda(Models.ConsultaCorreo consultaCorreo, Application.Inmueble inmueble)
        {
            Models.Usuarios Usuairo = new Models.Usuarios();
            int IdUsuario = 0;
            try
            {
                Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
                IdUsuario = Usuairo.IdUsuario;
            }
            catch
            {
                IdUsuario = 0;
            }

            Models.Mensaje mensaje = inmueble.Agenda(consultaCorreo.correo, IdUsuario);
            return Json(mensaje);
        }
        public JsonResult Visto(Models.ConsultaInmueble consultaInmueble, Application.Inmueble_Visto inmueble_Visto)
        {
            Models.Usuarios Usuairo = new Models.Usuarios();
            int IdUsuario = 0;
            try
            {
                Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
                IdUsuario = Usuairo.IdUsuario;
            }
            catch
            {
                IdUsuario = 0;
            }

            Models.Inmueble_Visto _Visto = new Models.Inmueble_Visto();
            _Visto.IdInmueble = consultaInmueble.Inmueble.Id;
            _Visto.IdUsuario = IdUsuario;
            _Visto = inmueble_Visto.Inmueble_Visto_Agregar(_Visto);
            return Json(_Visto);
        }
        /**********************************************************************************************************************************************************************/
        public ActionResult Categorias(Application.SubCategoria subCategoria, Application.Menu menu)
        {
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (menu.ValidacionPagina(Usuairo, url))
            {
                List<Models.SubCategoria> subCategorias = subCategoria.SubCategoria_Seleccionar_Listar();
                ViewBag.subCategorias = subCategorias;

                return View();
            }
            else
            {
                return RedirectToAction("Categorias", "Home");
            }
            
        }
        public JsonResult TipoSubCategoria(Models.ConsultaTipoSubCategoria consultaTipoSubCategoria, Application.TipoSubCategoria tipoSubCategoria)
        {
            List<Models.TipoSubCategoria> _tipoSubCategorias = tipoSubCategoria.TipoSubCategoria_Seleccionar_Categorias(consultaTipoSubCategoria.tipoSubCategoria.IdSubCategoria);
            return Json(_tipoSubCategorias);
        }
        public JsonResult InmueblesSubCategorias(Models.ConsultaTipoSubCategoria consultaTipoSubCategoria, Application.Inmueble inmueble)
        {
            List<Models.Inmueble> _inmuebles = inmueble.Inmuebles_Seleccionar_SubCategorias(consultaTipoSubCategoria.tipoSubCategoria.IdSubCategoria);
            return Json(_inmuebles);
        }

        /**********************************************************************************************************************************************************************/
        public ActionResult Ayuda(Application.Pregunta pregunta)
        {
            List<Models.Pregunta> preguntas = pregunta.Preguntas_Listar();
            ViewBag.preguntas = preguntas;
            return View();
        }

        public JsonResult Pregunta(Models.ConsultarPreguntas consultarPreguntas, Application.Pregunta pregunta)
        {
            Models.Mensaje mensaje = pregunta.Preguntas_Agregar(consultarPreguntas.pregunta);
            return Json(mensaje);
        }

        /*********************************************************************************************************************************/
        public ActionResult Contacto()
        {
            return View();
        }

        /*********************************************************************************************************************************/
        public ActionResult SitioEnContruccion()
        {
            return View();
        }
        /*********************************************************************************************************************************/
        public ActionResult Busqueda(Application.Inmueble _inmueble, Application.SubCategoria _subCategoria, Application.TipoSubCategoria _tipoSubCategoria, Application.cat_estados cat_Estados, Application.cat_poblaciones cat_Poblaciones, Application.cat_colonias cat_Colonias, Application.cat_moneda cat_Moneda, Application.UnidadMedida unidadMedida)
        {
            // VARIANLES. 
            Models.Busquedas busquedas = new Models.Busquedas();
            List<Models.Inmueble> inmuebles = new List<Models.Inmueble>();

            List<Models.SubCategoria> subCategorias = _subCategoria.SubCategoria_Busqueda();
            List<Models.TipoSubCategoria> tipoSubCategorias = _tipoSubCategoria.TipoSubCategoria_Busqueda2();
            List<Models.cat_estados> catestados = cat_Estados.Estados_Seleccionar();
            List<Models.cat_moneda> catmonedas = cat_Moneda.cat_moneda_seleccionar();
            List<Models.UnidadMedida> unidadMedidas = unidadMedida.UnidadMedida_Seleccionar_Listado();

            Models.cat_estados catestado = new Models.cat_estados();
            Models.cat_poblaciones poblaciones = new Models.cat_poblaciones();
            Models.cat_colonias colonias = new Models.cat_colonias();

            string Cantidad = "";

            if (!String.IsNullOrEmpty(Request.QueryString["ti"]))
            {
                busquedas.TipoSubCategoria = Application.UrlCifrardo.Decrypt(Request.QueryString["ti"]);
            }
            else
            {
                busquedas.TipoSubCategoria = "Todo";
            }

            if (!String.IsNullOrEmpty(Request.QueryString["dir"]))
            {
                busquedas.Direccion = Application.UrlCifrardo.Decrypt(Request.QueryString["dir"]);
            }
            else
            {
                busquedas.Direccion = "";
            }

            if (!String.IsNullOrEmpty(Request.QueryString["tiop"]))
            {
                busquedas.TipoOperacion = Request.QueryString["tiop"];
            }
            else
            {
                busquedas.TipoOperacion = "0";
            }

            if (!String.IsNullOrEmpty(Request.QueryString["wc"]))
            {
                busquedas.wc = Request.QueryString["wc"];
            }
            else
            {
                busquedas.wc = "";
            }

            if (!String.IsNullOrEmpty(Request.QueryString["Esta"]))
            {
                busquedas.Esta = Request.QueryString["Esta"];
            }
            else
            {
                busquedas.Esta = "";
            }

            if (!String.IsNullOrEmpty(Request.QueryString["catEstado"]))
            {
                busquedas.Estado = Request.QueryString["catEstado"];
            }
            else
            {
                busquedas.Estado = "";
            }

            if (!String.IsNullOrEmpty(Request.QueryString["catPoblacion"]))
            {
                busquedas.Poblacion = Request.QueryString["catPoblacion"];
            }
            else
            {
                busquedas.Poblacion = "";
            }

            if (!String.IsNullOrEmpty(Request.QueryString["catColonia"]))
            {
                busquedas.Colonia = Request.QueryString["catColonia"];
            }
            else
            {
                busquedas.Colonia = "";
            }

            if (busquedas.Direccion == "")
            {
                // busqueda de inmuebles por los Id del estado, municipios y colonias
                inmuebles = _inmueble.Inmueble_Seleccionar_BusquedaIds(busquedas);
                catestado = cat_Estados.cat_estados_Selecionar_Ids(busquedas.Estado);
                poblaciones = cat_Poblaciones.cat_poblaciones_selecionar_Ids(busquedas.Poblacion, catestado.Id);
                colonias = cat_Colonias.Cat_Colonias_Selecionar_Ids(busquedas.Colonia);
            }
            else
            {
                inmuebles = _inmueble.Inmueble_Seleccionar_Busqueda(busquedas);

                catestado = cat_Estados.cat_estados_SelecionarId(busquedas.Estado);
                poblaciones = cat_Poblaciones.cat_Poblacion_SelecionarId(busquedas.Poblacion, catestado.Id);
                colonias = cat_Colonias.Cat_Colonias_SelecionarId(busquedas.Colonia, busquedas.CP, poblaciones.Id);
            }



            ViewBag.Inmuebles = inmuebles;
            ViewBag.subCategorias = subCategorias;
            ViewBag.tipoSubCategorias = tipoSubCategorias;
            ViewBag.CatEstados = catestados;
            ViewBag.CatMonedas = catmonedas;
            ViewBag.UnidadMedidas = unidadMedidas;
            ViewBag.TipoOperacion = busquedas.TipoOperacion;
            ViewBag.TipoSubCategoria = busquedas.TipoSubCategoria;
            ViewBag.Estacionamientos = busquedas.Esta;
            ViewBag.WC = busquedas.wc;

            if (inmuebles.Count == 1)
            {
                Cantidad = "Se encontro " + inmuebles.Count.ToString() + " resultado";
            }
            else
            {
                Cantidad = "Se encontraron " + inmuebles.Count.ToString() + " resultados";
            }

            ViewBag.TotalText = Cantidad;
            ViewBag.Total = inmuebles.Count;

            // VARIABLES DE DIRECCIONES
            ViewBag.IdEstado = catestado.Id;
            ViewBag.Estado = catestado.Estado;

            ViewBag.IdPoblacion = poblaciones.Id;
            ViewBag.Poblacion = poblaciones.Poblacion;

            ViewBag.IdColonia = colonias.Id;
            ViewBag.Colonia = colonias.Colonia;

            return View();
        }
        public JsonResult BusquedasContultaId(Models.Busquedas busquedas)
        {
            string IdEncript = Application.UrlCifrardo.Encrypt(busquedas.TipoSubCategoria);
            return Json(IdEncript);
        }
        public JsonResult ConsultaListadoColonias(Models.cat_colonias cat_Colonias, Application.cat_colonias ApCol)
        {
            List<Models.cat_colonias> colonias = ApCol.Cat_Colonias_Selecionar_Poblacion(cat_Colonias.Id);
            return Json(colonias);
        }

        /*********************************************************************************************************************************/
        public ActionResult Casas(Application.SubCategoria _subCategoria, Application.Inmueble inmueble, Application.Menu menu)
        {
            List<Models.SubCategoria> subCategorias = _subCategoria.SubCategoria_Busqueda();
            Models.Busquedas busquedas = new Models.Busquedas();
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (menu.ValidacionPagina(Usuairo, url))
            {
                if (!String.IsNullOrEmpty(Request.QueryString["tiop"]))
                {
                    busquedas.TipoOperacion = Request.QueryString["tiop"];
                }
                else
                {
                    busquedas.TipoOperacion = "0";
                }
                string Contenido = inmueble.Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria("Casa", Convert.ToInt32(busquedas.TipoOperacion));
                string ContenidoRamdom = inmueble.Inmuebles_Selecionar_Random();
                string Cantidad = "";
                List<Models.Inmueble> inmuebles = inmueble.Inmueble_Seleccionar("Casa", Convert.ToInt32(busquedas.TipoOperacion));

                if (inmuebles.Count == 1)
                {
                    Cantidad = "Se encontro " + inmuebles.Count.ToString() + " resultado";
                }
                else
                {
                    Cantidad = "Se encontraron " + inmuebles.Count.ToString() + " resultados";
                }

                ViewBag.TotalText = Cantidad;
                ViewBag.Total = inmuebles.Count;


                ViewBag.subCategorias = subCategorias;
                ViewBag.TipoOperacion = busquedas.TipoOperacion;
                ViewBag.inmuebles = Contenido;
                ViewBag.inmueblesRamdom = ContenidoRamdom;

                return View();
            }
            else
            {
                return RedirectToAction("Casas", "Home");
            }
        }
        public ActionResult Departamentos(Application.SubCategoria _subCategoria, Application.Inmueble inmueble, Application.Menu menu)
        {
            List<Models.SubCategoria> subCategorias = _subCategoria.SubCategoria_Busqueda();
            Models.Busquedas busquedas = new Models.Busquedas();
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (menu.ValidacionPagina(Usuairo, url))
            {
                if (!String.IsNullOrEmpty(Request.QueryString["tiop"]))
                {
                    busquedas.TipoOperacion = Request.QueryString["tiop"];
                }
                else
                {
                    busquedas.TipoOperacion = "0";
                }
                string Contenido = inmueble.Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria("Departamento", Convert.ToInt32(busquedas.TipoOperacion));
                string ContenidoRamdom = inmueble.Inmuebles_Selecionar_Random();
                string Cantidad = "";
                List<Models.Inmueble> inmuebles = inmueble.Inmueble_Seleccionar("Departamento", Convert.ToInt32(busquedas.TipoOperacion));

                if (inmuebles.Count == 1)
                {
                    Cantidad = "Se encontro " + inmuebles.Count.ToString() + " resultado";
                }
                else
                {
                    Cantidad = "Se encontraron " + inmuebles.Count.ToString() + " resultados";
                }

                ViewBag.TotalText = Cantidad;
                ViewBag.Total = inmuebles.Count;

                ViewBag.subCategorias = subCategorias;
                ViewBag.TipoOperacion = busquedas.TipoOperacion;
                ViewBag.inmuebles = Contenido;
                ViewBag.inmueblesRamdom = ContenidoRamdom;

                return View();
            }
            else
            {
                return RedirectToAction("Departamentos", "Home");
            }
        }
        public ActionResult Oficinas(Application.SubCategoria _subCategoria, Application.Inmueble inmueble, Application.Menu menu)
        {
            List<Models.SubCategoria> subCategorias = _subCategoria.SubCategoria_Busqueda();
            Models.Busquedas busquedas = new Models.Busquedas();
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (menu.ValidacionPagina(Usuairo, url))
            {
                if (!String.IsNullOrEmpty(Request.QueryString["tiop"]))
                {
                    busquedas.TipoOperacion = Request.QueryString["tiop"];
                }
                else
                {
                    busquedas.TipoOperacion = "0";
                }
                string Contenido = inmueble.Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria("Oficina", Convert.ToInt32(busquedas.TipoOperacion));
                string ContenidoRamdom = inmueble.Inmuebles_Selecionar_Random();
                string Cantidad = "";
                List<Models.Inmueble> inmuebles = inmueble.Inmueble_Seleccionar("Oficina", Convert.ToInt32(busquedas.TipoOperacion));

                if (inmuebles.Count == 1)
                {
                    Cantidad = "Se encontro " + inmuebles.Count.ToString() + " resultado";
                }
                else
                {
                    Cantidad = "Se encontraron " + inmuebles.Count.ToString() + " resultados";
                }

                ViewBag.TotalText = Cantidad;
                ViewBag.Total = inmuebles.Count;

                ViewBag.subCategorias = subCategorias;
                ViewBag.TipoOperacion = busquedas.TipoOperacion;
                ViewBag.inmuebles = Contenido;
                ViewBag.inmueblesRamdom = ContenidoRamdom;


                return View();
            }
            else
            {
                return RedirectToAction("Oficinas", "Home");
            }
        }
        public ActionResult Ranchos(Application.SubCategoria _subCategoria, Application.Inmueble inmueble, Application.Menu menu)
        {
            List<Models.SubCategoria> subCategorias = _subCategoria.SubCategoria_Busqueda();
            Models.Busquedas busquedas = new Models.Busquedas();
            Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (menu.ValidacionPagina(Usuairo, url))
            {
                if (!String.IsNullOrEmpty(Request.QueryString["tiop"]))
                {
                    busquedas.TipoOperacion = Request.QueryString["tiop"];
                }
                else
                {
                    busquedas.TipoOperacion = "0";
                }
                string Contenido = inmueble.Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria("Rancho", Convert.ToInt32(busquedas.TipoOperacion));
                string ContenidoRamdom = inmueble.Inmuebles_Selecionar_Random();
                string Cantidad = "";
                List<Models.Inmueble> inmuebles = inmueble.Inmueble_Seleccionar("Rancho", Convert.ToInt32(busquedas.TipoOperacion));

                if (inmuebles.Count == 1)
                {
                    Cantidad = "Se encontro " + inmuebles.Count.ToString() + " resultado";
                }
                else
                {
                    Cantidad = "Se encontraron " + inmuebles.Count.ToString() + " resultados";
                }

                ViewBag.TotalText = Cantidad;
                ViewBag.Total = inmuebles.Count;

                ViewBag.subCategorias = subCategorias;
                ViewBag.TipoOperacion = busquedas.TipoOperacion;
                ViewBag.inmuebles = Contenido;
                ViewBag.inmueblesRamdom = ContenidoRamdom;

                return View();

            }
            else
            {
                return RedirectToAction("Ranchos", "Home");
            }

            
        }
        public ActionResult Quirofano(Application.SubCategoria _subCategoria, Application.Inmueble inmueble)
        {
            List<Models.SubCategoria> subCategorias = _subCategoria.SubCategoria_Busqueda();
            Models.Busquedas busquedas = new Models.Busquedas();


            if (!String.IsNullOrEmpty(Request.QueryString["tiop"]))
            {
                busquedas.TipoOperacion = Request.QueryString["tiop"];
            }
            else
            {
                busquedas.TipoOperacion = "0";
            }
            string Contenido = inmueble.Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria("Quirófano", Convert.ToInt32(busquedas.TipoOperacion));
            string ContenidoRamdom = inmueble.Inmuebles_Selecionar_Random();
            string Cantidad = "";
            List<Models.Inmueble> inmuebles = inmueble.Inmueble_Seleccionar("Quirófano", Convert.ToInt32(busquedas.TipoOperacion));

            if (inmuebles.Count == 1)
            {
                Cantidad = "Se encontro " + inmuebles.Count.ToString() + " resultado";
            }
            else
            {
                Cantidad = "Se encontraron " + inmuebles.Count.ToString() + " resultados";
            }

            ViewBag.TotalText = Cantidad;
            ViewBag.Total = inmuebles.Count;


            ViewBag.subCategorias = subCategorias;
            ViewBag.TipoOperacion = busquedas.TipoOperacion;
            ViewBag.inmuebles = Contenido;
            ViewBag.inmueblesRamdom = ContenidoRamdom;

            return View();
        }

        public ActionResult Consultorio(Application.SubCategoria _subCategoria, Application.Inmueble inmueble)
        {
            List<Models.SubCategoria> subCategorias = _subCategoria.SubCategoria_Busqueda();
            Models.Busquedas busquedas = new Models.Busquedas();


            if (!String.IsNullOrEmpty(Request.QueryString["tiop"]))
            {
                busquedas.TipoOperacion = Request.QueryString["tiop"];
            }
            else
            {
                busquedas.TipoOperacion = "0";
            }
            string Contenido = inmueble.Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria("Consultorio", Convert.ToInt32(busquedas.TipoOperacion));
            string ContenidoRamdom = inmueble.Inmuebles_Selecionar_Random();
            string Cantidad = "";
            List<Models.Inmueble> inmuebles = inmueble.Inmueble_Seleccionar("Consultorio", Convert.ToInt32(busquedas.TipoOperacion));

            if (inmuebles.Count == 1)
            {
                Cantidad = "Se encontro " + inmuebles.Count.ToString() + " resultado";
            }
            else
            {
                Cantidad = "Se encontraron " + inmuebles.Count.ToString() + " resultados";
            }

            ViewBag.TotalText = Cantidad;
            ViewBag.Total = inmuebles.Count;


            ViewBag.subCategorias = subCategorias;
            ViewBag.TipoOperacion = busquedas.TipoOperacion;
            ViewBag.inmuebles = Contenido;
            ViewBag.inmueblesRamdom = ContenidoRamdom;

            return View();
        }

        public ActionResult terminosycondiciones()
        {
            return View();
        }
        public ActionResult PoliticasPrivacidad()
        {
            return View();
        }
    }
}
