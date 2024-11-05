using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Models
{
    public class ConsultaInmueble
    {
        public Inmueble Inmueble { get; set; }
    }
    public class Inmueble
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public int IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int IdSubCategoria { get; set; }
        public int IdTipoSub { get; set; }
        public int IdEstado { get; set; }
        public int IdPoblacion { get; set; }
        public int IdCP { get; set; }
        public int IdColonia { get; set; }
        public int IdUnidadMedida { get; set; }
        public string UnidadMedida { get; set; }
        public string WC { get; set; }
        public string Estacionamientos { get; set; }
        public string Superficie { get; set; }
        public string SuperficieT { get; set; }
        public string Precio { get; set; }
        public int IdMoneda { get; set; }
        public string NombreMoneda { get; set; }
        public string Mes { get; set; }
        public int Dia { get; set; }
        public string FechaRegistro { get; set; }
        public string Tiempo { get; set; }
        public string NombreEstatus { get; set; }
        public string TipoCategoria { get; set; }
        public string SubCategoria { get; set; }
        public string Estado { get; set; }
        public string Poblacion { get; set; }
        public string CP { get; set; }
        public string Colonia { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string TelefonoMovil { get; set; }
        public string Imagen { get; set; }
        public string IdCf { get; set; }
        public string UnidadMedidaAbre { get; set; }

        public int Total { get; set; }
    }
}
