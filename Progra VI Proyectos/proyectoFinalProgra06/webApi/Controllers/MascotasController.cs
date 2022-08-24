using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace webApi.Controllers
{
    public class MascotasController : ApiController
    {
        //VARIABLE
        private readonly IMascotasLN gobjMascotasLN = new MascotasLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();//VARIABLE EXECCIONES


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

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
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

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insMascotas([FromBody] Mascotas pMascotas)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjMascotasLN.insMascotas_ENT(pMascotas);
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
                return Ok(pMascotas);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modMascotas([FromBody] Mascotas pMascotas)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjMascotasLN.insMascotas_ENT(pMascotas);
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
                return Ok(pMascotas);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delMascotas([FromBody] Mascotas pMascotas)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjMascotasLN.insMascotas_ENT(pMascotas);
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
                return Ok(pMascotas);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
