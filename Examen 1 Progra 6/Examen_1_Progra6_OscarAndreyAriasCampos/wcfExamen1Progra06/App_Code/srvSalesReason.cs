using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class srvSalesReason : IsrvSalesReason
{
    private readonly ISalesReasonLN gobjSalesReasonLN = new SalesReasonLN(); 

        public List<SalesReason> recSalesReason_ENT()
    {
        List<SalesReason> lobjRespuesta = new List<SalesReason>();
        try
        {
            lobjRespuesta = gobjSalesReasonLN.recSalesReason_ENT();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }


    public SalesReason recSalesReasonXId_ENT(int pId)
    {
        SalesReason lobjRespuesta = new SalesReason();
        try
        {
            lobjRespuesta = gobjSalesReasonLN.recSalesReasonXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insSalesReason_ENT(SalesReason pSalesReason)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjSalesReasonLN.insSalesReason_ENT(pSalesReason);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modSalesReason_ENT(SalesReason pSalesReason)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjSalesReasonLN.modSalesReason_ENT(pSalesReason);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delSalesReason_ENT(SalesReason pSalesReason)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjSalesReasonLN.delSalesReason_ENT(pSalesReason);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }


}
