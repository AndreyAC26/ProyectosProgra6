using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;

public class srvSeguridad : IsrvSeguridad
{
    private readonly ISeguridadLN gobjSeguridadLN = new SeguridadLN();

    public TUSR_USUARIOS recUsuario(string pUsrLogin)
    {
        TUSR_USUARIOS lobjRespuesta = new TUSR_USUARIOS();
        try
        {
            lobjRespuesta = gobjSeguridadLN.recUsuario(pUsrLogin);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

}
