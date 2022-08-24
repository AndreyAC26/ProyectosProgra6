using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion
{
    public class SeguridadLN : ISeguridadLN
    {
        //VARIABLE
        public static SEGEntidades _objContextoSEG = new SEGEntidades();
        private readonly ISeguridadAD gobjSeguridad = new SeguridadAD(_objContextoSEG);

        public TUSR_USUARIOS recUsuario(string pUsrLogin)
        {
            //VARIABLE
            TUSR_USUARIOS lobjRespuesta = new TUSR_USUARIOS();
            try
            {
                lobjRespuesta = gobjSeguridad.recUsuario(pUsrLogin);
            }
            catch (Exception lEx)
            {

                throw lEx;

            }
            return lobjRespuesta;
        }
    }
}
