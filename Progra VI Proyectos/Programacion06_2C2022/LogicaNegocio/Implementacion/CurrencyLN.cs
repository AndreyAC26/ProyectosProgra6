using AccesoDatos;
using Entidades;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;

namespace LogicaNegocio.Implementacion
{
    public class CurrencyLN : ICurrencyLN
    {
        public static AWEntidades _objContextoAW = new AWEntidades();

        private readonly ICurrencyAD gobjCurrencyAD = new CurrencyAD(_objContextoAW);

        //**************ENTIDADES**************//
        public List<Currency> recCurrency_ENT()
        {
            List<Currency> lobjRespuesta = new List<Currency>();
            try
            {
                lobjRespuesta = gobjCurrencyAD.recCurrency_ENT();
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
                lobjRespuesta = gobjCurrencyAD.recCurrencyXId_ENT(pId);
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
                lobjRespuesta = gobjCurrencyAD.insCurrency_ENT(pCurrency);
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
                lobjRespuesta = gobjCurrencyAD.modCurrency_ENT(pCurrency);
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
                lobjRespuesta = gobjCurrencyAD.delCurrency_ENT(pCurrency);
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
                lobjRespuesta = gobjCurrencyAD.recCurrency_PA();
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public recCurrencyxId_Result recCurrency_PA(string pId)
        {
            recCurrencyxId_Result lobjRespuesta = new recCurrencyxId_Result();
            try
            {
                lobjRespuesta = gobjCurrencyAD.recCurrencyXId_PA(pId);
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
                lobjRespuesta = gobjCurrencyAD.insCurrency_PA(pCurrency);
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
                lobjRespuesta = gobjCurrencyAD.modCurrency_PA(pCurrency);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delCountryRegionCurrency_PA(Currency pCurrency)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCurrencyAD.delCurrency_PA(pCurrency);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
