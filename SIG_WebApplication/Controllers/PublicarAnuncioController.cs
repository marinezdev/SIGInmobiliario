using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG_WebApplication.Controllers
{
    public class PublicarAnuncioController : Controller
    {
        Models.Usuarios Usuairo = (Models.Usuarios)System.Web.HttpContext.Current.Session["Sesion"];

        public ActionResult Index(Application.Menu menu, Application.SubCategoria subCategoria, Application.cat_estados cat_Estados, Application.TipoSubCategoria tipoSubCategoria, Application.cat_moneda cat_Moneda, Application.UnidadMedida unidadMedida)
        {
            string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;

            if (menu.ValidacionPagina(Usuairo, url))
            {
                Session.Remove("Imagenes");
                Session["Imagenes"] = null;

                List<Models.SubCategoria> subCategorias = subCategoria.SubCategoria_Seleccionar();
                List<Models.cat_estados> catestados = cat_Estados.Estados_Seleccionar();
                //List<Models.TipoSubCategoria> tipoSubCategorias = tipoSubCategoria.SubCategoria_Seleccionar(1);
                List<Models.cat_moneda> catmonedas = cat_Moneda.cat_moneda_seleccionar();
                List<Models.UnidadMedida> unidadMedidas = unidadMedida.UnidadMedida_Seleccionar_Listado();

                ViewBag.SubCategorias = subCategorias;
                ViewBag.CatEstados = catestados;
                //ViewBag.TipoSubCategoria = tipoSubCategorias;
                ViewBag.CatMonedas = catmonedas;
                ViewBag.UnidadMedidas = unidadMedidas;

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Adm");
            }
        }
        [HttpPost]
        public JsonResult CargaImagen(Application.Control_Archivos control_Archivos)
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
                    LstInmuebleImg.Add(_inmueblesImg);
                }
            }



            Session["Imagenes"] = LstInmuebleImg;

            return Json(LstInmuebleImg);
        }
        public JsonResult OrdenarImagenes(Models.NuevoInmueblesImg nuevoInmueblesImg)
        {
            List<Models.InmueblesImg> LstInmuebleImg = new List<Models.InmueblesImg>();
            List<Models.InmueblesImg> LstInmuebleImgNuevo = new List<Models.InmueblesImg>();

            if (Session["Imagenes"] != null)
            {
                LstInmuebleImg = (List<Models.InmueblesImg>)Session["Imagenes"];
            }

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
        public JsonResult EliminarImagen(Models.NuevoInmueblesImg nuevoInmueblesImg)
        {
            string DirectorioUsuario = Server.MapPath("~") + "\\Inmuebles\\" + Usuairo.IdUsuario + "\\";
            List<Models.InmueblesImg> LstInmuebleImg = new List<Models.InmueblesImg>();
            if (Session["Imagenes"] != null)
            {
                LstInmuebleImg = (List<Models.InmueblesImg>)Session["Imagenes"];
            }

            for (int i = 0; i < LstInmuebleImg.Count; i++)
            {
                if(LstInmuebleImg[i].IdArchivo == nuevoInmueblesImg.InmueblesImg.IdArchivo)
                {
                    System.IO.File.Delete(DirectorioUsuario + LstInmuebleImg[i].NmArchivo);
                    LstInmuebleImg.Remove(LstInmuebleImg[i]);
                }
            }

            Session["Imagenes"] = LstInmuebleImg;

            return Json(LstInmuebleImg);
        }
        public JsonResult CargaPoblaciones(Models.ConsultaPoblaciones consultaPoblaciones, Application.cat_poblaciones cat_Poblaciones)
        {
            List<Models.cat_poblaciones> _Poblaciones = cat_Poblaciones.Poblacion_Seleccionar(consultaPoblaciones.cat_Poblaciones.IdEstado);
            return Json(_Poblaciones);
        }
        public JsonResult CargaPostales(Models.ConsultaCP consultaCP, Application.cat_cp cat_Cp)
        {
            List<Models.cat_cp> _cps = cat_Cp.CP_Seleccionar(consultaCP.cat_cp.IdPoblacion);
            return Json(_cps);
        }
        public JsonResult CargaColonias(Models.ConsultaColonias consultaColonias, Application.cat_colonias cat_Colonias)
        {
            List<Models.cat_colonias> _Colonias = cat_Colonias.cat_colonias_Seleccionar(consultaColonias.cat_colonias.IdCP);
            return Json(_Colonias);
        }
        public JsonResult CargaTipoSubCategoria(Models.ConsultaTipoSubCategoria consultaTipoSubCategoria, Application.TipoSubCategoria tipoSubCategoria)
        {
            List<Models.TipoSubCategoria> _tipoSubCategorias = tipoSubCategoria.SubCategoria_Seleccionar(consultaTipoSubCategoria.tipoSubCategoria.IdSubCategoria);
            return Json(_tipoSubCategorias);
        }
        public JsonResult RegistraNuevo_Inmueble(Models.ConsultaInmueble consultaInmueble, Application.Inmueble inmueble)
        {
            List<Models.InmueblesImg> LstInmuebleImg = new List<Models.InmueblesImg>();
            Models.Mensaje mensaje = new Models.Mensaje();

            if (Session["Imagenes"] != null)
            {
                LstInmuebleImg = (List<Models.InmueblesImg>)Session["Imagenes"];
            }

            if (LstInmuebleImg.Count > 0)
            {
                consultaInmueble.Inmueble.IdUsuario = Usuairo.IdUsuario;
                consultaInmueble.Inmueble.IdCategoria = 1;

                mensaje = inmueble.Nuevo_InmuebleInicia(consultaInmueble.Inmueble, LstInmuebleImg);
            }
            else
            {
                mensaje.Respuesta = false;
                mensaje.RespuestaText = "Debes de agregar por lómenos 1 imagen del inmueble ";
            }
            
            return Json(mensaje);
        }

    }
}
