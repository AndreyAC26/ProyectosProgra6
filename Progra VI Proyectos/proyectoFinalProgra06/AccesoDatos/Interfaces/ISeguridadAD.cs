using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface ISeguridadAD
    {
        TUSR_USUARIOS recUsuario(string pUsrLogin);

    }
}
