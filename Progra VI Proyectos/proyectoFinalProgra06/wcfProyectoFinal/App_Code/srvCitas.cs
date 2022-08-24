using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class srvCitas : IsrvCitas
{
    private readonly ICitasLN gobjCitasLN = new CitasLN();

    //**************ENTIDADES**************//
    public List<Citas> recCitas_ENT()
    {
        List<Citas> lobjRespuesta = new List<Citas>();
        try
        {
            lobjRespuesta = gobjCitasLN.recCitas_ENT();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public Citas recCitasXId_ENT(int pId)
    {
        Citas lobjRespuesta = new Citas();
        try
        {
            lobjRespuesta = gobjCitasLN.recCitasXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insCitas_ENT(Citas pCitas)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCitasLN.insCitas_ENT(pCitas);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modCitas_ENT(Citas pCitas)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCitasLN.modCitas_ENT(pCitas);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delCitas_ENT(Citas pCitas)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCitasLN.delCitas_ENT(pCitas);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }
}
