using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class SalesCurrencyAD : ISalesCurrencyAD
    {
        private AWEntidades gObjConexionAW;

        public SalesCurrencyAD(AWEntidades lObjConexionAW)
        {
            gObjConexionAW = lObjConexionAW;
        }

        //*************Entidades*************//
        public List<Currency> recSalesCurrency_ENT()
        {
            List<Currency> lobjRespuesta = new List<Currency>();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.Currency.ToList();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }

            return lobjRespuesta;
        }

        public Currency recCurrencyXId_ENT(string pId)
        {
            bool lProxy = gObjConexionAW.Configuration.ProxyCreationEnabled;
            Currency lobjRespuesta = new Currency();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.Currency.ToList().Find(c=>c.CurrencyCode == pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool insCurrency_ENT(Currency pCurrency)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Currency.Find(pCurrency.CurrencyCode);
                if (regEncontrado == null)
                {
                    gObjConexionAW.Currency.Add(regEncontrado);
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool modCurrency_ENT(Currency pCurrency)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Currency.Find(pCurrency.CurrencyCode);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pCurrency);
                    gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Modified;
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool delCurrency_ENT(Currency pCurrency)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Currency.Find(pCurrency.CurrencyCode);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pCurrency);
                    gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Deleted;
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }


        //*************Procedimientos Almacenados*************//

        public List<recCurrency_Result> recCurrency_PA()
        {
            List<recCurrency_Result> lobjRespuesta = new List<recCurrency_Result>();
            try
            {
                lobjRespuesta = gObjConexionAW.recCurrency().ToList();
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
                lobjRespuesta = gObjConexionAW.recCurrencyxId(pId).FirstOrDefault();
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
                if(gObjConexionAW.insCurrency(pCurrency.CurrencyCode, pCurrency.Name) == 1)
                {
                    lobjRespuesta = true;
                }
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
                if (gObjConexionAW.modCurrency(pCurrency.CurrencyCode, pCurrency.Name) == 1)
                {
                    lobjRespuesta = true;
                }
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
                if (gObjConexionAW.delCurrency(pCurrency.CurrencyCode) == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

    }
}
