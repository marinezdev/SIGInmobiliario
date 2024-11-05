using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class EnviarCorreo
    {
        public string ProcesaDatos(Models.CorreoEmail model)
        {
            string respuesta = "";
            /*respuesta = model.email[0].nombre.ToString();*/
            validaciones validaciones = new validaciones();
            if (validaciones.EvaludaEmail(model) == "ok")
            {
                //WSCorreo.CorreoSoapClient correo = new WSCorreo.CorreoSoapClient();
                //if (correo.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", model.email[0].email, "SERVICIOS INMOBILIARIOS G", model.email[0].asunto.ToUpper().Trim(), HTML(model)) == "Correo enviado")
                //{
                //    // correo enviado
                //    respuesta = "ok";
                //}

                string host = "172.16.1.172";
                int puerto = 25;
                string usuario = "sig_contacto@serviciosinmobiliariosg.com";
                string contra = "$ig#Ct34$19$";
                string pCorreo = model.email[0].email.ToString().Trim();

                MailMessage correo = new MailMessage();
                correo.To.Add(new MailAddress(pCorreo));
                correo.From = new MailAddress(usuario, "SERVICIOS INMOBILIARIOS G");
                correo.Subject = model.email[0].asunto.ToString();
                correo.Body = HTML(model);

                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient(host, puerto);
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(usuario, contra);

                ServicePointManager.ServerCertificateValidationCallback =
                   delegate (object s
                       , System.Security.Cryptography.X509Certificates.X509Certificate certificate
                       , System.Security.Cryptography.X509Certificates.X509Chain chai
                       , SslPolicyErrors sslPolicyErrors)
                   {
                       return true;
                   };
                try
                {
                    smtp.Send(correo);
                    correo.Dispose();
                    respuesta = "ok";
                }
                catch (Exception ex)
                {
                    respuesta = "Error: " + ex.Message;
                }
            }
            else
            {
                respuesta = validaciones.EvaludaEmail(model);
            }

            return respuesta;
        }

        public string ProcesaDatosEmail(Models.CorreoEmail model)
        {
            string respuesta = "";
            /*respuesta = model.email[0].nombre.ToString();*/
            validaciones validaciones = new validaciones();
            if (validaciones.EvaludaEmailS(model) == "ok")
            {
                //WSCorreo.CorreoSoapClient correo = new WSCorreo.CorreoSoapClient();
                //if (correo.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", model.email[0].email, "SERVICIOS INMOBILIARIOS G", "SUSCRIPCIÓN", HTMLSuscripcion(model)) == "Correo enviado")
                //{
                //    // correo enviado
                //    respuesta = "ok";
                //}

                string host = "172.16.1.172";
                int puerto = 25;
                string usuario = "sig_contacto@serviciosinmobiliariosg.com";
                string contra = "$ig#Ct34$19$";
                string pCorreo = model.email[0].email.ToString().Trim();

                MailMessage correo = new MailMessage();
                correo.To.Add(new MailAddress(pCorreo));
                correo.From = new MailAddress(usuario, "SERVICIOS INMOBILIARIOS G");
                correo.Subject = "SUSCRIPCIÓN";
                correo.Body = HTMLSuscripcion(model);

                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient(host, puerto);
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(usuario, contra);

                ServicePointManager.ServerCertificateValidationCallback =
                   delegate (object s
                       , System.Security.Cryptography.X509Certificates.X509Certificate certificate
                       , System.Security.Cryptography.X509Certificates.X509Chain chai
                       , SslPolicyErrors sslPolicyErrors)
                   {
                       return true;
                   };
                try
                {
                    smtp.Send(correo);
                    correo.Dispose();
                    respuesta = "ok";
                }
                catch (Exception ex)
                {
                    respuesta = "Error: " + ex.Message;
                }
            }
            else
            {
                respuesta = validaciones.EvaludaEmailS(model);
            }

            return respuesta;
        }

        protected static string HTML(Models.CorreoEmail model)
        {
            string HTML = "<!DOCTYPE html>" +
                    "<html>" +
                    "<head>" +
                      "<title>Servicios inmobiliarios G una extensión para su empresa</title>" +
                      "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>" +
                        "<meta name='viewport' content='width=device-width, initial-scale=1'/>" +
                      "<meta name='viewport' content='width=device-width, initial-scale=1.0'>" +
                      "<meta charset='UTF-8'>" +
                    "</head>" +
                    "<style type='text/css'>" +
                    "</style>" +
                    "<body>" +
                      "<table style='border:none;'>" +
                        "<tr>" +
                          "<td width='100%' style='text-align: center;'>" +
                           "</td>" +
                        "</tr>" +
                        "<tr>" +
                          "<td style='background-color:  #579d9e;' height='5px'>" +
                          "</td>" +
                        "</tr>" +
                        "<tr>" +
                          "<td>" +
                              "<br><p style=' font-family: Arial; font-size: 32px; font-weight: bold; color: #00212D; text-align: center;'>¡Gracias por enviar tu mensaje!</p>" +
                              "<br>" +
                          "</td>" +
                        "</tr>" +
                        "<tr style='background-color: #F9F9F9; border: #F9F9F9;'>" +
                          "<td>" +
                              "<p style='font-family: Arial; font-size: 15px; color: #434245;'>Nombre: " +
                              "<a href='' style='text-decoration:none; font-family: Segoe UI Light; font-size: 15px; font-weight: bold; color: #636363; text-decoration-color: #2E75B6;'>" + model.email[0].nombre.ToLower() + "</a></p>" +
                          "</td>" +
                        "</tr>" +
                        "<tr style='background-color: #F9F9F9; border: #F9F9F9;'>" +
                          "<td>" +
                              "<p style='font-family: Arial; font-size: 15px; color: #434245;'>Email: " +
                              "<a href='' style='text-decoration:none; font-family: Segoe UI Light; font-size: 15px; font-weight: bold; color: #636363; text-decoration-color: #2E75B6;'>" + model.email[0].email + "</a></p>" +
                          "</td>" +
                        "</tr>" +
                        "<tr>" +
                          "<td>" +
                            "<p style='font-family: Segoe UI Light; font-size: 15px; color: #434245; text-align: justify;'><br>Mensaje:</p>" +
                            "<p style='font-family: Segoe UI Light; font-size: 15px; color: #434245; text-align: justify;'>" + model.email[0].mensaje.ToLower() + "</p>" +
                          "</td>" +
                        "</tr>" +
                        "<tr>" +
                          "<td>" +
                            "<p style='font-family: Segoe UI Light; font-size: 15px; color: #434245; text-align: justify;'><br>Te agradecemos que nos hayas contactado, en breve un ejecutivo te llamara para atender tus dudas y/o comentarios.</p><br style='margin-top: 0px;'>" +
                          "</td>" +
                        "</tr>" +
                        "<tr>" +
                          "<td>" +
                              "<p style='font-family: Arial; font-size: 30px; font-weight: bold; color: #434245; text-align: center;'>Gracias por utilizar nuestros servicios.</p>" +
                          "</td>" +
                        "</tr>" +
                        "<tr style='background-color: #E7E6E6; border: #E7E6E6; text-align: center;'>" +
                          "<td>" +
                              "<p style='font-family: Segoe UI Light; font-size: 15px; color: #505050'><br>Visita nuestra página oficial, <a href='www.serviciosinmobiliariosg.com.mx' style='font-weight: bold; color: #2E75B6;'>www.serviciosinmobiliariosg.com.mx</a></p>" +
                              "</p>" +
                            "<br>" +
                            "<br>" +
                          "</td>" +
                        "</tr>" +
                        "<tr>" +
                          "<td>" +
                            "<p style='font-family: Segoe UI Light; font-size: 13px; color: #939393; text-align: center;'><span>Servicios</span> <br> inmobiliarios <span>G</span> <br> una extensión para su empresa</p>" +
                          "</td>" +
                        "</tr>" +
                        "<tr>" +
                          "<td >" +
                            "<p style='font-family: Segoe UI Light; font-size: 13px; color: #939393; text-align: center;'>A.V Universidad 1627, Col. Hacienda de Guadalupe Chimalistac <br> Del.Álvaro Obregón, C.P. 01050, CDMX México. </p>" +
                          "</td>" +
                        "</tr>" +
                        "<tr>" +
                          "<td>" +
                            "<p style='font-family: Segoe UI Light; font-size: 13px; color: #939393; text-align: center;'>Teléfono : 55 2909 7024 / 55 3566 4390 </p>" +
                          "</td>" +
                        "</tr>" +
                        "<tr>" +
                          "<td>" +
                            "<p style='font-family: Segoe UI Light; font-size: 13px; color: #939393; text-align: center;'>Correo: sig_contacto@serviciosinmobiliariosg.com</p>" +
                          "</td>" +
                        "</tr>" +
                      "</table>" +
                    "</body>" +
                    "</html>";
            return HTML;
        }

        protected static string HTMLSuscripcion(Models.CorreoEmail model)
        {
            string HTML = "<!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                  "<title>Servicios inmobiliarios G una extensión para su empresa</title>" +
                  "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>" +
                    "<meta name='viewport' content='width=device-width, initial-scale=1'/>" +
                  "<meta name='viewport' content='width=device-width, initial-scale=1.0'>" +
                  "<meta charset='UTF-8'>" +
                "</head>" +
                "<style type='text/css'>" +
                "</style>" +
                "<body>" +
                  "<table style='border:none;'>" +
                    "<tr>" +
                      /*
                        "<td valign='center'>" +
                          "<p style='font-family: Arial; font-size: 25px; font-weight: bold; color: #141413;'><img src='logo.png'>&nbsp;&nbsp; Servicios inmobiliarios G una extensión para su empresa </p>" +
                        "</td>" +
                        */
                      "<td width='100%' style='text-align: center;'>" +
                    "</td>" +
                    "</tr>" +
                    "<tr>" +
                      "<td style='background-color:  #579d9e;' height='5px'>" +
                      "<br><br>" +
                      "</td>" +
                    "</tr>" +
                    "<tr>" +
                      "<td>" +
                          "<br><p style=' font-family: Arial; font-size: 32px; font-weight: bold; color: #00212D; text-align: center;'>¡Gracias por tu suscripción!</p>" +
                          "<br>" +
                      "</td>" +
                    "</tr>" +
                    "<tr style='background-color: #F9F9F9; border: #F9F9F9;'>" +
                      "<td>" +
                          "<p style='font-family: Arial; font-size: 15px; color: #434245;'>Email: " +
                          "<a href='' style='text-decoration:none; font-family: Segoe UI Light; font-size: 15px; font-weight: bold; color: #636363; text-decoration-color: #2E75B6;'>" + model.email[0].email + "</a></p>" +
                      "</td>" +
                    "</tr >" +
                    "<tr>" +
                      "<td>" +
                        "<p style='font-family: Segoe UI Light; font-size: 15px; color: #434245; text-align: justify;'><br>Recibirás un correo con todos los contenidos, noticias y publicaciones.</p><br style='margin-top: 0px;'>" +
                      "</td>" +
                    "</tr>" +
                    "<tr>" +
                      "<td>" +
                          "<p style='font-family: Arial; font-size: 30px; font-weight: bold; color: #434245; text-align: center;'>Gracias por utilizar nuestros servicios.</p>" +
                      "</td>" +
                    "</tr>" +
                    "<tr style='background-color: #E7E6E6; border: #E7E6E6; text-align: center;'>" +
                      "<td>" +
                          "<p style='font-family: Segoe UI Light; font-size: 15px; color: #505050'><br>Visita nuestra página oficial, <a href='www.serviciosinmobiliariosg.com.mx' style='font-weight: bold; color: #2E75B6;'>www.serviciosinmobiliariosg.com.mx</a></p>" +
                          "</p>" +
                        "<br>" +
                        "<br>" +
                      "</td>" +
                    "</tr>" +
                    "<tr>" +
                      "<td >" +
                        "<p style='font-family: Segoe UI Light; font-size: 13px; color: #010429; text-align: center;'><span>Servicios</span> <br> inmobiliarios <span>G</span> <br> una extensión para su empresa </p>" +
                      "</td>" +
                    "</tr>" +
                    "<tr>" +
                      "<td >" +
                        "<p style='font-family: Segoe UI Light; font-size: 13px; color: #939393; text-align: center;'>A.V Universidad 1627, Col. Hacienda de Guadalupe Chimalistac <br> Del.Álvaro Obregón, C.P. 01050, CDMX México.</p>" +
                      "</td>" +
                    "</tr>" +
                    "<tr>" +
                      "<td >" +
                        "<p style='font-family: Segoe UI Light; font-size: 13px; color: #939393; text-align: center;'>Teléfonos : 55 2909 7024 / 55 3566 4390 </p>" +
                      "</td>" +
                    "</tr>" +
                    "<tr>" +
                      "<td >" +
                        "<p style='font-family: Segoe UI Light; font-size: 13px; color: #939393; text-align: center;'>Correo: sig_contacto@serviciosinmobiliariosg.com</p>" +
                      "</td>" +
                    "</tr>" +
                  "</table>" +
                "</body>" +
                "</html>";
            return HTML;
        }
    }
}
