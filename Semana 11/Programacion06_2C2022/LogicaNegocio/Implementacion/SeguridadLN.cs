using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;

namespace LogicaNegocio.Implementacion
{
    public class SeguridadLN : ISeguridadLN
    {
        public static SEGEntidades _objContextoSEG = new SEGEntidades();

        private readonly ISeguridadAD gobjSeguridad = new SeguridadAD(_objContextoSEG);

        public TUSR_USUARIOS recUsuario(string pUsrLogin)
        {
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
