using Entidades;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class CurrencyController : Controller
    {
            //******Entidades******//
            public ActionResult listarCurrency_ENT()
            {
                List<Currency> lobjRespuesta = new List<Currency>();
                try
                {
                    using (srvCurrency.IsrvCurrencyClient srvWCF_CR = new srvCurrency.IsrvCurrencyClient())
                    {
                    lobjRespuesta = srvWCF_CR.recCurrency_ENT();
                    }
                }
                catch (Exception lEx)
                {

                    throw lEx;
                }
                return View(lobjRespuesta);
            }

            public ActionResult insertarCurrency_ENT(string pId)
            {
           
                return View();
            }

            public ActionResult modificarCurrency_ENT(string pId)
            {
            Currency lobjRespuesta = new Currency();

                try
                {
                    using (srvCurrency.IsrvCurrencyClient srvWCF_CR = new srvCurrency.IsrvCurrencyClient())

                        lobjRespuesta = srvWCF_CR.recCurrencyXId_ENT(pId);
                }
                catch (Exception lEx)
                {

                    throw lEx;
                }

                return View(lobjRespuesta);
            }

            public ActionResult eliminarCurrency_ENT(string pId)
            {
            Currency lobjRespuesta = new Currency();

                try
                {
                    using (srvCurrency.IsrvCurrencyClient srvWCF_CR = new srvCurrency.IsrvCurrencyClient())

                        lobjRespuesta = srvWCF_CR.recCurrencyXId_ENT(pId);
                }
                catch (Exception lEx)
                {

                    throw lEx;
                }

                return View(lobjRespuesta);
            }

            public ActionResult detalleCurrency_ENT(string pId)
            {
            Currency lobjRespuesta = new Currency();

                try
                {
                    using (srvCurrency.IsrvCurrencyClient srvWCF_CR = new srvCurrency.IsrvCurrencyClient())

                        lobjRespuesta = srvWCF_CR.recCurrencyXId_ENT(pId);
                }
                catch (Exception lEx)
                {

                    throw lEx;
                }

                return View(lobjRespuesta);
            }


        
    }
}