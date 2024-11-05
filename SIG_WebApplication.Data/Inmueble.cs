using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class Inmueble
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Inmueble Nuevo_InmuebleInicia(Models.Inmueble inmueble)
        {
            b.ExecuteCommandSP("SIG_InmuebleInicia");
            b.AddParameter("@IdCategoria", inmueble.IdCategoria, SqlDbType.Int);
            b.AddParameter("@IdUsuario", inmueble.IdUsuario, SqlDbType.Int);
            b.AddParameter("@Titulo", inmueble.Titulo, SqlDbType.NVarChar);
            b.AddParameter("@Descripcion", inmueble.Descripcion, SqlDbType.NVarChar);
            b.AddParameter("@IdSubCategoria", inmueble.IdSubCategoria, SqlDbType.Int);
            b.AddParameter("@IdTipoSub", inmueble.IdTipoSub, SqlDbType.Int);
            b.AddParameter("@IdEstado", inmueble.IdEstado, SqlDbType.Int);
            b.AddParameter("@IdPoblacion", inmueble.IdPoblacion, SqlDbType.Int);
            b.AddParameter("@IdCP", inmueble.IdCP, SqlDbType.Int);
            b.AddParameter("@IdColonia", inmueble.IdColonia, SqlDbType.Int);
            b.AddParameter("@WC", inmueble.WC, SqlDbType.NVarChar);
            b.AddParameter("@Estacionamientos", inmueble.Estacionamientos, SqlDbType.NVarChar);
            b.AddParameter("@Superficie", inmueble.Superficie, SqlDbType.NVarChar);
            b.AddParameter("@SuperficieT", inmueble.SuperficieT, SqlDbType.NVarChar);
            b.AddParameter("@Precio", inmueble.Precio, SqlDbType.NVarChar);
            b.AddParameter("@IdMoneda", inmueble.IdMoneda, SqlDbType.Int);
            b.AddParameter("@IdUnidadMedida", inmueble.IdUnidadMedida, SqlDbType.Int);

            Models.Inmueble resultado = new Models.Inmueble();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Inmueble SIG_InmuebleProcesar(int IdInmueble, int IdUsuario)
        {
            b.ExecuteCommandSP("SIG_InmuebleProcesar");
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            Models.Inmueble resultado = new Models.Inmueble();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Inmueble SIG_InmuebleProcesar_Rechazar(int IdInmueble, int IdUsuario)
        {
            b.ExecuteCommandSP("SIG_InmuebleProcesar_Rechazar");
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            Models.Inmueble resultado = new Models.Inmueble();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble> Inmueble_Selecionar_IdUsuairo(int IdUsuario)
        {
            b.ExecuteCommandSP("Inmueble_Selecionar_IdUsuairo");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    FechaRegistro = reader["FechaRegistro"].ToString(),
                    Mes = reader["Mes"].ToString(),
                    Dia = Convert.ToInt32(reader["Dia"].ToString()),
                    Titulo = reader["Titulo"].ToString(),
                    Descripcion = reader["Descripcion"].ToString(),
                    Tiempo = reader["Tiempo"].ToString(),
                    NombreEstatus = reader["NombreEstatus"].ToString(),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    SubCategoria = reader["SubCategoria"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Poblacion = reader["Poblacion"].ToString(),
                    Imagen = "http://"+reader["Imagen"].ToString(),
                    
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble> Inmueble_Selecionar_IdUsuairo_Listar(int IdUsuario)
        {
            b.ExecuteCommandSP("Inmueble_Selecionar_IdUsuairo_Listar");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    FechaRegistro = reader["FechaRegistro"].ToString(),
                    Mes = reader["Mes"].ToString(),
                    Dia = Convert.ToInt32(reader["Dia"].ToString()),
                    Titulo = reader["Titulo"].ToString(),
                    Descripcion = reader["Descripcion"].ToString(),
                    Tiempo = reader["Tiempo"].ToString(),
                    NombreEstatus = reader["NombreEstatus"].ToString(),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    SubCategoria = reader["SubCategoria"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Poblacion = reader["Poblacion"].ToString(),
                    Imagen = "http://" + reader["Imagen"].ToString(),

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Inmueble> Inmuebles_Selecionar(int IdTipoCategoria)
        {
            b.ExecuteCommandSP("Inmuebles_Selecionar");
            b.AddParameter("@IdTipoCategoria", IdTipoCategoria, SqlDbType.Int);
            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Imagen = "http://" + reader["Imagen"].ToString(),
                    IdTipoSub = Convert.ToInt32(reader["IdTipoCategoria"].ToString()),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    SubCategoria = reader["SubCategoria"].ToString(),
                    Tiempo = reader["Tiempo"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Poblacion = reader["Poblacion"].ToString(),
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Precio = reader["Precio"].ToString(),
                    NombreMoneda = reader["NombreMoneda"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble> Inmuebles_Selecionar_Random()
        {
            b.ExecuteCommandSP("Inmuebles_Selecionar_Random");
            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Imagen = "http://" + reader["Imagen"].ToString(),
                    IdTipoSub = Convert.ToInt32(reader["IdTipoCategoria"].ToString()),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    SubCategoria = reader["SubCategoria"].ToString(),
                    Tiempo = reader["Tiempo"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Poblacion = reader["Poblacion"].ToString(),
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Precio = reader["Precio"].ToString(),
                    NombreMoneda = reader["NombreMoneda"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Inmueble Inmueble_Seleccionar_IdInmueble(int IdInmueble)
        {
            b.ExecuteCommandSP("Inmueble_Seleccionar_IdInmueble");
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);

            Models.Inmueble resultado = new Models.Inmueble();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
                resultado.SubCategoria = reader["SubCategoria"].ToString();
                resultado.TipoCategoria = reader["TipoCategoria"].ToString();
                resultado.Tiempo = reader["Tiempo"].ToString();
                resultado.FechaRegistro = reader["FechaRegistro"].ToString();
                resultado.Titulo = reader["Titulo"].ToString();
                resultado.Descripcion = reader["Descripcion"].ToString();
                resultado.NombreEstatus = reader["NombreEstatus"].ToString();
                resultado.Estado = reader["Estado"].ToString();
                resultado.Poblacion = reader["Poblacion"].ToString();
                resultado.CP = reader["CP"].ToString();
                resultado.Colonia = reader["Colonia"].ToString();
                resultado.WC = reader["WC"].ToString();
                resultado.Estacionamientos = reader["Estacionamientos"].ToString();
                resultado.Superficie = reader["Superficie"].ToString();
                resultado.SuperficieT = reader["SuperficieT"].ToString();
                resultado.Precio = reader["Precio"].ToString();
                resultado.NombreMoneda = reader["NombreMoneda"].ToString();
                resultado.NombreUsuario = reader["NombreUsuario"].ToString();
                resultado.Correo = reader["Correo"].ToString();
                resultado.Telefono = reader["Telefono"].ToString();
                resultado.TelefonoMovil = reader["TelefonoMovil"].ToString();
                resultado.UnidadMedidaAbre = reader["Abreviacion"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Inmueble Inmueble_Seleccionar_Editar_IdInmueble(int IdInmueble)
        {
            b.ExecuteCommandSP("Inmueble_Seleccionar_Editar_IdInmueble");
            b.AddParameter("@IdInmueble", IdInmueble, SqlDbType.Int);

            Models.Inmueble resultado = new Models.Inmueble();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Id = Convert.ToInt32(reader["Id"].ToString());
                resultado.IdSubCategoria = Convert.ToInt32(reader["IdSubCategoria"].ToString());
                resultado.SubCategoria = reader["SubCategoria"].ToString();
                resultado.TipoCategoria = reader["TipoCategoria"].ToString();
                resultado.IdTipoSub = Convert.ToInt32(reader["IdTipoSub"].ToString());
                resultado.Tiempo = reader["Tiempo"].ToString();
                resultado.FechaRegistro = reader["FechaRegistro"].ToString();
                resultado.Titulo = reader["Titulo"].ToString();
                resultado.Descripcion = reader["Descripcion"].ToString();
                resultado.NombreEstatus = reader["NombreEstatus"].ToString();
                resultado.Estado = reader["Estado"].ToString();
                resultado.IdEstado = Convert.ToInt32(reader["IdEstado"].ToString());

                resultado.Poblacion = reader["Poblacion"].ToString();
                resultado.IdPoblacion = Convert.ToInt32(reader["IdPoblacion"].ToString());
                resultado.CP = reader["CP"].ToString();
                resultado.IdCP = Convert.ToInt32(reader["IdCP"].ToString());
                resultado.Colonia = reader["Colonia"].ToString();
                resultado.IdColonia = Convert.ToInt32(reader["IdColonia"].ToString());

                resultado.WC = reader["WC"].ToString();
                resultado.Estacionamientos = reader["Estacionamientos"].ToString();
                resultado.Superficie = reader["Superficie"].ToString();
                resultado.SuperficieT = reader["SuperficieT"].ToString();
                resultado.Precio = reader["Precio"].ToString();
                resultado.IdMoneda = Convert.ToInt32(reader["IdMoneda"].ToString());

                resultado.NombreMoneda = reader["NombreMoneda"].ToString();
                resultado.NombreUsuario = reader["NombreUsuario"].ToString();
                resultado.Correo = reader["Correo"].ToString();
                resultado.Telefono = reader["Telefono"].ToString();
                resultado.TelefonoMovil = reader["TelefonoMovil"].ToString();

                resultado.IdUnidadMedida = Convert.ToInt32(reader["IdUnidadMedida"].ToString());
                resultado.UnidadMedida = reader["UnidadMedida"].ToString();
                resultado.UnidadMedidaAbre = reader["Abreviacion"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble> Inmuebles_Seleccionar_SubCategorias(int IdSubCategoria)
        {
            b.ExecuteCommandSP("Inmuebles_Seleccionar_SubCategorias");
            b.AddParameter("@IdSubCategoria", IdSubCategoria, SqlDbType.Int);
            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Imagen = "http://" + reader["Imagen"].ToString(),
                    IdTipoSub = Convert.ToInt32(reader["IdTipoCategoria"].ToString()),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    SubCategoria = reader["SubCategoria"].ToString(),
                    Tiempo = reader["Tiempo"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Poblacion = reader["Poblacion"].ToString(),
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Precio = reader["Precio"].ToString(),
                    NombreMoneda = reader["NombreMoneda"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensaje Inmueble_Desactivar(int Id)
        {
            b.ExecuteCommandSP("Inmueble_Desactivar");
            b.AddParameter("@IdInmueble", Id, SqlDbType.Int);
            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.RespuestaText = reader["RespuestaText"].ToString();
                resultado.Respuesta = Convert.ToBoolean(Convert.ToInt32(reader["Respuesta"].ToString()));
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensaje Inmueble_Vendido(int Id)
        {
            b.ExecuteCommandSP("Inmueble_Vendido");
            b.AddParameter("@IdInmueble", Id, SqlDbType.Int);
            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.RespuestaText = reader["RespuestaText"].ToString();
                resultado.Respuesta = Convert.ToBoolean(Convert.ToInt32(reader["Respuesta"].ToString()));
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensaje Inmueble_Rentado(int Id)
        {
            b.ExecuteCommandSP("Inmueble_Rentado");
            b.AddParameter("@IdInmueble", Id, SqlDbType.Int);
            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.RespuestaText = reader["RespuestaText"].ToString();
                resultado.Respuesta = Convert.ToBoolean(Convert.ToInt32(reader["Respuesta"].ToString()));
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensaje Inmueble_Eliminar(int Id)
        {
            b.ExecuteCommandSP("Inmueble_Eliminar");
            b.AddParameter("@IdInmueble", Id, SqlDbType.Int);
            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.RespuestaText = reader["RespuestaText"].ToString();
                resultado.Respuesta = Convert.ToBoolean(Convert.ToInt32(reader["Respuesta"].ToString()));
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensaje Inmueble_Publicar(int Id)
        {
            b.ExecuteCommandSP("Inmueble_Publicar");
            b.AddParameter("@IdInmueble", Id, SqlDbType.Int);
            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.RespuestaText = reader["RespuestaText"].ToString();
                resultado.Respuesta = Convert.ToBoolean(Convert.ToInt32(reader["Respuesta"].ToString()));
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Inmueble Inmuebles_publicados(int IdUsuario)
        {
            b.ExecuteCommandSP("Inmuebles_publicados");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);
            Models.Inmueble resultado = new Models.Inmueble();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Total = Convert.ToInt32(reader["Total"].ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensaje Inmueble_Actualizar(Models.Inmueble inmueble)
        {
            b.ExecuteCommandSP("Inmueble_Actualizar");
            b.AddParameter("@Id", inmueble.Id, SqlDbType.Int);
            b.AddParameter("@Titulo", inmueble.Titulo, SqlDbType.NVarChar);
            b.AddParameter("@Descripcion", inmueble.Descripcion, SqlDbType.NVarChar);
            b.AddParameter("@IdSubCategoria", inmueble.IdSubCategoria, SqlDbType.Int);
            b.AddParameter("@IdTipoSub", inmueble.IdTipoSub, SqlDbType.Int);
            b.AddParameter("@IdEstado", inmueble.IdEstado, SqlDbType.Int);
            b.AddParameter("@IdPoblacion", inmueble.IdPoblacion, SqlDbType.Int);
            b.AddParameter("@IdCP", inmueble.IdCP, SqlDbType.Int);
            b.AddParameter("@IdColonia", inmueble.IdColonia, SqlDbType.Int);
            b.AddParameter("@WC", inmueble.WC, SqlDbType.NVarChar);
            b.AddParameter("@Estacionamientos", inmueble.Estacionamientos, SqlDbType.NVarChar);
            b.AddParameter("@Superficie", inmueble.Superficie, SqlDbType.NVarChar);
            b.AddParameter("@SuperficieT", inmueble.SuperficieT, SqlDbType.NVarChar);
            b.AddParameter("@Precio", inmueble.Precio, SqlDbType.NVarChar);
            b.AddParameter("@IdMoneda", inmueble.IdMoneda, SqlDbType.Int);
            b.AddParameter("@IdUnidadMedida", inmueble.IdUnidadMedida, SqlDbType.Int);

            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Respuesta = Convert.ToBoolean(Convert.ToInt32(reader["Respuesta"].ToString()));
                resultado.RespuestaText = reader["RespuestaText"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble> Inmueble_Seleccionar_Busqueda(Models.Busquedas busquedas)
        {
            b.ExecuteCommandSP("Inmueble_Seleccionar_Busqueda");
            b.AddParameter("@TipoSubCategoria", busquedas.TipoSubCategoria, SqlDbType.NVarChar);
            b.AddParameter("@Direccion", busquedas.Direccion, SqlDbType.NVarChar);
            b.AddParameter("@Estado", busquedas.Estado, SqlDbType.NVarChar);
            b.AddParameter("@Poblacion", busquedas.Poblacion, SqlDbType.NVarChar);
            b.AddParameter("@CP", busquedas.CP, SqlDbType.NVarChar);
            b.AddParameter("@Colonia", busquedas.Colonia, SqlDbType.NVarChar);
            b.AddParameter("@TipoOperacion", busquedas.TipoOperacion, SqlDbType.NVarChar);
            b.AddParameter("@wc", busquedas.wc, SqlDbType.NVarChar);
            b.AddParameter("@Esta", busquedas.Esta, SqlDbType.NVarChar);

            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    FechaRegistro = reader["FechaRegistro"].ToString(),
                    Mes = reader["Mes"].ToString(),
                    Dia = Convert.ToInt32(reader["Dia"].ToString()),
                    Titulo = reader["Titulo"].ToString(),
                    
                    Descripcion =  reader["Descripcion"].ToString().Substring(0,100) + " ... ",

                    Tiempo = reader["Tiempo"].ToString(),
                    NombreEstatus = reader["NombreEstatus"].ToString(),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    SubCategoria = reader["SubCategoria"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Poblacion = reader["Poblacion"].ToString(),
                    Imagen = "http://" + reader["Imagen"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble> Inmueble_Seleccionar_BusquedaIds(Models.Busquedas busquedas)
        {
            b.ExecuteCommandSP("Inmueble_Seleccionar_BusquedaIds");
            b.AddParameter("@TipoSubCategoria", busquedas.TipoSubCategoria, SqlDbType.NVarChar);
            b.AddParameter("@_IdEstado", busquedas.Estado, SqlDbType.NVarChar);
            b.AddParameter("@_IdPoblacion", busquedas.Poblacion, SqlDbType.NVarChar);
            b.AddParameter("@_IdColonia", busquedas.Colonia, SqlDbType.NVarChar);
            b.AddParameter("@TipoOperacion", busquedas.TipoOperacion, SqlDbType.NVarChar);
            b.AddParameter("@wc", busquedas.wc, SqlDbType.NVarChar);
            b.AddParameter("@Esta", busquedas.Esta, SqlDbType.NVarChar);

            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    FechaRegistro = reader["FechaRegistro"].ToString(),
                    Mes = reader["Mes"].ToString(),
                    Dia = Convert.ToInt32(reader["Dia"].ToString()),
                    Titulo = reader["Titulo"].ToString(),

                    Descripcion = reader["Descripcion"].ToString().Substring(0, 100) + " ... ",

                    Tiempo = reader["Tiempo"].ToString(),
                    NombreEstatus = reader["NombreEstatus"].ToString(),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    SubCategoria = reader["SubCategoria"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Poblacion = reader["Poblacion"].ToString(),
                    Imagen = "http://" + reader["Imagen"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble> Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria(string TipoSubCategoria, int IdSubCategoria)
        {
            b.ExecuteCommandSP("Inmueble_Seleccionar_IdSubCategoria_TipoSubCategoria");
            b.AddParameter("@TipoSubCategoria", TipoSubCategoria, SqlDbType.NVarChar);
            b.AddParameter("@IdSubCategoria", IdSubCategoria, SqlDbType.Int);

            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    FechaRegistro = reader["FechaRegistro"].ToString(),
                    Mes = reader["Mes"].ToString(),
                    Dia = Convert.ToInt32(reader["Dia"].ToString()),
                    Titulo = reader["Titulo"].ToString(),

                    Descripcion = reader["Descripcion"].ToString(),

                    Tiempo = reader["Tiempo"].ToString(),
                    NombreEstatus = reader["NombreEstatus"].ToString(),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    SubCategoria = reader["SubCategoria"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Poblacion = reader["Poblacion"].ToString(),
                    Precio = reader["Precio"].ToString(),
                    Imagen = "http://" + reader["Imagen"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble> Inmueble_Listar_Pendientes()
        {
            b.ExecuteCommandSP("Inmueble_Listar_Pendientes");

            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    FechaRegistro = reader["FechaRegistro"].ToString(),
                    Titulo = reader["Titulo"].ToString(),
                    Descripcion = reader["Descripcion"].ToString(),
                    TipoCategoria = reader["TipoCategoria"].ToString(),

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Inmueble> Inmuebles_Listar()
        {
            b.ExecuteCommandSP("Inmuebles_Listar");

            List<Models.Inmueble> resultado = new List<Models.Inmueble>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Inmueble item = new Models.Inmueble()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    FechaRegistro = reader["FechaRegistro"].ToString(),
                    Titulo = reader["Titulo"].ToString(),
                    Descripcion = reader["Descripcion"].ToString(),
                    TipoCategoria = reader["TipoCategoria"].ToString(),
                    Estado = reader["Estatus"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
