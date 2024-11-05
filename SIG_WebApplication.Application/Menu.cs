﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_WebApplication.Application
{
    public class Menu
    {
        SIG_WebApplication.Data.Menu _Menu = new Data.Menu();
        public bool ValidacionPagina(Models.Usuarios DataUsuarios, string url)
        {
            bool resultado = false;
            if (DataUsuarios !=  null)
            {
                if (_Menu.ValidaPaginas(DataUsuarios, url).Respuesta)
                {
                    resultado = true;
                }
            }
            
            return resultado;
        }
    }
}
