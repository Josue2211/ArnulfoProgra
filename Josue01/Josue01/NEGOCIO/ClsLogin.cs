using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Josue01.DOMINIO;

namespace Josue01.NEGOCIO
{
    class ClsLogin
    {

        public int acceso(Login log) 
        {
            int estado = 0;
            if (log.Usuario.Equals("Arnulfo")&& log.Password.Equals("123")) {
                estado = 1;
            }

            return estado;
        } 
    }
}
