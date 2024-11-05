using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SIG_WebApplication.Application
{
    public class Inmueble
    {
        Data.Inmueble _Inmueble = new Data.Inmueble();
        Data.Usuario _usuario = new Data.Usuario();
        Data.InmueblesImg _inmueblesImg = new Data.InmueblesImg();
        Data.TipoSubCategoria _TipoSubCategoria = new Data.TipoSubCategoria();
        Data.Mensajes_Inmuebles _mensajes_Inmuebles = new Data.Mensajes_Inmuebles();

        public Models.Mensaje Nuevo_InmuebleInicia(Models.Inmueble inmueble, List<Models.InmueblesImg> inmueblesImgs)
        {
            Models.Inmueble inmueble1 = _Inmueble.Nuevo_InmuebleInicia(inmueble);
            Models.Mensaje mensaje = new Models.Mensaje();

            if (inmueble1.Id != 0)
            {
                foreach (var InmueblesIng in inmueblesImgs)
                {
                    InmueblesIng.IdInmueble = inmueble1.Id;
                    _inmueblesImg.Agregar(InmueblesIng);
                }

                mensaje.Respuesta = true;
                WSCorreo.CorreoSoapClient correo1 = new WSCorreo.CorreoSoapClient();
                List<Models.Usuarios> usuarios = _usuario.Usuarios_Super_Selecionar();

                foreach (var usuario in usuarios)
                {
                    if (usuario != null)
                    {
                        if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", usuario.Email.Trim(), "Servicios Inmobiliarios G", "Nuevo inmueble registrado", HTML(usuario, inmueble1.Id)) == "Correo enviado")
                        {
                            mensaje.Contenido = "Inmueble registrado y notificado exitosamente ";
                        }
                        else
                        {
                            mensaje.Contenido = "Inmueble registrado ";
                        }
                    }
                }
            }
            else
            {
                mensaje.Respuesta = false;
                mensaje.Contenido = "Problemas al realizar tu registro, inténtelo más tarde.";
            }


            return mensaje;
        }
        public Models.Inmueble SIG_InmuebleProcesar(int IdInmueble, int IdUsuario)
        {
            Models.Inmueble inmueble = _Inmueble.SIG_InmuebleProcesar(IdInmueble, IdUsuario);
            return inmueble;
        }
        public Models.Inmueble SIG_InmuebleProcesar_Rechazar(int IdInmueble, int IdUsuario)
        {
            Models.Inmueble inmueble = _Inmueble.SIG_InmuebleProcesar_Rechazar(IdInmueble, IdUsuario);
            return inmueble;
        }
        public Models.Mensaje Inmueble_Actualizar(Models.Inmueble inmueble)
        {
            Models.Mensaje mensaje = _Inmueble.Inmueble_Actualizar(inmueble);
            return mensaje;
        }
        public List<Models.Inmueble> Inmueble_Selecionar_IdUsuairo(int IdUsuario)
        {
            List<Models.Inmueble> inmuebles = _Inmueble.Inmueble_Selecionar_IdUsuairo(IdUsuario);
            List<Models.Inmueble> Ninmuebles = new List<Models.Inmueble>();

            foreach (var inmueble in inmuebles)
            {
                inmueble.IdCf = Application.UrlCifrardo.Encrypt(inmueble.Id.ToString());
                Ninmuebles.Add(inmueble);
            }

            return Ninmuebles;
        }
        public List<Models.Inmueble> Inmueble_Selecionar_IdUsuairo_Listar(int IdUsuario)
        {
            List<Models.Inmueble> inmuebles = _Inmueble.Inmueble_Selecionar_IdUsuairo_Listar(IdUsuario);
            List<Models.Inmueble> Ninmuebles = new List<Models.Inmueble>();

            foreach (var inmueble in inmuebles)
            {
                inmueble.IdCf = Application.UrlCifrardo.Encrypt(inmueble.Id.ToString());
                Ninmuebles.Add(inmueble);
            }

            return Ninmuebles;
        }
        public string Inmuebles_Selecionar()
        {
            string Contenido = "";
            int a = 0;

            List<Models.TipoSubCategoria> tiposubcategoria = _TipoSubCategoria.TipoSubCategoria_Selecionar_Listado();

            foreach (var tipo in tiposubcategoria)
            {
                string header = "";
                int total = 0;
                bool uno = false;

                if (a == 0)
                {
                    header += "" +
                    "<div class='tab-pane fade show active' id='grup_" + tipo.Id + "' role='tabpanel'>" +
                        "<!-- Slide2 -->" +
                        "<div class='wrap-slick2'>" +
                            "<div class='slick2'>";
                    a += 1;
                }
                else
                {
                    header += "" +
                    "<div class='tab-pane fade' id='grup_" + tipo.Id + "' role='tabpanel'>" +
                        "<!-- Slide2 -->" +
                        "<div class='wrap-slick2'>" +
                            "<div class='slick2'>";
                }


                List<Models.Inmueble> inmuebles = _Inmueble.Inmuebles_Selecionar(tipo.Id);

                foreach (var inmueble in inmuebles)
                {
                    if (inmueble.Id > 0)
                    {
                        total += 1;
                        uno = true;
                        header += "" +
                        "<div class='item-slick2 p-l-15 p-r-15 p-t-15 p-b-15'>" +
                            "<!-- Block2 --> " +
                            "<div class='block2'>" +
                                "<div class='block2-pic hov-img0'>" +
                                    "<img src='" + inmueble.Imagen + "' alt='IMG-PRODUCT'>" +

                                    "<a href='#' onclick='VistaRapida(" + inmueble.Id + ")' class='block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1'>" +
                                        "Vista rápida" +
                                    "</a>" +
                                "</div>" +

                                "<div class='block2-txt flex-w flex-t p-t-14 text-center'>" +
                                    "<div class='block2-txt-child1  text-center'>" +
                                        "<a href='#' class='stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6'>" +
                                            "<span class='block2-txt-child1-Sub'>" + inmueble.SubCategoria + ", " + inmueble.TipoCategoria + "</span>" +
                                            "<br />" +
                                            "" + inmueble.Estado + "" +
                                        "</a>" +
                                        "<div class='product-rating'>" +
                                            "<i class='fa fa-star'></i>" +
                                            "<i class='fa fa-star'></i>" +
                                            "<i class='fa fa-star'></i>" +
                                            "<i class='fa fa-star'></i>" +
                                            "<i class='fa fa-star'></i>" +
                                        "</div>" +
                                        "<hr />" +
                                        "<span class='stext-105 cl3'>" +
                                            "" + inmueble.Precio + "" +
                                        "</span>" +
                                        "<div class='product-label'>" +
                                            //"<span class='sale'>-30%</span>" +
                                            "<span class='new'>NEW</span>" +
                                        "</div>" +
                                        "<div class='product-btns'>" +
                                            "<button class='add-to-wishlist' tabindex='0' onclick='AgregarInteres(" + inmueble.Id + ")'><i class='fa fa-heart-o'></i><span class='tooltipp'>Añadir interes</span></button>" +
                                            "<button class='add-to-compare' tabindex='0' onclick='AgregarComparar(" + inmueble.Id + ")'><i class='fa fa-exchange'></i><span class='tooltipp'>Añadir comparar</span></button>" +
                                            "<button class='quick-view js-show-modal1' tabindex='0' onclick='VistaRapida(" + inmueble.Id + ")'><i class='fa fa-eye'></i><span class='tooltipp'>Vista rápida</span></button>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>" +

                            "</div>" +
                        "</div>";

                    }
                    else
                    {
                        uno = false;
                    }
                }

                header += "</div>" +
                        "</div>" +
                    "</div>";


                if (uno)
                {
                    Contenido += header;
                }
                else
                {
                    a = 0;
                }

            }

            return Contenido;
        }
        public string Inmuebles_Selecionar_Random()
        {
            string contenido = "";

            List<Models.Inmueble> inmuebles = _Inmueble.Inmuebles_Selecionar_Random();

            foreach (var inmueble in inmuebles)
            {
                contenido += "<div class='item-slick2 p-l-15 p-r-15 p-t-15 p-b-15'>" +
                    "<!-- Block2 --> " +
                    "<div class='block2'>" +
                        "<div class='block2-pic hov-img0'>" +
                            "<img src='" + inmueble.Imagen + "' alt='IMG-PRODUCT'>" +

                            "<a href='#' onclick='VistaRapida(" + inmueble.Id + ")' class='block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1'>" +
                                "Mostrar " +
                            "</a>" +
                        "</div>" +

                        "<div class='block2-txt flex-w flex-t p-t-14 text-center'>" +
                            "<div class='block2-txt-child1  text-center'>" +
                                "<a href='#' class='stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6'>" +
                                    "<span class='block2-txt-child1-Sub'>" + inmueble.SubCategoria + ", " + inmueble.TipoCategoria + "</span>" +
                                    "<br />" +
                                    "" + inmueble.Estado + "" +
                                "</a>" +
                                "<div class='product-rating'>" +
                                    "<i class='fa fa-star'></i>" +
                                    "<i class='fa fa-star'></i>" +
                                    "<i class='fa fa-star'></i>" +
                                    "<i class='fa fa-star'></i>" +
                                    "<i class='fa fa-star'></i>" +
                                "</div>" +
                                "<hr />" +
                                "<span class='stext-105 cl3'>" +
                                    "" + inmueble.Precio + "" +
                                "</span>" +
                                "<div class='product-label'>" +
                                    //"<span class='sale'>-30%</span>" +
                                    "<span class='new'>NEW</span>" +
                                "</div>" +
                                "<div class='product-btns'>" +
                                    "<button class='add-to-wishlist' tabindex='0' onclick='AgregarInteres(" + inmueble.Id + ")'><i class='fa fa-heart-o'></i><span class='tooltipp'>Añadir interes</span></button>" +
                                    "<button class='add-to-compare' tabindex='0'  onclick='AgregarComparar(" + inmueble.Id + ")'><i class='fa fa-exchange'></i><span class='tooltipp'>Añadir comparar</span></button>" +
                                   "<button class='quick-view js-show-modal1' tabindex='0' onclick='VistaRapida(" + inmueble.Id + ")'><i class='fa fa-eye'></i><span class='tooltipp'>Mostrar</span></button>" +
                                "</div>" +
                            "</div>" +
                        "</div>" +

                    "</div>" +
                "</div>";
            }

            return contenido;
        }
        public List<Models.Inmueble> Inmueble_Seleccionar(string TipoSubCategoria, int IdSubCategoria)
        {
            List<Models.Inmueble> inmuebles = _Inmueble.Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria(TipoSubCategoria, IdSubCategoria);
            return inmuebles;
        }
        public string Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria(string TipoSubCategoria, int IdSubCategoria)
        {
            string contenido = "";

            List<Models.Inmueble> inmuebles = _Inmueble.Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria(TipoSubCategoria, IdSubCategoria);

            foreach (var inmueble in inmuebles)
            {
                contenido += "<div class='col-md-4  p-l-15 p-r-15 p-t-15 p-b-15'>" +
                    "<!-- Block2 --> " +
                    "<div class='block2'>" +
                        "<div class='block2-pic hov-img0'>" +
                            "<img src='" + inmueble.Imagen + "' alt='IMG-PRODUCT'>";

                if (inmueble.NombreEstatus == "Vendido")
                {
                    contenido += "<img class='img15' style='position: absolute; top: 0; right: 0;' src='http://www.serviciosinmobiliariosg.com.mx/images/icons/vendida.png' />";
                }else if (inmueble.NombreEstatus == "Rentado")
                {
                    contenido += "<img class='img15' style='position: absolute; top: 0; right: 0;' src='http://www.serviciosinmobiliariosg.com.mx/images/icons/unnamed.png' />";
                }
                

                

                contenido += "<a href='#' onclick='VistaRapida(" + inmueble.Id + ")' class='block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1'>" +
                                "Mostrar " +
                            "</a>" +
                        "</div>" +

                        "<div class='block2-txt flex-w flex-t p-t-14 text-center'>" +
                            "<div class='block2-txt-child1  text-center'>" +
                                "<a href='#' class='stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6'>" +
                                    "<span class='block2-txt-child1-Sub'>" + inmueble.SubCategoria + ", " + inmueble.TipoCategoria + "</span>" +
                                    "<br />" +
                                    "" + inmueble.Estado + "" +
                                "</a>" +
                                "<div class='product-rating'>" +
                                    "<i class='fa fa-star'></i>" +
                                    "<i class='fa fa-star'></i>" +
                                    "<i class='fa fa-star'></i>" +
                                    "<i class='fa fa-star'></i>" +
                                    "<i class='fa fa-star'></i>" +
                                "</div>" +
                                "<hr />" +
                                "<span class='stext-105 cl3'>" +
                                    "" + inmueble.Precio + "" +
                                "</span>" +
                                "<div class='product-label'>" +
                                    //"<span class='sale'>-30%</span>" +
                                    "<span class='new'>NEW</span>" +
                                "</div>" +
                                "<div class='product-btns'>" +
                                    "<button class='add-to-wishlist' tabindex='0' onclick='AgregarInteres(" + inmueble.Id + ")'><i class='fa fa-heart-o'></i><span class='tooltipp'>Añadir interes</span></button>" +
                                    "<button class='add-to-compare' tabindex='0'  onclick='AgregarComparar(" + inmueble.Id + ")'><i class='fa fa-exchange'></i><span class='tooltipp'>Añadir comparar</span></button>" +
                                   "<button class='quick-view js-show-modal1' tabindex='0' onclick='VistaRapida(" + inmueble.Id + ")'><i class='fa fa-eye'></i><span class='tooltipp'>Mostrar</span></button>" +
                                "</div>" +
                            "</div>" +
                        "</div>" +

                    "</div>" +
                "</div>";
            }

            return contenido;
        }
        public string ArmaArticulo(Models.Inmueble inmueble)
        {
            string Contenido = "";
            return Contenido;
        }
        public Models.Inmueble Inmueble_Seleccionar_IdInmueble(int IdInmueble)
        {
            Models.Inmueble inmueble = _Inmueble.Inmueble_Seleccionar_IdInmueble(IdInmueble);

            //inmueble.Superficie = "Área " + inmueble.Superficie + " m2";
            inmueble.IdCf = Application.UrlCifrardo.Encrypt(inmueble.Id.ToString());
            return inmueble;
        }
        public Models.Inmueble Inmueble_Seleccionar_Editar_IdInmueble(int IdInmueble)
        {
            Models.Inmueble inmueble = _Inmueble.Inmueble_Seleccionar_Editar_IdInmueble(IdInmueble);

            inmueble.IdCf = Application.UrlCifrardo.Encrypt(inmueble.Id.ToString());
            char[] MyChar = { '$', ',', ' ' };
            inmueble.Precio = inmueble.Precio.TrimStart(MyChar).Replace(",", "");


            return inmueble;
        }
        public List<Models.Inmueble> Inmuebles_Seleccionar_SubCategorias(int IdSubCategoria)
        {
            List<Models.Inmueble> inmuebles = _Inmueble.Inmuebles_Seleccionar_SubCategorias(IdSubCategoria);
            return inmuebles;
        }
        public Models.Mensaje Llamada(Models.Correo correo, int IdUsuario)
        {
            WSCorreo.CorreoSoapClient correo1 = new WSCorreo.CorreoSoapClient();
            Models.Mensaje mensaje = new Models.Mensaje();

            Models.Inmueble inmueble = _Inmueble.Inmueble_Seleccionar_IdInmueble(correo.IdInmueble);

            if (inmueble.Id > 0)
            {
                if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", correo.Email, "Servicios Inmobiliarios G", "Quiero que me llamen ", HTMLLlamadaCliente(correo, inmueble.Id)) == "Correo enviado")
                {
                    mensaje.Contenido = "Email enviado";

                    correo.Nombre = inmueble.NombreUsuario;
                    if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", inmueble.Correo, "Servicios Inmobiliarios G", "Quiero que me llamen ", HTMLLlamadaAnunciante(correo, inmueble.Id)) == "Correo enviado")
                    {
                        mensaje.Respuesta = true;
                        mensaje.Contenido = "Se ha enviado un correo electrónico para notificar al anunciante.";

                    }
                    else
                    {
                        mensaje.Respuesta = false;
                        mensaje.Contenido = "Problemas en notificacion.";
                    }
                }
                else
                {
                    mensaje.Respuesta = false;
                    mensaje.Contenido = "Problemas en notificacion.";
                }

                Models.Mensajes_Inmuebles mensajes_Inmuebles = new Models.Mensajes_Inmuebles();
                mensajes_Inmuebles.IdInmueble = inmueble.Id;
                mensajes_Inmuebles.IdUsuario = IdUsuario;
                mensajes_Inmuebles.Email = correo.Email;
                mensajes_Inmuebles.Nombre = correo.NombreContacto;
                mensajes_Inmuebles.Telefono = correo.Telefono;
                if (correo.Mensaje != null)
                {
                    mensajes_Inmuebles.Mensajes = correo.Mensaje;
                }
                else
                {
                    mensajes_Inmuebles.Mensajes = "";
                }
                mensajes_Inmuebles.Mensajes = "";
                mensajes_Inmuebles.Asunto = "Quiero que me llamen";

                _mensajes_Inmuebles.Mensajes_Inmuebles_Agregar(mensajes_Inmuebles);

            }
            else
            {
                mensaje.Respuesta = false;
                mensaje.Contenido = "Inmueble no encontrado.";
            }



            return mensaje;
        }
        public Models.Mensaje Consulta(Models.Correo correo, int IdUsuario)
        {
            WSCorreo.CorreoSoapClient correo1 = new WSCorreo.CorreoSoapClient();
            Models.Mensaje mensaje = new Models.Mensaje();

            Models.Inmueble inmueble = _Inmueble.Inmueble_Seleccionar_IdInmueble(correo.IdInmueble);

            if (inmueble.Id > 0)
            {
                if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", correo.Email, "Servicios Inmobiliarios G", "Consulta de inmueble ", HTMLConsultaCliente(correo, inmueble.Id)) == "Correo enviado")
                {
                    mensaje.Contenido = "Email enviado";

                    correo.Nombre = inmueble.NombreUsuario;
                    if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", inmueble.Correo, "Servicios Inmobiliarios G", "Consulta de inmueble ", HTMLConsultaAnunciante(correo, inmueble.Id)) == "Correo enviado")
                    {
                        mensaje.Respuesta = true;
                        mensaje.Contenido = "Se ha enviado un correo electrónico para notificar al anunciante.";

                    }
                    else
                    {
                        mensaje.Respuesta = false;
                        mensaje.Contenido = "Problemas en notificacion.";
                    }
                }
                else
                {
                    mensaje.Respuesta = false;
                    mensaje.Contenido = "Problemas en notificacion.";
                }

                Models.Mensajes_Inmuebles mensajes_Inmuebles = new Models.Mensajes_Inmuebles();
                mensajes_Inmuebles.IdInmueble = inmueble.Id;
                mensajes_Inmuebles.IdUsuario = IdUsuario;
                mensajes_Inmuebles.Email = correo.Email;
                mensajes_Inmuebles.Nombre = correo.NombreContacto;
                mensajes_Inmuebles.Telefono = correo.Telefono;
                if (correo.Mensaje != null)
                {
                    mensajes_Inmuebles.Mensajes = correo.Mensaje;
                }
                else
                {
                    mensajes_Inmuebles.Mensajes = "";
                }
                mensajes_Inmuebles.Asunto = "Consulta de inmueble";

                _mensajes_Inmuebles.Mensajes_Inmuebles_Agregar(mensajes_Inmuebles);

            }
            else
            {
                mensaje.Respuesta = false;
                mensaje.Contenido = "Inmueble no encontrado.";
            }



            return mensaje;
        }
        public Models.Mensaje Agenda(Models.Correo correo, int IdUsuario)
        {
            WSCorreo.CorreoSoapClient correo1 = new WSCorreo.CorreoSoapClient();
            Models.Mensaje mensaje = new Models.Mensaje();

            Models.Inmueble inmueble = _Inmueble.Inmueble_Seleccionar_IdInmueble(correo.IdInmueble);

            if (inmueble.Id > 0)
            {
                if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", correo.Email, "Servicios Inmobiliarios G", "Agendar visita  ", HTMLAgendaCliente(correo, inmueble.Id)) == "Correo enviado")
                {
                    mensaje.Contenido = "Email enviado";

                    correo.Nombre = inmueble.NombreUsuario;
                    if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", inmueble.Correo, "Servicios Inmobiliarios G", "Agendar visita  ", HTMLAgendaAnunciante(correo, inmueble.Id)) == "Correo enviado")
                    {
                        mensaje.Respuesta = true;
                        mensaje.Contenido = "Se ha enviado un correo electrónico para notificar al anunciante.";

                    }
                    else
                    {
                        mensaje.Respuesta = false;
                        mensaje.Contenido = "Problemas en notificacion.";
                    }
                }
                else
                {
                    mensaje.Respuesta = false;
                    mensaje.Contenido = "Problemas en notificacion.";
                }

                Models.Mensajes_Inmuebles mensajes_Inmuebles = new Models.Mensajes_Inmuebles();
                mensajes_Inmuebles.IdInmueble = inmueble.Id;
                mensajes_Inmuebles.IdUsuario = 0;
                mensajes_Inmuebles.Email = correo.Email;
                mensajes_Inmuebles.Nombre = correo.NombreContacto;
                mensajes_Inmuebles.Telefono = correo.Telefono;
                if (correo.Mensaje != null)
                {
                    mensajes_Inmuebles.Mensajes = correo.Mensaje;
                }
                else
                {
                    mensajes_Inmuebles.Mensajes = "";
                }
                mensajes_Inmuebles.Asunto = "Agendar visita";

                _mensajes_Inmuebles.Mensajes_Inmuebles_Agregar(mensajes_Inmuebles);

            }
            else
            {
                mensaje.Respuesta = false;
                mensaje.Contenido = "Inmueble no encontrado.";
            }



            return mensaje;
        }
        public Models.Mensaje Inmueble_Desactivar(int IdArchivo)
        {
            Models.Mensaje mensaje = _Inmueble.Inmueble_Desactivar(IdArchivo);
            return mensaje;
        }
        public Models.Mensaje Inmueble_Vendido(int IdArchivo)
        {
            Models.Mensaje mensaje = _Inmueble.Inmueble_Vendido(IdArchivo);
            return mensaje;
        }
        public Models.Mensaje Inmueble_Rentado(int IdArchivo)
        {
            Models.Mensaje mensaje = _Inmueble.Inmueble_Rentado(IdArchivo);
            return mensaje;
        }
        public Models.Mensaje Inmueble_Eliminar(int IdArchivo)
        {
            Models.Mensaje mensaje = _Inmueble.Inmueble_Eliminar(IdArchivo);
            return mensaje;
        }
        public Models.Mensaje Inmueble_Publicar(int IdArchivo)
        {
            Models.Mensaje mensaje = _Inmueble.Inmueble_Publicar(IdArchivo);
            return mensaje;
        }
        public Models.Inmueble Inmuebles_publicados(int IdUsuario)
        {
            Models.Inmueble total = _Inmueble.Inmuebles_publicados(IdUsuario);
            return total;
        }
        public List<Models.Inmueble> Inmueble_Seleccionar_Busqueda(Models.Busquedas busquedas)
        {
            char delimitador = ',';
            string[] valores = busquedas.Direccion.Split(delimitador);

            if(valores.Length > 0)
            {
                try
                {
                    busquedas.Estado = valores[0].Trim();
                }
                catch
                {
                    busquedas.Estado = "";
                }

                try
                {
                    busquedas.Poblacion = valores[1].Trim();
                }
                catch
                {
                    busquedas.Poblacion = "";
                }
                try
                {
                    busquedas.CP = valores[2].Trim();
                }
                catch
                {
                    busquedas.CP = "";
                }
                try
                {
                    busquedas.Colonia = valores[3].Trim();
                }
                catch
                {
                    busquedas.Colonia = "";
                }
            }
            else
            {
                busquedas.Estado = "";
                busquedas.Poblacion = "";
                busquedas.CP = "";
                busquedas.Colonia = "";
            }

            List<Models.Inmueble> inmuebles = _Inmueble.Inmueble_Seleccionar_Busqueda(busquedas);
            
            return inmuebles;
        }
        public List<Models.Inmueble> Inmueble_Seleccionar_BusquedaIds(Models.Busquedas busquedas)
        {
            List<Models.Inmueble> inmuebles = _Inmueble.Inmueble_Seleccionar_BusquedaIds(busquedas);

            return inmuebles;
        }

        public List<Models.Inmueble> Inmueble_Listar_Pendientes()
        {
            List<Models.Inmueble> inmuebles = _Inmueble.Inmueble_Listar_Pendientes();
            return inmuebles;
        }
        public List<Models.Inmueble> Inmuebles_Listar()
        {
            List<Models.Inmueble> inmuebles = _Inmueble.Inmuebles_Listar();
            return inmuebles;
        }

        public string HTML(Models.Usuarios usuario,int IdInmueble)
        {
            Correo.Formatos FormatoContenido = new Correo.Formatos();
            string host = HttpContext.Current.Request.Url.Authority;
            string direccion = "http://" + host + "/Administracion/EvaluarInmueble?Inm=" + Application.UrlCifrardo.Encrypt(IdInmueble.ToString());

            string HTML = FormatoContenido.NuevoInmueble(usuario, direccion);

            return HTML;
        }
        public string HTMLLlamadaCliente(Models.Correo correo, int IdInmueble)
        {
            Correo.FormatosLlamada formatosLlamada = new Correo.FormatosLlamada();
            string host = HttpContext.Current.Request.Url.Authority;

            string direccion = "http://" + host + "/home/InmuebleDetalle?Inm=" + Application.UrlCifrardo.Encrypt(IdInmueble.ToString());
            string HTML = formatosLlamada.LlamadaCliente(correo, direccion);

            return HTML;
        }
        public string HTMLLlamadaAnunciante(Models.Correo correo, int IdInmueble)
        {
            Correo.FormatosLlamada formatosLlamada = new Correo.FormatosLlamada();
            string host = HttpContext.Current.Request.Url.Authority;

            string direccion = "http://" + host + "/home/InmuebleDetalle?Inm=" + Application.UrlCifrardo.Encrypt(IdInmueble.ToString());
            string HTML = formatosLlamada.LlamadaAnunciante(correo, direccion);

            return HTML;
        }
        public string HTMLConsultaCliente(Models.Correo correo, int IdInmueble)
        {
            Correo.FormatoConsulta formatosConsulta = new Correo.FormatoConsulta();
            string host = HttpContext.Current.Request.Url.Authority;

            string direccion = "http://" + host + "/home/InmuebleDetalle?Inm=" + Application.UrlCifrardo.Encrypt(IdInmueble.ToString());
            string HTML = formatosConsulta.ConsultaCliente(correo, direccion);

            return HTML;
        }
        public string HTMLConsultaAnunciante(Models.Correo correo, int IdInmueble)
        {
            Correo.FormatoConsulta formatosConsulta = new Correo.FormatoConsulta();
            string host = HttpContext.Current.Request.Url.Authority;

            string direccion = "http://" + host + "/home/InmuebleDetalle?Inm=" + Application.UrlCifrardo.Encrypt(IdInmueble.ToString());
            string HTML = formatosConsulta.ConsultaAnunciante(correo, direccion);

            return HTML;
        }
        public string HTMLAgendaCliente(Models.Correo correo, int IdInmueble)
        {
            Correo.FormatoAgenda formatosAgenda = new Correo.FormatoAgenda();
            string host = HttpContext.Current.Request.Url.Authority;

            string direccion = "http://" + host + "/home/InmuebleDetalle?Inm=" + Application.UrlCifrardo.Encrypt(IdInmueble.ToString());
            string HTML = formatosAgenda.AgendaCliente(correo, direccion);

            return HTML;
        }
        public string HTMLAgendaAnunciante(Models.Correo correo, int IdInmueble)
        {
            Correo.FormatoAgenda formatosAgenda = new Correo.FormatoAgenda();
            string host = HttpContext.Current.Request.Url.Authority;

            string direccion = "http://" + host + "/home/InmuebleDetalle?Inm=" + Application.UrlCifrardo.Encrypt(IdInmueble.ToString());
            string HTML = formatosAgenda.AgendaAnunciante(correo, direccion);

            return HTML;
        }

        
    }

}
