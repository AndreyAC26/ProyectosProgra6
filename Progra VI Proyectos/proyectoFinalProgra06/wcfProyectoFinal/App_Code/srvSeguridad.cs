using Entidades;
using LogicaNegocio.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class srvSeguridad : IsrvSeguridad
{
    private readonly SeguridadLN gobjSeguridadLN = new SeguridadLN();

    public TUSR_USUARIOS recUsuario(string pUsrLogin)
    {
        //VARIABLE
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
