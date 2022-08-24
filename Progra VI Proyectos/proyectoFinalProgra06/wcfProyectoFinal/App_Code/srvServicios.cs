using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvServicios" en el código, en svc y en el archivo de configuración a la vez.
public class srvServicios : IsrvServicios
{
    private readonly IServiciosLN gobjServiciosLN = new ServiciosLN();

    //**************ENTIDADES**************//
    public List<Servicios> recServicios_ENT()
    {
        List<Servicios> lobjRespuesta = new List<Servicios>();
        try
        {
            lobjRespuesta = gobjServiciosLN.recServicios_ENT();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public Servicios recServiciosXId_ENT(int pId)
    {
        Servicios lobjRespuesta = new Servicios();
        try
        {
            lobjRespuesta = gobjServiciosLN.recServiciosXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insServicios_ENT(Servicios pServicios)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjServiciosLN.insServicios_ENT(pServicios);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modServicios_ENT(Servicios pServicios)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjServiciosLN.modServicios_ENT(pServicios);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delServicios_ENT(Servicios pServicios)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjServiciosLN.delServicios_ENT(pServicios);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }
}
