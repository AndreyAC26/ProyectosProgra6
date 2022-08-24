using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;

namespace LogicaNegocio.Implementacion
{
    public class FacturacionLN : IFacturacionLN
    {
        public static VeterinariaEntidades _objContextoAW = new VeterinariaEntidades();

        private readonly IFacturacionAD gobjFacturacionAD = new FacturacionAD(_objContextoAW);

        //**************ENTIDADES**************//
        public List<Facturacion> recFacturacion_ENT()
        {
            List<Facturacion> lobjRespuesta = new List<Facturacion>();
            try
            {
                lobjRespuesta = gobjFacturacionAD.recFacturacion_ENT();
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public Facturacion recFacturacionXId_ENT(int pId)
        {
            Facturacion lobjRespuesta = new Facturacion();
            try
            {
                lobjRespuesta = gobjFacturacionAD.recFacturacionXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insFacturacion_ENT(Facturacion pFacturacion)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjFacturacionAD.insFacturacion_ENT(pFacturacion);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modFacturacion_ENT(Facturacion pFacturacion)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjFacturacionAD.modFacturacion_ENT(pFacturacion);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delFacturacion_ENT(Facturacion pFacturacion)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjFacturacionAD.delFacturacion_ENT(pFacturacion);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
