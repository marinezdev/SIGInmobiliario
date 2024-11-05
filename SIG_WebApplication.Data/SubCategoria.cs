using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class SubCategoria
    {
        ManejoDatos b = new ManejoDatos();

        public List<Models.SubCategoria> SubCategoria_Seleccionar()
        {
            b.ExecuteCommandSP("SubCategoria_Seleccionar");
            List<Models.SubCategoria> resultado = new List<Models.SubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.SubCategoria item = new Models.SubCategoria()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Nombre = reader["Nombre"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.SubCategoria> SubCategoria_Seleccionar_Listar()
        {
            b.ExecuteCommandSP("SubCategoria_Seleccionar_Listar");
            List<Models.SubCategoria> resultado = new List<Models.SubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.SubCategoria item = new Models.SubCategoria()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Nombre = reader["Nombre"].ToString(),
                    Imagen = reader["Imagen"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.SubCategoria> SubCategoria_Busqueda()
        {
            b.ExecuteCommandSP("SubCategoria_Busqueda");
            List<Models.SubCategoria> resultado = new List<Models.SubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.SubCategoria item = new Models.SubCategoria()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Nombre = reader["Nombre"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.SubCategoria> SubCategoria_Seleccionar_Editar()
        {
            b.ExecuteCommandSP("SubCategoria_Seleccionar_Editar");
            List<Models.SubCategoria> resultado = new List<Models.SubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.SubCategoria item = new Models.SubCategoria()
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    Nombre = reader["Nombre"].ToString()

                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
