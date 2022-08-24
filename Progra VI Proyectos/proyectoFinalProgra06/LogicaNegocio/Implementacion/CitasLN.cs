using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;


namespace LogicaNegocio.Implementacion
{
    public class CitasLN : ICitasLN
    {
        public static VeterinariaEntidades _objContextoAW = new VeterinariaEntidades();

        private readonly ICitasAD gobjCitasAD = new CitasAD(_objContextoAW);

        //**************ENTIDADES**************//
        public List<Citas> recCitas_ENT()
        {
            List<Citas> lobjRespuesta = new List<Citas>();
            try
            {
                lobjRespuesta = gobjCitasAD.recCitas_ENT();
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public Citas recCitasXId_ENT(int pId)
        {
            Citas lobjRespuesta = new Citas();
            try
            {
                lobjRespuesta = gobjCitasAD.recCitasXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insCitas_ENT(Citas pCitas)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCitasAD.insCitas_ENT(pCitas);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modCitas_ENT(Citas pCitas)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCitasAD.modCitas_ENT(pCitas);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delCitas_ENT(Citas pCitas)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCitasAD.delCitas_ENT(pCitas);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
