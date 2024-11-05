using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SIG_WebApplication.Application.Correo
{
    public class FormatosLlamada
    {
        public string LlamadaAnunciante(Models.Correo correo, string direccion)
        {
            string host = HttpContext.Current.Request.Url.Authority;

            string html = "" +

"<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>" +
"<html xmlns:v='urn:schemas-microsoft-com:vml'>" +
"<head>" +
"<meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />" +
"<meta name='viewport' content='width=device-width; initial-scale=1.0; maximum-scale=1.0;' />" +
"<!--[if !mso]--><!-- -->" +
"<link href='https://fonts.googleapis.com/css?family=Work+Sans:300,400,500,600,700' rel='stylesheet'>" +
"<link href='https://fonts.googleapis.com/css?family=Quicksand:300,400,700' rel='stylesheet'> " +
"<!--<![endif]--> " +

"<title>Material Design for Bootstrap</title> " +

"<style type='text/css'> " +
"body {" +
"width: 100%;" +
"background-color: #ffffff;" +
"margin: 0;" +
"padding: 0;" +
"-webkit-font-smoothing: antialiased;" +
"mso-margin-top-alt: 0px;" +
"mso-margin-bottom-alt: 0px;" +
"mso-padding-alt: 0px 0px 0px 0px;" +
"font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;" +
"}" +

"p," +
"h1," +
"h2," +
"h3," +
"h4 {" +
"margin -top: 0;" +
"margin-bottom: 0;" +
"padding-top: 0;" +
"padding-bottom: 0;" +
"}" +

"span.preheader {" +
"display: none;" +
"font-size: 1px;" +
"}" +

"html {" +
"width: 100%;" +
"}" +

"table {" +
"font-size: 14px;" +
"border: 0;" +
"}" +
"/* ----------- responsivity ----------- */" +

"@media only screen and (max-width: 640px) {" +
"/*------ top header ------ */" +
".main-header {" +
    "font-size: 20px !important;" +
"}" +
".main-section-header {" +
    "font-size: 28px !important;" +
"}" +
".show {" +
    "display: block !important;" +
"}" +
".hide {" +
    "display: none !important;" +
"}" +
".align-center {" +
    "text-align: center !important;" +
"}" +
".no-bg {" +
    "background: none !important;" +
"}" +
"/*----- main image -------*/" +
".main-image img {" +
    "width: 440px !important;" +
    "height: auto !important;" +
"}" +
"/* ====== divider ====== */" +
".divider img {" +
    "width: 440px !important;" +
"}" +
"/*-------- container --------*/" +
".container590 {" +
    "width: 440px !important;" +
"}" +
".container580 {" +
    "width: 400px !important;" +
"}" +
".main-button {" +
    "width: 220px !important;" +
"}" +
"/*-------- secions ----------*/" +
".section-img img {" +
    "width: 320px !important;" +
    "height: auto !important;" +
"}" +
".team-img img {" +
    "width: 100% !important;" +
    "height: auto !important;" +
"}" +
"}" +

"@media only screen and (max-width: 479px) {" +
"/*------ top header ------ */" +
".main-header {" +
    "font-size: 18px !important;" +
"}" +
".main-section-header {" +
    "font-size: 26px !important;" +
"}" +
"/* ====== divider ====== */" +
".divider img {" +
    "width: 280px !important;" +
"}" +
"/*-------- container --------*/" +
".container590 {" +
    "width: 280px !important;" +
"}" +
".container590 {" +
   "width: 280px !important;" +
"}" +
".container580 {" +
    "width: 260px !important;" +
"}" +
"/*-------- secions ----------*/" +
".section-img img {" +
    "width: 280px !important;" +
    "height: auto !important;" +
"}" +
"}" +
"</style>" +
"<!--[if gte mso 9]><style type=”text/css”>" +
"body {" +
"font-family: arial, sans-serif!important;" +
"}" +
"</style>" +
"<![endif]-->" +
"</head>" +


"<body class='respond' leftmargin='0' topmargin='0' marginwidth='0' marginheight='0'>" +
"<!-- pre-header -->" +
"<table style='display:none!important;'>" +
"<tr>" +
"<td>" +
    "<div style='overflow:hidden;display:none;font-size:1px;color:#ffffff;line-height:1px;font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;maxheight:0px;max-width:0px;opacity:0;'>" +
        "Bienvenido a SIG!" +
    "</div>" +
"</td>" +
"</tr>" +
"</table>" +
"<!-- pre-header end -->" +
"<!-- header -->" +
"<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='ffffff'>" +

"<tr>" +
"<td align='center'>" +
    "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +

        "<tr>" +
            "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
        "</tr>" +

        "<tr>" +
            "<td align='center'>" +

                "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +
                    "<tr style='background-color: #15436d ;'>" +
                        "<td align='center'>" +
                            "<table width='360 ' border='0' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                "class='container590 hide'>" +
                                "<tr>" +
                                    "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;'>" +
                                        "<a href='' style='color: #312c32; text-decoration: none;'><br> </a>" +
                                    "</td>" +
                                    "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;line-height: 24px;'>" +
                                        "<a href='' style='color: #312c32; text-decoration: none;'><br>  </a>" +
                                    "</td>" +
                                    "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;line-height: 24px;'>" +
                                        "<a href='' style='color: #312c32; text-decoration: none;'><br>  </a>" +
                                    "</td>" +
                                "</tr>" +
                            "</table>" +
                        "</td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td>" +
                            "<br><br>" +
                        "<td>" +
                    "</tr>" +
                    "<tr>" +
                        "<td align='center' height='70' style='height:70px;'>" +
                            "<a href='' style='display: block; border-style: none !important; border: 0 !important;'><img width='200' border='0' style='display: block; width: 200px;' src='http://www.serviciosinmobiliariosg.com.mx/01/Logo.png' alt='' /></a>" +
                            "<br><br>" +
                        "</td>" +
                    "</tr>" +

                    "<tr style='background-color: #15436d ;'>" +
                        "<td align='center'>" +
                            "<table width='360 ' border='0' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                "class='container590 hide'>" +
                                "<tr>" +
                                    "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;'>" +
                                        "<a href='http://www.serviciosinmobiliariosg.com.mx/' style='color: #ffffff; text-decoration: none;'>Pagina Web </a>" +
                                    "</td>" +
                                    "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;line-height: 24px;'>" +
                                        "<a href='http://www.serviciosinmobiliariosg.com.mx/home/Ayuda' style='color: #ffffff; text-decoration: none;'>Ayuda </a>" +
                                    "</td>" +
                                    "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;line-height: 24px;'>" +
                                        "<a href='' style='color: #ffffff; text-decoration: none;'>Políticas de Privacidad </a>" +
                                    "</td>" +
                                "</tr>" +
                            "</table>" +
                        "</td>" +
                    "</tr>" +
                "</table>" +
            "</td>" +
        "</tr>" +

        "<tr>" +
            "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
        "</tr>" +

    "</table>" +
"</td>" +
"</tr>" +
"</table>" +
"<!-- end header -->" +

"<!-- big image section -->" +

"<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='ffffff' class='bg_color'>" +

"<tr>" +
"<td align='center'>" +
    "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +

        "<tr>" +
            "<td align='center' style='color: #343434; font-size: 24px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-weight:700;letter-spacing: 3px; line-height: 35px;'" +
                "class='main-header'>" +
                "<!-- section text ======-->" +

                "<div style='line-height: 35px'>" +

                    "Servicios <span style='color: #15436d;'> Inmobiliarios G</span>" +

                "</div>" +
            "</td>" +
        "</tr>" +

        "<tr>" +
            "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
        "</tr>" +

        "<tr>" +
            "<td align='center'>" +
                "<table border='0' width='40' align='center' cellpadding='0' cellspacing='0' bgcolor='eeeeee'>" +
                    "<tr>" +
                        "<td height='2' style='font-size: 2px; line-height: 2px;'>&nbsp;</td>" +
                    "</tr>" +
                "</table>" +
            "</td>" +
        "</tr>" +

        "<tr>" +
            "<td height='20' style='font-size: 20px; line-height: 20px;'>&nbsp;</td>" +
        "</tr>" +

        "<tr>" +
            "<td align='left'>" +
                "<table border='0' width='590' align='center' cellpadding='0' cellspacing='0' class='container590'>" +
                    "<tr>" +
                        "<td align='left' style='color: #888888; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;'>" +
                            "<!-- section text ======-->" +
                            "<p style='line-height: 24px; margin-bottom:15px;'>" +

                                "Buen día: <strong> " + correo.Nombre + "</strong>" +

                            "</p>" +
                            "<p style='line-height: 24px;margin-bottom:15px;'>" +
                                "Han visualizado un inmueble publicado por parte tuya, el interesado desea que te comuniques a través de una llamada telefónica a la brevedad." +
                                "<br>" +
                                "Información del contacto:" +
                                "<br>" +
                                "Nombre : <strong>" + correo.NombreContacto + "</strong>" +
                                "<br> " +
                                "Teléfono : <strong>" + correo.Telefono + "</strong>" +
                                "<br>" +
                                "Si deseas visualizar dicho inmueble, puedes dar clic en el siguiente botón." +
                            "</p>" +

                            "<table border='0' align='center' width='180' cellpadding='0' cellspacing='0' bgcolor='15436d' style='margin-bottom:20px;border-radius: 10px 10px 10px 10px;-moz-border-radius: 10px 10px 10px 10px;-webkit-border-radius: 10px 10px 10px 10px;border: 0px solid #000000;'>" +

                                "<tr>" +
                                    "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
                                "</tr>" +

                                "<tr>" +
                                    "<td align='center' style='color: #ffffff; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 22px;'>" +
                                        "<!-- main section button -->" +

                                        "<div style='line-height: 22px;'>" +
                                            "<a href='" + direccion + "' style='color: #ffffff; text-decoration: none; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;'><STRONG>Inmueble </STRONG> </a>" +
                                        "</div>" +
                                    "</td>" +
                                "</tr>" +

                                "<tr>" +
                                    "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
                                "</tr>" +

                            "</table>" +

                        "</td>" +
                    "</tr>" +
                "</table>" +
            "</td>" +
        "</tr>" +

    "</table>" +

"</td>" +
"</tr>" +

"<tr>" +
"<td height='40' style='font-size: 40px; line-height: 40px;'>&nbsp;</td>" +
"</tr>" +
"</table>" +
"<!-- end section -->" +

"<!-- main section -->" +
"<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='2a2e36'>" +

"<tr>" +
"<td align='center' style='background-image: url(http://www.serviciosinmobiliariosg.com.mx/01/offica-home.jpg); background-size: cover; background-position: top center; background-repeat: no-repeat;'" +
    "background='http://www.serviciosinmobiliariosg.com.mx/01/offica-home.jpg'>" +

    "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +

        "<tr>" +
            "<td height='50' style='font-size: 50px; line-height: 50px;'>&nbsp;</td>" +
        "</tr>" +

        "<tr>" +
            "<td align='center'>" +
                "<table border='0' width='380' align='center' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                    "class='container590'>" +

                    "<tr>" +
                        "<td align='center'>" +
                            "<table border='0' align='center' cellpadding='0' cellspacing='0' class='container580'>" +
                                "<tr>" +
                                    "<td align='center' style='color: #ffffff; background-color: #bfbfbfc9; font-size: 16px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 26px;'>" +
                                        "<!-- section text ======-->" +

                                        "<div style='line-height: 26px'>" +

                                            "Quiere recibir información, suscribirte y recibe nuestras ultimas publicaciones" +

                                        "</div>" +
                                    "</td>" +
                                "</tr>" +
                            "</table>" +
                        "</td>" +
                    "</tr>" +

                "</table>" +
            "</td>" +
        "</tr>" +

        "<tr>" +
            "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
        "</tr>" +

        "<tr>" +
            "<td align='center'>" +
                "<table border='0' align='center' width='250' cellpadding='0' cellspacing='0' style='border:2px solid #ffffff;'>" +

                    "<tr>" +
                        "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td align='center' style='color: #ffffff; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 22px; letter-spacing: 2px;'>" +
                            "<!-- main section button -->" +

                            "<div style='line-height: 22px;'>" +
                                "<a href='http://www.serviciosinmobiliariosg.com.mx/home/Contacto' style='color: #fff; background-color: #bfbfbfc9; text-decoration: none;'>SUSCRIBIRME </a>" +
                            "</div>" +
                        "</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
                    "</tr>" +

                "</table>" +
            "</td>" +
        "</tr>" +


        "<tr>" +
            "<td height='50' style='font-size: 50px; line-height: 50px;'>&nbsp;</td>" +
        "</tr>" +

    "</table>" +
"</td>" +
"</tr>" +

"</table>" +

"<!-- end section -->" +

"<!-- contact section -->" +
"<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='ffffff' class='bg_color'>" +

"<tr>" +
"<td height='60' style='font-size: 60px; line-height: 60px;'>&nbsp;</td>" +
"</tr>" +

"<tr>" +
"<td align='center'>" +
    "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590 bg_color'>" +

        "<tr>" +
            "<td align='center'>" +
                "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590 bg_color'>" +

                    "<tr>" +
                        "<td>" +
                            "<table border='0' width='300' align='left' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                "class='container590'>" +

                                "<tr>" +
                                    "<!-- logo -->" +
                                    "<td align='left'>" +
                                        "<a href='' style='display: block; border-style: none !important; border: 0 !important;'><img width='80' border='0' style='display: block; width: 80px;' src='http://www.serviciosinmobiliariosg.com.mx/01/Logo.png' alt='' /></a>" +
                                    "</td>" +
                                "</tr>" +

                                "<tr>" +
                                    "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
                                "</tr>" +

                                "<tr>" +
                                    "<td align='left' style='color: #888888; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 23px;'" +
                                        "class='text_color'>" +
                                        "<div style='color: #333333; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-weight: 600; mso-line-height-rule: exactly; line-height: 23px;'>" +

                                            "Email contacto: <br/> <a href='mailto:' style='color: #888888; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-weight: 400;'>sig_contacto@serviciosinmobiliariosg.com </a>" +

                                        "</div>" +
                                    "</td>" +
                                "</tr>" +

                            "</table>" +

                            "<table border='0' width='2' align='left' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                "class='container590'>" +
                                "<tr>" +
                                    "<td width='2' height='10' style='font-size: 10px; line-height: 10px;'></td>" +
                                "</tr>" +
                            "</table>" +

                            "<table border='0' width='200' align='right' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                "class='container590'>" +

                                "<tr>" +
                                    "<td class='hide' height='45' style='font-size: 45px; line-height: 45px;'>&nbsp;</td>" +
                                "</tr>" +



                                "<tr>" +
                                    "<td height='15' style='font-size: 15px; line-height: 15px;'>&nbsp;</td>" +
                                "</tr>" +

                                "<tr>" +
                                    "<td>" +
                                        "<table border='0' align='right' cellpadding='0' cellspacing='0'>" +
                                            "<tr>" +
                                                "<td>" +
                                                    "<a href='#p' style='display: block; border-style: none !important; border: 0 !important;'><img width='24' border='0' style='display: block;' src='http://i.imgur.com/Qc3zTxn.png' alt=''></a>" +
                                                "</td>" +
                                                "<td>&nbsp;&nbsp;&nbsp;&nbsp;</td>" +
                                                "<td>" +
                                                    "<a href='#' style='display: block; border-style: none !important; border: 0 !important;'><img width='24' border='0' style='display: block;' src='http://i.imgur.com/RBRORq1.png' alt=''></a>" +
                                                "</td>" +
                                                "<td>&nbsp;&nbsp;&nbsp;&nbsp;</td>" +
                                                "<td>" +
                                                    "<a href='#' style='display: block; border-style: none !important; border: 0 !important;'><img width='24' border='0' style='display: block;' src='http://i.imgur.com/Wji3af6.png' alt=''></a>" +
                                                "</td>" +
                                            "</tr>" +
                                        "</table>" +
                                    "</td>" +
                                "</tr>" +

                            "</table>" +
                        "</td>" +
                    "</tr>" +
                "</table>" +
            "</td>" +
        "</tr>" +
    "</table>" +
"</td>" +
"</tr>" +

"<tr>" +
"<td height='60' style='font-size: 60px; line-height: 60px;'>&nbsp;</td>" +
"</tr>" +

"</table>" +
"<!-- end section -->" +

"<!-- footer ====== -->" +
"<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='f4f4f4'>" +

"<tr>" +
"<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
"</tr>" +

"<tr>" +
"<td align='center'>" +

    "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +

        "<tr>" +
            "<td>" +
                "<table border='0' align='left' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                    "class='container590'>" +
                    "<tr>" +
                        "<td align='left' style='color: #aaaaaa; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;'>" +
                            "<div style='line-height: 24px;'>" +

                                "<span style='color: #333333;'>Copyright &copy; Todos los derechos reservados |<a href='#' style='color: #17a2b8' target='_blank'> Servicios inmobiliarios G </a></span>" +

                            "</div>" +
                        "</td>" +
                    "</tr>" +
                "</table>" +

                "<table border='0' align='left' width='5' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                    "class='container590'>" +
                    "<tr>" +
                        "<td height='20' width='5' style='font-size: 20px; line-height: 20px;'>&nbsp;</td>" +
                    "</tr>" +
                "</table>" +

                "<table border='0' align='right' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                    "class='container590'>" +

                    "<tr>" +
                        "<td align='center'>" +
                            "<table align='center' border='0' cellpadding='0' cellspacing='0'>" +
                                "<tr>" +
                                    "<td align='center'>" +
                                        "<a style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;color: #17a2b8; text-decoration: none;font-weight:bold;'" +
                                            "href='http://www.serviciosinmobiliariosg.com.mx/home/Contacto'>SUSCRIBIRME</a>" +
                                    "</td>" +
                                "</tr>" +
                            "</table>" +
                        "</td>" +
                    "</tr>" +

                "</table>" +
            "</td>" +
        "</tr>" +

    "</table>" +
"</td>" +
"</tr>" +

"<tr>" +
"<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
"</tr>" +

"</table>" +
"<!-- end footer ====== -->" +

"</body>" +

"</html>";



            return html;
        }

        public string LlamadaCliente(Models.Correo correo, string direccion)
        {
            string host = HttpContext.Current.Request.Url.Authority;

            string html = "" +

            "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>" +
"<html xmlns:v='urn:schemas-microsoft-com:vml'>" +
"<head>" +
    "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />" +
    "<meta name='viewport' content='width=device-width; initial-scale=1.0; maximum-scale=1.0;' />" +
    "<!--[if !mso]--><!-- -->" +
    "<link href='https://fonts.googleapis.com/css?family=Work+Sans:300,400,500,600,700' rel='stylesheet'>" +
    "<link href='https://fonts.googleapis.com/css?family=Quicksand:300,400,700' rel='stylesheet'> " +
    "<!--<![endif]--> " +

    "<title>Material Design for Bootstrap</title> " +

    "<style type='text/css'> " +
        "body {" +
            "width: 100%;" +
            "background-color: #ffffff;" +
            "margin: 0;" +
            "padding: 0;" +
            "-webkit-font-smoothing: antialiased;" +
            "mso-margin-top-alt: 0px;" +
            "mso-margin-bottom-alt: 0px;" +
            "mso-padding-alt: 0px 0px 0px 0px;" +
            "font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;" +
        "}" +

        "p," +
        "h1," +
        "h2," +
        "h3," +
        "h4 {" +
            "margin -top: 0;" +
            "margin-bottom: 0;" +
            "padding-top: 0;" +
            "padding-bottom: 0;" +
        "}" +

        "span.preheader {" +
            "display: none;" +
            "font-size: 1px;" +
        "}" +

        "html {" +
            "width: 100%;" +
        "}" +

        "table {" +
            "font-size: 14px;" +
            "border: 0;" +
        "}" +
        "/* ----------- responsivity ----------- */" +

        "@media only screen and (max-width: 640px) {" +
            "/*------ top header ------ */" +
            ".main-header {" +
                "font-size: 20px !important;" +
            "}" +
            ".main-section-header {" +
                "font-size: 28px !important;" +
            "}" +
            ".show {" +
                "display: block !important;" +
            "}" +
            ".hide {" +
                "display: none !important;" +
            "}" +
            ".align-center {" +
                "text-align: center !important;" +
            "}" +
            ".no-bg {" +
                "background: none !important;" +
            "}" +
            "/*----- main image -------*/" +
            ".main-image img {" +
                "width: 440px !important;" +
                "height: auto !important;" +
            "}" +
            "/* ====== divider ====== */" +
            ".divider img {" +
                "width: 440px !important;" +
            "}" +
            "/*-------- container --------*/" +
            ".container590 {" +
                "width: 440px !important;" +
            "}" +
            ".container580 {" +
                "width: 400px !important;" +
            "}" +
            ".main-button {" +
                "width: 220px !important;" +
            "}" +
            "/*-------- secions ----------*/" +
            ".section-img img {" +
                "width: 320px !important;" +
                "height: auto !important;" +
            "}" +
            ".team-img img {" +
                "width: 100% !important;" +
                "height: auto !important;" +
            "}" +
        "}" +

        "@media only screen and (max-width: 479px) {" +
            "/*------ top header ------ */" +
            ".main-header {" +
                "font-size: 18px !important;" +
            "}" +
            ".main-section-header {" +
                "font-size: 26px !important;" +
            "}" +
            "/* ====== divider ====== */" +
            ".divider img {" +
                "width: 280px !important;" +
            "}" +
            "/*-------- container --------*/" +
            ".container590 {" +
                "width: 280px !important;" +
            "}" +
            ".container590 {" +
               "width: 280px !important;" +
            "}" +
            ".container580 {" +
                "width: 260px !important;" +
            "}" +
            "/*-------- secions ----------*/" +
            ".section-img img {" +
                "width: 280px !important;" +
                "height: auto !important;" +
            "}" +
        "}" +
    "</style>" +
    "<!--[if gte mso 9]><style type=”text/css”>" +
        "body {" +
        "font-family: arial, sans-serif!important;" +
        "}" +
        "</style>" +
    "<![endif]-->" +
"</head>" +


"<body class='respond' leftmargin='0' topmargin='0' marginwidth='0' marginheight='0'>" +
    "<!-- pre-header -->" +
    "<table style='display:none!important;'>" +
        "<tr>" +
            "<td>" +
                "<div style='overflow:hidden;display:none;font-size:1px;color:#ffffff;line-height:1px;font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;maxheight:0px;max-width:0px;opacity:0;'>" +
                    "Bienvenido a SIG!" +
                "</div>" +
            "</td>" +
        "</tr>" +
    "</table>" +
    "<!-- pre-header end -->" +
    "<!-- header -->" +
    "<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='ffffff'>" +

        "<tr>" +
            "<td align='center'>" +
                "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +

                    "<tr>" +
                        "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td align='center'>" +

                            "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +
                                "<tr style='background-color: #15436d ;'>" +
                                    "<td align='center'>" +
                                        "<table width='360 ' border='0' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                            "class='container590 hide'>" +
                                            "<tr>" +
                                                "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;'>" +
                                                    "<a href='' style='color: #312c32; text-decoration: none;'><br> </a>" +
                                                "</td>" +
                                                "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;line-height: 24px;'>" +
                                                    "<a href='' style='color: #312c32; text-decoration: none;'><br>  </a>" +
                                                "</td>" +
                                                "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;line-height: 24px;'>" +
                                                    "<a href='' style='color: #312c32; text-decoration: none;'><br>  </a>" +
                                                "</td>" +
                                            "</tr>" +
                                        "</table>" +
                                    "</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>" +
                                        "<br><br>" +
                                    "<td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td align='center' height='70' style='height:70px;'>" +
                                        "<a href='' style='display: block; border-style: none !important; border: 0 !important;'><img width='200' border='0' style='display: block; width: 200px;' src='http://www.serviciosinmobiliariosg.com.mx/01/Logo.png' alt='' /></a>" +
                                        "<br><br>" +
                                    "</td>" +
                                "</tr>" +

                                "<tr style='background-color: #15436d ;'>" +
                                    "<td align='center'>" +
                                        "<table width='360 ' border='0' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                            "class='container590 hide'>" +
                                            "<tr>" +
                                                "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;'>" +
                                                    "<a href='http://www.serviciosinmobiliariosg.com.mx/' style='color: #ffffff; text-decoration: none;'>Pagina Web </a>" +
                                                "</td>" +
                                                "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;line-height: 24px;'>" +
                                                    "<a href='http://www.serviciosinmobiliariosg.com.mx/home/Ayuda' style='color: #ffffff; text-decoration: none;'>Ayuda </a>" +
                                                "</td>" +
                                                "<td width='120' align='center' style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;line-height: 24px;'>" +
                                                    "<a href='' style='color: #ffffff; text-decoration: none;'>Políticas de Privacidad </a>" +
                                                "</td>" +
                                            "</tr>" +
                                        "</table>" +
                                    "</td>" +
                                "</tr>" +
                            "</table>" +
                        "</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
                    "</tr>" +

                "</table>" +
            "</td>" +
        "</tr>" +
    "</table>" +
    "<!-- end header -->" +

    "<!-- big image section -->" +

    "<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='ffffff' class='bg_color'>" +

        "<tr>" +
            "<td align='center'>" +
                "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +

                    "<tr>" +
                        "<td align='center' style='color: #343434; font-size: 24px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-weight:700;letter-spacing: 3px; line-height: 35px;'" +
                            "class='main-header'>" +
                            "<!-- section text ======-->" +

                            "<div style='line-height: 35px'>" +

                                "Servicios <span style='color: #15436d;'> Inmobiliarios G</span>" +

                            "</div>" +
                        "</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td align='center'>" +
                            "<table border='0' width='40' align='center' cellpadding='0' cellspacing='0' bgcolor='eeeeee'>" +
                                "<tr>" +
                                    "<td height='2' style='font-size: 2px; line-height: 2px;'>&nbsp;</td>" +
                                "</tr>" +
                            "</table>" +
                        "</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td height='20' style='font-size: 20px; line-height: 20px;'>&nbsp;</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td align='left'>" +
                            "<table border='0' width='590' align='center' cellpadding='0' cellspacing='0' class='container590'>" +
                                "<tr>" +
                                    "<td align='left' style='color: #888888; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;'>" +
                                        "<!-- section text ======-->" +
                                        "<p style='line-height: 24px; margin-bottom:15px;'>" +

                                            "Buen día: <strong> " + correo.NombreContacto + "</strong>" +

                                        "</p>" +
                                        "<p style='line-height: 24px;margin-bottom:15px;'>" +
                                            "Usted ha enviado un email con su numero telefónico <strong>"+ correo.Telefono + "</strong>  al anunciante." +
                                            "<br>" +
                                            "El anúnciate ha sido notificado sobre el inmueble de su interés." +
                                            "<br>" +
                                            "Si deseas visualizar dicho inmueble, puedes dar clic en el siguiente botón." +
                                        "</p>" +

                                        "<table border='0' align='center' width='180' cellpadding='0' cellspacing='0' bgcolor='15436d' style='margin-bottom:20px;border-radius: 10px 10px 10px 10px;-moz-border-radius: 10px 10px 10px 10px;-webkit-border-radius: 10px 10px 10px 10px;border: 0px solid #000000;'>" +

                                            "<tr>" +
                                                "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td align='center' style='color: #ffffff; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 22px;'>" +
                                                    "<!-- main section button -->" +

                                                    "<div style='line-height: 22px;'>" +
                                                        "<a href='" + direccion + "' style='color: #ffffff; text-decoration: none; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;'><STRONG>Inmueble </STRONG> </a>" +
                                                    "</div>" +
                                                "</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
                                            "</tr>" +

                                        "</table>" +

                                    "</td>" +
                                "</tr>" +
                            "</table>" +
                        "</td>" +
                    "</tr>" +

                "</table>" +

            "</td>" +
        "</tr>" +

        "<tr>" +
            "<td height='40' style='font-size: 40px; line-height: 40px;'>&nbsp;</td>" +
        "</tr>" +
    "</table>" +
    "<!-- end section -->" +

    "<!-- main section -->" +
    "<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='2a2e36'>" +

        "<tr>" +
            "<td align='center' style='background-image: url(http://www.serviciosinmobiliariosg.com.mx/01/offica-home.jpg); background-size: cover; background-position: top center; background-repeat: no-repeat;'" +
                "background='http://www.serviciosinmobiliariosg.com.mx/01/offica-home.jpg'>" +

                "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +

                    "<tr>" +
                        "<td height='50' style='font-size: 50px; line-height: 50px;'>&nbsp;</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td align='center'>" +
                            "<table border='0' width='380' align='center' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                "class='container590'>" +

                                "<tr>" +
                                    "<td align='center'>" +
                                        "<table border='0' align='center' cellpadding='0' cellspacing='0' class='container580'>" +
                                            "<tr>" +
                                                "<td align='center' style='color: #ffffff; background-color: #bfbfbfc9; font-size: 16px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 26px;'>" +
                                                    "<!-- section text ======-->" +

                                                    "<div style='line-height: 26px'>" +

                                                        "Quiere recibir información, suscribirte y recibe nuestras ultimas publicaciones" +

                                                    "</div>" +
                                                "</td>" +
                                            "</tr>" +
                                        "</table>" +
                                    "</td>" +
                                "</tr>" +

                            "</table>" +
                        "</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<td align='center'>" +
                            "<table border='0' align='center' width='250' cellpadding='0' cellspacing='0' style='border:2px solid #ffffff;'>" +

                                "<tr>" +
                                    "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
                                "</tr>" +

                                "<tr>" +
                                    "<td align='center' style='color: #ffffff; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 22px; letter-spacing: 2px;'>" +
                                        "<!-- main section button -->" +

                                        "<div style='line-height: 22px;'>" +
                                            "<a href='http://www.serviciosinmobiliariosg.com.mx/home/Contacto' style='color: #fff; background-color: #bfbfbfc9; text-decoration: none;'>SUSCRIBIRME </a>" +
                                        "</div>" +
                                    "</td>" +
                                "</tr>" +

                                "<tr>" +
                                    "<td height='10' style='font-size: 10px; line-height: 10px;'>&nbsp;</td>" +
                                "</tr>" +

                            "</table>" +
                        "</td>" +
                    "</tr>" +


                    "<tr>" +
                        "<td height='50' style='font-size: 50px; line-height: 50px;'>&nbsp;</td>" +
                    "</tr>" +

                "</table>" +
            "</td>" +
        "</tr>" +

    "</table>" +

    "<!-- end section -->" +

    "<!-- contact section -->" +
    "<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='ffffff' class='bg_color'>" +

        "<tr>" +
            "<td height='60' style='font-size: 60px; line-height: 60px;'>&nbsp;</td>" +
        "</tr>" +

        "<tr>" +
            "<td align='center'>" +
                "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590 bg_color'>" +

                    "<tr>" +
                        "<td align='center'>" +
                            "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590 bg_color'>" +

                                "<tr>" +
                                    "<td>" +
                                        "<table border='0' width='300' align='left' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                            "class='container590'>" +

                                            "<tr>" +
                                                "<!-- logo -->" +
                                                "<td align='left'>" +
                                                    "<a href='' style='display: block; border-style: none !important; border: 0 !important;'><img width='80' border='0' style='display: block; width: 80px;' src='http://www.serviciosinmobiliariosg.com.mx/01/Logo.png' alt='' /></a>" +
                                                "</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td align='left' style='color: #888888; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 23px;'" +
                                                    "class='text_color'>" +
                                                    "<div style='color: #333333; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-weight: 600; mso-line-height-rule: exactly; line-height: 23px;'>" +

                                                        "Email contacto: <br/> <a href='mailto:' style='color: #888888; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; font-weight: 400;'>sig_contacto@serviciosinmobiliariosg.com </a>" +

                                                    "</div>" +
                                                "</td>" +
                                            "</tr>" +

                                        "</table>" +

                                        "<table border='0' width='2' align='left' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                            "class='container590'>" +
                                            "<tr>" +
                                                "<td width='2' height='10' style='font-size: 10px; line-height: 10px;'></td>" +
                                            "</tr>" +
                                        "</table>" +

                                        "<table border='0' width='200' align='right' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                            "class='container590'>" +

                                            "<tr>" +
                                                "<td class='hide' height='45' style='font-size: 45px; line-height: 45px;'>&nbsp;</td>" +
                                            "</tr>" +



                                            "<tr>" +
                                                "<td height='15' style='font-size: 15px; line-height: 15px;'>&nbsp;</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td>" +
                                                    "<table border='0' align='right' cellpadding='0' cellspacing='0'>" +
                                                        "<tr>" +
                                                            "<td>" +
                                                                "<a href='#p' style='display: block; border-style: none !important; border: 0 !important;'><img width='24' border='0' style='display: block;' src='http://i.imgur.com/Qc3zTxn.png' alt=''></a>" +
                                                            "</td>" +
                                                            "<td>&nbsp;&nbsp;&nbsp;&nbsp;</td>" +
                                                            "<td>" +
                                                                "<a href='#' style='display: block; border-style: none !important; border: 0 !important;'><img width='24' border='0' style='display: block;' src='http://i.imgur.com/RBRORq1.png' alt=''></a>" +
                                                            "</td>" +
                                                            "<td>&nbsp;&nbsp;&nbsp;&nbsp;</td>" +
                                                            "<td>" +
                                                                "<a href='#' style='display: block; border-style: none !important; border: 0 !important;'><img width='24' border='0' style='display: block;' src='http://i.imgur.com/Wji3af6.png' alt=''></a>" +
                                                            "</td>" +
                                                        "</tr>" +
                                                    "</table>" +
                                                "</td>" +
                                            "</tr>" +

                                        "</table>" +
                                    "</td>" +
                                "</tr>" +
                            "</table>" +
                        "</td>" +
                    "</tr>" +
                "</table>" +
            "</td>" +
        "</tr>" +

        "<tr>" +
            "<td height='60' style='font-size: 60px; line-height: 60px;'>&nbsp;</td>" +
        "</tr>" +

    "</table>" +
    "<!-- end section -->" +

    "<!-- footer ====== -->" +
    "<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='f4f4f4'>" +

        "<tr>" +
            "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
        "</tr>" +

        "<tr>" +
            "<td align='center'>" +

                "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +

                    "<tr>" +
                        "<td>" +
                            "<table border='0' align='left' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                "class='container590'>" +
                                "<tr>" +
                                    "<td align='left' style='color: #aaaaaa; font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;'>" +
                                        "<div style='line-height: 24px;'>" +

                                            "<span style='color: #333333;'>Copyright &copy; Todos los derechos reservados |<a href='#' style='color: #17a2b8' target='_blank'> Servicios inmobiliarios G </a></span>" +

                                        "</div>" +
                                    "</td>" +
                                "</tr>" +
                            "</table>" +

                            "<table border='0' align='left' width='5' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                "class='container590'>" +
                                "<tr>" +
                                    "<td height='20' width='5' style='font-size: 20px; line-height: 20px;'>&nbsp;</td>" +
                                "</tr>" +
                            "</table>" +

                            "<table border='0' align='right' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;'" +
                                "class='container590'>" +

                                "<tr>" +
                                    "<td align='center'>" +
                                        "<table align='center' border='0' cellpadding='0' cellspacing='0'>" +
                                            "<tr>" +
                                                "<td align='center'>" +
                                                    "<a style='font-size: 14px; font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif; line-height: 24px;color: #17a2b8; text-decoration: none;font-weight:bold;'" +
                                                        "href='http://www.serviciosinmobiliariosg.com.mx/home/Contacto'>SUSCRIBIRME</a>" +
                                                "</td>" +
                                            "</tr>" +
                                        "</table>" +
                                    "</td>" +
                                "</tr>" +

                            "</table>" +
                        "</td>" +
                    "</tr>" +

                "</table>" +
            "</td>" +
        "</tr>" +

        "<tr>" +
            "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
        "</tr>" +

    "</table>" +
    "<!-- end footer ====== -->" +

"</body>" +

"</html>";


            return html;
        }
    }
}
