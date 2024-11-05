using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIG_WebApplication.Data
{
    public class Usuario
    {
        ManejoDatos b = new ManejoDatos();

        public Models.Mensaje NuevoRegistro(Models.Usuarios usuario)
        {
            b.ExecuteCommandSP("Usuario_Agregar");
            b.AddParameter("@Email", usuario.Email, SqlDbType.VarChar);
            b.AddParameter("@Password", usuario.Password, SqlDbType.VarChar);
            b.AddParameter("@RepPassword", usuario.RepPassword, SqlDbType.VarChar);
            b.AddParameter("@Nombre", usuario.Nombre, SqlDbType.VarChar);
            b.AddParameter("@Apellidos", usuario.Apellidos, SqlDbType.VarChar);
            b.AddParameter("@Telefono", usuario.Telefono, SqlDbType.VarChar);
            b.AddParameter("@TelefonoMovil", usuario.TelefonoMovil, SqlDbType.VarChar);

            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.RespuestaText = reader["Respuesta"].ToString();
                resultado.Token = reader["Token"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Usuarios ValidarUsuarioToken(string Token)
        {
            b.ExecuteCommandSP("Usuario_Selecionar_Token");
            b.AddParameter("@Token", Token, SqlDbType.VarChar);

            Models.Usuarios resultado = new Models.Usuarios();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Nombre = reader["Nombre"].ToString();
                resultado.Apellidos = reader["Apellidos"].ToString();
                resultado.Email = reader["Correo"].ToString();
                resultado.Password = reader["Password"].ToString();
                resultado.Telefono = reader["Telefono"].ToString();
                resultado.TelefonoMovil = reader["TelefonoMovil"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Usuarios ValidarUsuarioTokenDecline(string Token)
        {
            b.ExecuteCommandSP("Usuario_SelecionarDecline_Token");
            b.AddParameter("@Token", Token, SqlDbType.VarChar);

            Models.Usuarios resultado = new Models.Usuarios();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Nombre = reader["Nombre"].ToString();
                resultado.Apellidos = reader["Apellidos"].ToString();
                resultado.Email = reader["Correo"].ToString();
                resultado.Password = reader["Password"].ToString();
                resultado.Telefono = reader["Telefono"].ToString();
                resultado.TelefonoMovil = reader["TelefonoMovil"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Usuarios Usuario_Selecionar_Pas_US(Models.Usuarios usuarios)
        {
            b.ExecuteCommandSP("Usuario_Selecionar_Pas_US");
            b.AddParameter("@Email", usuarios.Email, SqlDbType.VarChar);
            b.AddParameter("@Password", usuarios.Password, SqlDbType.VarChar);
            b.AddParameter("@Session", usuarios.Session, SqlDbType.Bit);

            Models.Usuarios resultado = new Models.Usuarios();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.IdUsuario = Convert.ToInt32(reader["Id"].ToString());
                resultado.Nombre = reader["Nombre"].ToString();
                resultado.Apellidos = reader["Apellidos"].ToString();
                resultado.Email = reader["Correo"].ToString();
                resultado.IdRol = Convert.ToInt32(reader["IdRol"].ToString());
                resultado.NombreRol = reader["NombreRol"].ToString();
                resultado.RutaAcceso = reader["RutaAcceso"].ToString();
                resultado.Mensaje = reader["Mensaje"].ToString();
                resultado.ClaveCoo = reader["ClaveCoo"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Usuarios coo_Session_Seleccionar(string Clave)
        {
            b.ExecuteCommandSP("coo_Session_Seleccionar");
            b.AddParameter("@Clave", Clave, SqlDbType.VarChar);

            Models.Usuarios resultado = new Models.Usuarios();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Email = reader["Correo"].ToString();
                resultado.Password = reader["Password"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Usuarios> Usuarios_Super_Selecionar()
        {
            b.ExecuteCommandSP("Usuarios_Super_Selecionar");
            List<Models.Usuarios> resultado = new List<Models.Usuarios>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Usuarios item = new Models.Usuarios()
                {
                    Nombre = reader["Nombre"].ToString(),
                    Apellidos = reader["Apellidos"].ToString(),
                    Email = reader["Correo"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Usuarios> Usuarios_Listar()
        {
            b.ExecuteCommandSP("Usuarios_Listar");
            List<Models.Usuarios> resultado = new List<Models.Usuarios>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.Usuarios item = new Models.Usuarios()
                {
                    FechaRegistro = reader["FechaRegistro"].ToString(),
                    Nombre = reader["Nombre"].ToString(),
                    Apellidos = reader["Apellidos"].ToString(),
                    Email = reader["Correo"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    TelefonoMovil = reader["TelefonoMovil"].ToString(),
                    NombreRol = reader["NombreRol"].ToString(),
                    IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensaje Usuario_Selecionar_Toke_Email(Models.Usuarios usuario)
        {
            b.ExecuteCommandSP("Usuario_Selecionar_Toke_Email");
            b.AddParameter("@Email", usuario.Email, SqlDbType.VarChar);

            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.RespuestaText = reader["Respuesta"].ToString();
                resultado.Token = reader["Token"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Usuarios Usuarios_Seleccionar_IdUsuario(int IdUsuario)
        {
            b.ExecuteCommandSP("Usuarios_Seleccionar_IdUsuario");
            b.AddParameter("@IdUsuario", IdUsuario, SqlDbType.Int);

            Models.Usuarios resultado = new Models.Usuarios();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.Nombre = reader["Nombre"].ToString();
                resultado.Apellidos = reader["Apellidos"].ToString();
                resultado.Email = reader["Correo"].ToString();
                resultado.FechaRegistro = reader["FechaRegistro"].ToString();
                resultado.Telefono = reader["Telefono"].ToString();
                resultado.TelefonoMovil = reader["TelefonoMovil"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Mensaje Usuario_Actualizar(Models.Usuarios usuarios)
        {
            b.ExecuteCommandSP("Usuario_Actualizar");
            b.AddParameter("@Nombre", usuarios.Nombre, SqlDbType.NVarChar);
            b.AddParameter("@Apellidos", usuarios.Apellidos, SqlDbType.NVarChar);
            b.AddParameter("@Telefono", usuarios.Telefono, SqlDbType.NVarChar);
            b.AddParameter("@TelefonoMovil", usuarios.TelefonoMovil, SqlDbType.NVarChar);
            b.AddParameter("@IdUsuario", usuarios.IdUsuario, SqlDbType.Int);

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
        public Models.Mensaje Usuario_Actualizar_Password(Models.Usuarios usuarios)
        {
            b.ExecuteCommandSP("Usuario_Actualizar_Password");
            b.AddParameter("@Password", usuarios.Password, SqlDbType.NVarChar);
            b.AddParameter("@NuPassword", usuarios.NuPassword, SqlDbType.NVarChar);
            b.AddParameter("@RepPassword", usuarios.RepPassword, SqlDbType.NVarChar);
            b.AddParameter("@IdUsuario", usuarios.IdUsuario, SqlDbType.Int);

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
        public Models.Usuarios Usuario_Selecionar_Password(Models.Usuarios usuarios)
        {
            b.ExecuteCommandSP("Usuario_Selecionar_Password");
            b.AddParameter("@Email", usuarios.Email, SqlDbType.VarChar);

            Models.Usuarios resultado = new Models.Usuarios();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                resultado.IdUsuario = Convert.ToInt32(reader["Id"].ToString());
                resultado.Nombre = reader["Nombre"].ToString();
                resultado.Apellidos = reader["Apellidos"].ToString();
                resultado.Email = reader["Correo"].ToString();
                resultado.Password = reader["Password"].ToString();
                resultado.Mensaje = reader["Mensaje"].ToString();
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}
