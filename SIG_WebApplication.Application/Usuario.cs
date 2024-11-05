using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SIG_WebApplication.Application
{
    public class Usuario
    {
        Data.Usuario _Usuario = new Data.Usuario();

        public Models.Usuarios ValidarUsuarioToken(string Token)
        {
            Models.Usuarios usuarios = _Usuario.ValidarUsuarioToken(Token);

            return usuarios;
        }
        public Models.Usuarios ValidarUsuarioTokenDecline(string Token)
        {
            Models.Usuarios usuarios = _Usuario.ValidarUsuarioTokenDecline(Token);
            return usuarios;
        }
        public Models.Mensaje NuevoRegistro(Models.Usuarios usuario)
        {
            Models.Mensaje mensaje = ValidarNuevoRegistro(usuario);

            if (mensaje.Respuesta)
            {
                Models.Mensaje MensajeRegistro = _Usuario.NuevoRegistro(usuario);
                if (MensajeRegistro.Token != "0")
                {
                    WSCorreo.CorreoSoapClient correo1 = new WSCorreo.CorreoSoapClient();

                    if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", usuario.Email.Trim(), "Servicios Inmobiliarios G", "Verificación de cuenta SIG", HTML(MensajeRegistro, usuario)) == "Correo enviado") 
                    {
                        
                    }
                    mensaje.Respuesta = true;
                }
                else
                {
                    mensaje.Respuesta = false;
                    mensaje.Contenido = MensajeRegistro.RespuestaText;
                }
            }

            return mensaje;
        }
        public Models.Mensaje EnviarNuevoCorreo(Models.Usuarios usuario)
        {
            Models.Mensaje MensajeRegistro = _Usuario.Usuario_Selecionar_Toke_Email(usuario);
            Models.Mensaje mensaje = new Models.Mensaje();
            if (MensajeRegistro.Token != "0")
            {
                WSCorreo.CorreoSoapClient correo1 = new WSCorreo.CorreoSoapClient();

                if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", usuario.Email.Trim(), "Servicios Inmobiliarios G", "Verificación de cuenta SIG", HTML(MensajeRegistro, usuario)) == "Correo enviado") 
                {

                }
                mensaje.Respuesta = true;
            }
            else
            {
                mensaje.Respuesta = false;
                mensaje.Contenido = MensajeRegistro.RespuestaText;
            }

            return mensaje;
        }
        public Models.Mensaje ValidarNuevoRegistro(Models.Usuarios usuario)
        {
            Models.Mensaje mensaje = new Models.Mensaje();

            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            //if (Regex.IsMatch(seMailAComprobar, sFormato))


            if (!String.IsNullOrEmpty(usuario.Email))
            {
                //if (Regex.Replace(usuario.Email, expresion, String.Empty).Length == 0)
                //if (!Regex.IsMatch(usuario.Email, sFormato))
                //{
                    if (!String.IsNullOrEmpty(usuario.Password))
                    {
                        if (!String.IsNullOrEmpty(usuario.RepPassword))
                        {
                            if(usuario.Password == usuario.RepPassword)
                            {
                                // DATOS PERSONALES
                                if (!String.IsNullOrEmpty(usuario.Nombre))
                                {
                                    if (!String.IsNullOrEmpty(usuario.Apellidos))
                                    {
                                        if (!String.IsNullOrEmpty(usuario.Telefono))
                                        {
                                            if(usuario.Telefono.Trim().Length > 7)
                                            {
                                                if (ValidarTelefonos7a10Digitos(usuario.Telefono.Trim()))
                                                {
                                                    if (!String.IsNullOrEmpty(usuario.TelefonoMovil))
                                                    {
                                                        if (usuario.TelefonoMovil.Trim().Length > 7)
                                                        {
                                                            if (ValidarTelefonos7a10Digitos(usuario.Telefono.Trim()))
                                                            {
                                                                mensaje.Respuesta = true;
                                                                mensaje.Contenido = "OK";
                                                            }
                                                            else
                                                            {
                                                                mensaje.Respuesta = false;
                                                                mensaje.Contenido = "Número telefónico no valido";
                                                            }
                                                        }
                                                        else
                                                        {
                                                            mensaje.Respuesta = false;
                                                            mensaje.Contenido = "Número telefónico movil no valido";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        mensaje.Respuesta = false;
                                                        mensaje.Contenido = "Coloca tu teléfono movil";
                                                    }
                                                }
                                                else
                                                {
                                                    mensaje.Respuesta = false;
                                                    mensaje.Contenido = "Coloca tu teléfono movil";
                                                }
                                            }
                                            else
                                            {
                                                mensaje.Respuesta = false;
                                                mensaje.Contenido = "Número telefónico no valido";
                                            }
                                        }
                                        else
                                        {
                                            mensaje.Respuesta = false;
                                            mensaje.Contenido = "Coloca tu teléfono";
                                        }
                                    }
                                    else
                                    {
                                        mensaje.Respuesta = false;
                                        mensaje.Contenido = "Coloca tu apellido";
                                    }
                                }
                                else
                                {
                                    mensaje.Respuesta = false;
                                    mensaje.Contenido = "Coloca tu nombre";
                                }
                            }
                            else
                            {
                                mensaje.Respuesta = false;
                                mensaje.Contenido = "Password no coincide";
                            }
                        }
                        else
                        {
                            mensaje.Respuesta = false;
                            mensaje.Contenido = "Repite tu password";
                        }
                    }
                    else
                    {
                        mensaje.Respuesta = false;
                        mensaje.Contenido = "Coloca tu password";
                    }
                //}
                //else
                //{
                //    mensaje.Respuesta = false;
                //    mensaje.Contenido = "Email Incorreto";
                //}
            }
            else
            {
                mensaje.Respuesta = false;
                mensaje.Contenido = "Coloca tu Email";
            }

            return mensaje;
        }
        public Models.Usuarios Iniciar(Models.Usuarios usuarios)
        {
            Models.Usuarios user = _Usuario.Usuario_Selecionar_Pas_US(usuarios);
            return user;
        }
        public Models.Usuarios coo_Session_Seleccionar(string clave)
        {
            Models.Usuarios usuario = _Usuario.coo_Session_Seleccionar(clave);
            return usuario;
        }
        public List<Models.Usuarios> Usuarios_Listar()
        {
            List<Models.Usuarios> usuarios = _Usuario.Usuarios_Listar();
            return usuarios;
        }
        public static bool ValidarTelefonos7a10Digitos(string strNumber)
        {
            Regex regex = new Regex("\\A[0-9]{7,10}\\z");
            Match match = regex.Match(strNumber);

            if (match.Success)
                return true;
            else
                return false;
        }
        public string HTML(Models.Mensaje mensaje, Models.Usuarios usuario)
        {
            Correo.Formatos FormatoContenido = new Correo.Formatos();

            string HTML = FormatoContenido.NuevoUsuario(mensaje, usuario);

            return HTML;
        }
        public Models.Usuarios Usuarios_Seleccionar_IdUsuario(int IdUsuario)
        {
            Models.Usuarios usuarios = _Usuario.Usuarios_Seleccionar_IdUsuario(IdUsuario);
            return usuarios;
        }
        public Models.Mensaje Usuario_Actualizar(Models.Usuarios usuarios)
        {
            Models.Mensaje mensaje = _Usuario.Usuario_Actualizar(usuarios);
            return mensaje;
        }
        public Models.Mensaje Usuario_Actualizar_Password(Models.Usuarios usuarios)
        {
            Models.Mensaje mensaje = _Usuario.Usuario_Actualizar_Password(usuarios);
            return mensaje;
        }
        public Models.Usuarios Usuario_Selecionar_Password(Models.Usuarios usuarios)
        {
            Models.Usuarios usuarios1 = _Usuario.Usuario_Selecionar_Password(usuarios);
            
            if (usuarios1.Email.Length > 0)
            {
                WSCorreo.CorreoSoapClient correo1 = new WSCorreo.CorreoSoapClient();

                if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", usuarios1.Email.Trim(), "Servicios Inmobiliarios G", "Recuperación de contraseña", HTMLPassword(usuarios1)) == "Correo enviado")
                {
                    usuarios1.Mensaje = "Correo enviado";
                }
            }

            return usuarios1;
        }

        public string HTMLPassword(Models.Usuarios usuario)
        {
            Correo.Formatos FormatoContenido = new Correo.Formatos();

            string HTML = FormatoContenido.RecuperarPassword(usuario);

            return HTML;
        }
    }
}
