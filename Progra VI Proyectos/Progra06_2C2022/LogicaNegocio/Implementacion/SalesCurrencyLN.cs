using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;

namespace LogicaNegocio.Implementacion
{
    public class SalesCurrencyLN : ISalesCurrencyLN
    {
        public static AWEntidades _objContextoAW;

        private readonly ISalesCurrencyAD gobjCurrencyAD = new SalesCurrencyAD(_objContextoAW);

        //*************Entidades*************//

        public List<Currency> recSalesCurrency_ENT()
        {
            List<Currency> lobjRespuesta = new List<Currency>();
            try
            {
                lobjRespuesta = gobjCurrencyAD.recSalesCurrency_ENT();
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
            catch (Exception lEX)
            {

                throw lEX;
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

        //*************Procedimientos Almacenados*************//

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

        public recCurrencyxId_Result recCurrencyXId_PA(string pId)
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

        public bool delCurrency_PA(Currency pCurrency)
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
