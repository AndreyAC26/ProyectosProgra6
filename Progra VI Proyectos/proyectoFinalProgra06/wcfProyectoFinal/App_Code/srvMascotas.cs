using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class srvMascotas : IsrvMascotas
{
    private readonly IMascotasLN gobjMascotasLN = new MascotasLN();

    //**************ENTIDADES**************//
    public List<Mascotas> recMascotas_ENT()
    {
        List<Mascotas> lobjRespuesta = new List<Mascotas>();
        try
        {
            lobjRespuesta = gobjMascotasLN.recMascotas_ENT();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public Mascotas recMascotasXId_ENT(int pId)
    {
        Mascotas lobjRespuesta = new Mascotas();
        try
        {
            lobjRespuesta = gobjMascotasLN.recMascotasXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insMascotas_ENT(Mascotas pMascotas)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjMascotasLN.insMascotas_ENT(pMascotas);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modMascotas_ENT(Mascotas pMascotas)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjMascotasLN.modMascotas_ENT(pMascotas);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delMascotas_ENT(Mascotas pMascotas)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjMascotasLN.delMascotas_ENT(pMascotas);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }
}
