using LogicaNegocio.Implementacion;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvFacturacion" en el código, en svc y en el archivo de configuración a la vez.
public class srvFacturacion : IsrvFacturacion
{
    private readonly IFacturacionLN gobjFacturacionLN = new FacturacionLN();

    //**************ENTIDADES**************//
    public List<Facturacion> recFacturacion_ENT()
    {
        List<Facturacion> lobjRespuesta = new List<Facturacion>();
        try
        {
            lobjRespuesta = gobjFacturacionLN.recFacturacion_ENT();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public Facturacion recFacturacionXId_ENT(int pId)
    {
        Facturacion lobjRespuesta = new Facturacion();
        try
        {
            lobjRespuesta = gobjFacturacionLN.recFacturacionXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insFacturacion_ENT(Facturacion pFacturacion)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjFacturacionLN.insFacturacion_ENT(pFacturacion);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modFacturacion_ENT(Facturacion pFacturacion)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjFacturacionLN.modFacturacion_ENT(pFacturacion);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delFacturacion_ENT(Facturacion pFacturacion)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjFacturacionLN.delFacturacion_ENT(pFacturacion);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }
}
