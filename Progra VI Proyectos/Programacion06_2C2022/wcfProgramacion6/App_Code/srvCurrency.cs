using System;
using System.Collections.Generic;
using LogicaNegocio.Interfaces;
using LogicaNegocio.Implementacion;
using Entidades;

public class srvCurrency : IsrvCurrency
{
    private readonly ICurrencyLN gobjCurrencyLN = new CurrencyLN();

    //**************ENTIDADES**************//
    public List<Currency> recCurrency_ENT()
    {
        List<Currency> lobjRespuesta = new List<Currency>();
        try
        {
            lobjRespuesta = gobjCurrencyLN.recCurrency_ENT();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public Currency recCurrencyXId_ENT(string pId)
    {
        Currency lobjRespuesta = new Currency();
        try
        {
            lobjRespuesta = gobjCurrencyLN.recCurrencyXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insCurrency_ENT(Currency pCurrency)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCurrencyLN.insCurrency_ENT(pCurrency);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modCurrency_ENT(Currency pCurrency)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCurrencyLN.modCurrency_ENT(pCurrency);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delCurrency_ENT(Currency pCurrency)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCurrencyLN.delCurrency_ENT(pCurrency);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    //**************PROCEDIMIENTOS ALMACENADOS**************//
    public List<recCurrency_Result> recCurrency_PA()
    {
        List<recCurrency_Result> lobjRespuesta = new List<recCurrency_Result>();
        try
        {
            lobjRespuesta = gobjCurrencyLN.recCurrency_PA();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public recCurrencyxId_Result recCurrencyXId_PA(string pId)
    {
        recCurrencyxId_Result lobjRespuesta = new recCurrencyxId_Result();
        try
        {
            lobjRespuesta = gobjCurrencyLN.recCurrency_PA(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insCurrency_PA(Currency pCurrency)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCurrencyLN.insCurrency_PA(pCurrency);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modCurrency_PA(Currency pCurrency)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCurrencyLN.modCurrency_PA(pCurrency);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delCurrency_PA(Currency pCurrency)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCurrencyLN.delCurrency_ENT(pCurrency);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }
    public void DoWork()
    {
    }
}
