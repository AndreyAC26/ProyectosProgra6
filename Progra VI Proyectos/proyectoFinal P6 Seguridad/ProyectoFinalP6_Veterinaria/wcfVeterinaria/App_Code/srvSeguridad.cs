using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvSeguridad" en el código, en svc y en el archivo de configuración a la vez.
public class srvSeguridad : IsrvSeguridad
{
    private readonly ISeguridadLN gobjSeguridadLN = new SeguridadLN();

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
