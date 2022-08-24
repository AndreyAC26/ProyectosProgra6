using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace webApi.Controllers
{
    public class CountryRegionController : ApiController
    {
        private readonly ICountryRegionLN gobjCountryRegionLN = new CountryRegionLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //**************ENTIDADES**************//

        [HttpGet]
        public List<CountryRegion> recCountryRegion_ENT()
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            try
            {
                lobjRespuesta = gobjCountryRegionLN.recCountryRegion_ENT();
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        [HttpGet]
        public CountryRegion recCountryRegionXId_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                lobjRespuesta = gobjCountryRegionLN.recCountryRegionXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insCountryRegion([FromBody] CountryRegion pCountryRegion)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCountryRegionLN.insCountryRegion_ENT(pCountryRegion);
                    lEstado = true;
                }
                else
                {
                    lEstado = false;
                }

            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pCountryRegion);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modCountryRegion([FromBody] CountryRegion pCountryRegion)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCountryRegionLN.modCountryRegion_ENT(pCountryRegion);
                    lEstado = true;
                }
                else
                {
                    lEstado = false;
                }

            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pCountryRegion);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delCountryRegion([FromBody] CountryRegion pCountryRegion)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCountryRegionLN.delCountryRegion_ENT(pCountryRegion);
                    lEstado = true;
                }
                else
                {
                    lEstado = false;
                }

            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pCountryRegion);
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
