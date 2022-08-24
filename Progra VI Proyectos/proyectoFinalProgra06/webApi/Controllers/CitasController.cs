using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
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
        //VARIABLES
        private readonly ICitasLN gobjCitasLN = new CitasLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();//VARIABLE EXECCIONES
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

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
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

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insCitas([FromBody] Citas pCitas)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCitasLN.insCitas_ENT(pCitas);
                    lEstado = true;

                }
                else
                {
                    lEstado = false;
                }
            }
            catch (Exception lEx)
            {

                // throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pCitas);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modCitas([FromBody] Citas pCitas)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCitasLN.modCitas_ENT(pCitas);
                    lEstado = true;

                }
                else
                {
                    lEstado = false;
                }
            }
            catch (Exception lEx)
            {

                // throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pCitas);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delCitas([FromBody] Citas pCitas)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCitasLN.delCitas_ENT(pCitas);
                    lEstado = true;

                }
                else
                {
                    lEstado = false;
                }
            }
            catch (Exception lEx)
            {

                // throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pCitas);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
