using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class srvClientes : IsrvClientes
{
    private readonly IClientesLN gobjClientesLN = new ClientesLN();

    //**************ENTIDADES**************//
    public List<Clientes> recClientes_ENT()
    {
        List<Clientes> lobjRespuesta = new List<Clientes>();
        try
        {
            lobjRespuesta = gobjClientesLN.recClientes_ENT();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public Clientes recClientesXId_ENT(int pId)
    {
        Clientes lobjRespuesta = new Clientes();
        try
        {
            lobjRespuesta = gobjClientesLN.recClientesXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insClientes_ENT(Clientes pClientes)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjClientesLN.insClientes_ENT(pClientes);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modClientes_ENT(Clientes pClientes)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjClientesLN.modClientes_ENT(pClientes);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delClientes_ENT(Clientes pClientes)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjClientesLN.delClientes_ENT(pClientes);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }
}
