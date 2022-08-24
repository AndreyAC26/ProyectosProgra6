using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    internal interface ISeguridadLN
    {
        TUSR_USUARIOS recUsuario(string pUsrLogin);

    }
}
