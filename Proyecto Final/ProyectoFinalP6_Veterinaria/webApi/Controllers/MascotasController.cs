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
    public class MascotasController : ApiController
    {
        private readonly IMascotasLN gobjMascotasLN = new MascotasLN();


        ///////****ENTIDADES****/////
        [HttpGet]
        public List<Mascotas> recMascotas_ENT()
        {
            //VARIABLE
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            try
            {
                lobjRespuesta = gobjMascotasLN.recMascotas_ENT();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        [HttpGet]
        public Mascotas recMascotasXId_ENT(int pId)
        {
            //VARIABLE
            Mascotas lobjRespuesta = new Mascotas();
            try
            {
                lobjRespuesta = gobjMascotasLN.recMascotasXId_ENT(pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insMascotas([FromBody] Mascotas pMascotas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gobjMascotasLN.insMascotas_ENT(pMascotas);
                    return Ok(pMascotas);
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
