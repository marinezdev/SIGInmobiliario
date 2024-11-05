using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SIG_WebApplication.Application
{
    public class Control_Archivos
    {
        Data.Control_Archivos _Archivos = new Data.Control_Archivos();
        public Models.InmueblesImg NuevoArchivo(HttpPostedFileBase Archivo, string DirectorioUsuario, string DirectorioURL)
        {
            Models.InmueblesImg _inmueblesImg = new Models.InmueblesImg();
            String FileExtension = Path.GetExtension(Archivo.FileName).ToLower();

            if (!Directory.Exists(DirectorioUsuario))
            {
                Directory.CreateDirectory(DirectorioUsuario);
            }

            if (".jpg".Contains(FileExtension) ^ ".png".Contains(FileExtension) ^ ".jpeg".Contains(FileExtension))
            {

                Models.Control_Archivos archivo = _Archivos.NuevoArchivo();
                string NombreArchivo = archivo.Id.ToString().PadLeft(12, '0');

                Image image = ResizeImage(Image.FromStream(Archivo.InputStream, true, true), 1000, 650);
                image.Save(DirectorioUsuario + NombreArchivo + FileExtension);

                _inmueblesImg.IdArchivo = archivo.Id;
                _inmueblesImg.NmArchivo = NombreArchivo + FileExtension;
                _inmueblesImg.NmOriginal = Archivo.FileName;
                _inmueblesImg.Activo = 1;
                _inmueblesImg.Descripcion = DirectorioURL + NombreArchivo + FileExtension;

            }

            return _inmueblesImg;
        }


        public static Image ResizeImage (Image srcImage, int newWidth, int newHeight)
        {
            using (Bitmap imagenBitmap = new Bitmap(newWidth, newHeight, PixelFormat.Format32bppRgb))
            {
                imagenBitmap.SetResolution(
                   Convert.ToInt32(srcImage.HorizontalResolution),
                   Convert.ToInt32(srcImage.HorizontalResolution));

                using (Graphics imagenGraphics = Graphics.FromImage(imagenBitmap))
                {
                    imagenGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                    imagenGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    imagenGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    imagenGraphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(0, 0, srcImage.Width, srcImage.Height),GraphicsUnit.Pixel);
                    MemoryStream imagenMemoryStream = new MemoryStream();
                    imagenBitmap.Save(imagenMemoryStream, ImageFormat.Jpeg);
                    srcImage = Image.FromStream(imagenMemoryStream);
                }
            }
            return srcImage;
        }
    }
}
