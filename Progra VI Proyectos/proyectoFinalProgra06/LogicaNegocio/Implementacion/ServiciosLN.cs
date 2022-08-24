using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;

namespace LogicaNegocio.Implementacion
{
    public class ServiciosLN : IServiciosLN
    {
        public static VeterinariaEntidades _objContextoAW = new VeterinariaEntidades();

        private readonly IServiciosAD gobjServiciosAD = new ServiciosAD(_objContextoAW);

        //**************ENTIDADES**************//
        public List<Servicios> recServicios_ENT()
        {
            List<Servicios> lobjRespuesta = new List<Servicios>();
            try
            {
                lobjRespuesta = gobjServiciosAD.recServicios_ENT();
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public Servicios recServiciosXId_ENT(int pId)
        {
            Servicios lobjRespuesta = new Servicios();
            try
            {
                lobjRespuesta = gobjServiciosAD.recServiciosXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insServicios_ENT(Servicios pServicios)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjServiciosAD.insServicios_ENT(pServicios);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modServicios_ENT(Servicios pServicios)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjServiciosAD.modServicios_ENT(pServicios);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delServicios_ENT(Servicios pServicios)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjServiciosAD.delServicios_ENT(pServicios);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
