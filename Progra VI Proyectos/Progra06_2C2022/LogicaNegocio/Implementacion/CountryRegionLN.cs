using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;

namespace LogicaNegocio.Implementacion
{
    public class CountryRegionLN : ICountryRegionLN
    {
        public static AWEntidades _objContextoAW = new AWEntidades();

        private readonly ICountryRegionAD gobjCountryRegionAD = new CountryRegionAD(_objContextoAW);

        //*************Entidades*************//

        public List<CountryRegion> recCountryRegion_ENT()
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            try
            {
                lobjRespuesta = gobjCountryRegionAD.recCountryRegion_ENT();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public CountryRegion recCountryRegionXId_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                lobjRespuesta = gobjCountryRegionAD.recCountryRegionXId_ENT(pId);

            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insCountryRegion_ENT(CountryRegion pCountryRegion)
        {
            bool  lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCountryRegionAD.insCountryRegion_ENT(pCountryRegion);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;

        }

        public bool modCountryRegion_ENT(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCountryRegionAD.modCountryRegion_ENT(pCountryRegion);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delCountryRegion_ENT(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCountryRegionAD.delCountryRegion_ENT(pCountryRegion);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }


        //*************Procedimientos Almacenados*************//

        public List<recCountryRegions_Result> recCountryRegion_PA()
        {
            List<recCountryRegions_Result> lobjRespuesta = new List<recCountryRegions_Result>();

            try
            {
                lobjRespuesta = gobjCountryRegionAD.recCountryRegion_PA();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public recCountryRegionsxId_Result recCountryRegionsxId_PA(string pId)
        {
            recCountryRegionsxId_Result lobjRespuesta = new recCountryRegionsxId_Result();

            try
            {
                lobjRespuesta = gobjCountryRegionAD.recCountryRegionsxId_PA(pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insCountryRegion_PA(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCountryRegionAD.insCountryRegion_PA(pCountryRegion);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modCountryRegion_PA(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCountryRegionAD.modCountryRegion_PA(pCountryRegion);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delCountryRegion_PA(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCountryRegionAD.delCountryRegion_PA(pCountryRegion);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
