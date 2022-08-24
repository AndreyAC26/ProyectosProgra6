using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webApi.Controllers
{
    public class CitasController : ApiController
    {
        private readonly ICitasLN gobjCitasLN = new CitasLN();

        ///////****ENTIDADES****/////
        [HttpGet]
        public List<Citas> recCitas_ENT()
        {
            //VARIABLE
            List<Citas> lobjRespuesta = new List<Citas>();
            try
            {
                lobjRespuesta = gobjCitasLN.recCitas_ENT();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        [HttpGet]
        public Citas recCitasXId_ENT(int pId)
        {
            //VARIABLE
            Citas lobjRespuesta = new Citas();
            try
            {
                lobjRespuesta = gobjCitasLN.recCitasXId_ENT(pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insCitas([FromBody] Citas pCitas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCitasLN.insCitas_ENT(pCitas);
                    return Ok(pCitas);
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
