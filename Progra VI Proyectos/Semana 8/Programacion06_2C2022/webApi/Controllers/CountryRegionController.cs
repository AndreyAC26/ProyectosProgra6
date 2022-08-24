using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace webApi.Controllers
{
    public class CountryRegionController : ApiController
    {
        private readonly ICountryRegionLN gobjCountryRegionLN = new CountryRegionLN();

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
                throw lEx;
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
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCountryRegionLN.insCountryRegion_ENT(pCountryRegion);
                    return Ok(pCountryRegion);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception lEx)
            {
                throw lEx;
            }
        }

        [HttpPut]
        public IHttpActionResult modCountryRegion([FromBody] CountryRegion pCountryRegion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCountryRegionLN.modCountryRegion_ENT(pCountryRegion);
                    return Ok(pCountryRegion);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception lEx)
            {
                throw lEx;
            }
        }

        [HttpDelete]
        public IHttpActionResult delCountryRegion([FromBody] CountryRegion pCountryRegion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCountryRegionLN.delCountryRegion_ENT(pCountryRegion);
                    return Ok(pCountryRegion);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception lEx)
            {
                throw lEx;
            }
        }

    }
}
