using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Data
{
    public class TipoSubCategoria
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.TipoSubCategoria> TipoSubCategoria_Seleccionar(int IdSubCategoria)
        {
            b.ExecuteCommandSP("TipoSubCategoria_Seleccionar");
            b.AddParameter("@IdSubCategoria", IdSubCategoria, SqlDbType.Int);
            List<Models.TipoSubCategoria> resultado = new List<Models.TipoSubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.TipoSubCategoria item = new Models.TipoSubCategoria()
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
        public List<Models.TipoSubCategoria> TipoSubCategoria_Selecionar_Listado()
        {
            b.ExecuteCommandSP("TipoSubCategoria_Selecionar_Listado");
            List<Models.TipoSubCategoria> resultado = new List<Models.TipoSubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.TipoSubCategoria item = new Models.TipoSubCategoria()
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
        public List<Models.TipoSubCategoria> TipoSubCategoria_Seleccionar_Categorias(int IdSubCategoria)
        {
            b.ExecuteCommandSP("TipoSubCategoria_Seleccionar_Categorias");
            b.AddParameter("@IdSubCategoria", IdSubCategoria, SqlDbType.Int);
            List<Models.TipoSubCategoria> resultado = new List<Models.TipoSubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.TipoSubCategoria item = new Models.TipoSubCategoria()
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
        public List<Models.TipoSubCategoria> TipoSubCategoria_Busqueda()
        {
            b.ExecuteCommandSP("TipoSubCategoria_Busqueda");
            List<Models.TipoSubCategoria> resultado = new List<Models.TipoSubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.TipoSubCategoria item = new Models.TipoSubCategoria()
                {
                    Nombre = reader["Nombre"].ToString()
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.TipoSubCategoria> TipoSubCategoria_Busqueda2()
        {
            b.ExecuteCommandSP("TipoSubCategoria_Busqueda2");
            List<Models.TipoSubCategoria> resultado = new List<Models.TipoSubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.TipoSubCategoria item = new Models.TipoSubCategoria()
                {
                    Nombre = reader["Nombre"].ToString(),
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.TipoSubCategoria> TipoSubCategoria_Inmuebles_Total()
        {
            b.ExecuteCommandSP("TipoSubCategoria_Inmuebles_Total");
            List<Models.TipoSubCategoria> resultado = new List<Models.TipoSubCategoria>();
            var reader = b.ExecuteReader();
            while (reader.Read())
            {
                Models.TipoSubCategoria item = new Models.TipoSubCategoria()
                {
                    Nombre = reader["Nombre"].ToString(),
                    Total = Convert.ToInt32(reader["Total"].ToString()), 
                };
                resultado.Add(item);
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
