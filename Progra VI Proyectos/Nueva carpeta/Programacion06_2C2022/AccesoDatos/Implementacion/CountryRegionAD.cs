using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class CountryRegionAD : ICountryRegionAD
    {
        private AWEntidades gObjConecionAW;

        public CountryRegionAD(AWEntidades lObjConecionAW)
        {
            gObjConecionAW = lObjConecionAW;
        }

             //***********Entidades***************//

        public List<CountryRegion> recCountryRegion_ENT()
        {
            bool lProxy = gObjConecionAW.Configuration.ProxyCreationEnabled;
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            try
            {
                gObjConecionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConecionAW.CountryRegion.ToList();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConecionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public CountryRegion recCountryRegionXId_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                gObjConecionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConecionAW.CountryRegion.ToList().Find(cr=>cr.CountryRegionCode == pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConecionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool insCountryRegion_ENT(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                var regEncontrado = gObjConecionAW.CountryRegion.Find(pCountryRegion.CountryRegionCode);
                if (regEncontrado == null)
                {
                    gObjConecionAW.Configuration.ProxyCreationEnabled = false;
                    gObjConecionAW.CountryRegion.Add(pCountryRegion);
                    gObjConecionAW.SaveChanges();
                    lobjRespuesta=true;
                }

            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConecionAW.Configuration.ProxyCreationEnabled = false;
                gObjConecionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool modCountryRegion_ENT(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                var regEncontrado = gObjConecionAW.CountryRegion.Find(pCountryRegion.CountryRegionCode);
                if (regEncontrado != null)
                {
                    gObjConecionAW.Configuration.ProxyCreationEnabled = false;
                    gObjConecionAW.Entry(regEncontrado).CurrentValues.SetValues(pCountryRegion);
                    gObjConecionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Modified;

                    gObjConecionAW.SaveChanges();
                    lobjRespuesta = true;
                }

            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConecionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool delCountryRegion_ENT(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                var regEncontrado = gObjConecionAW.CountryRegion.Find(pCountryRegion.CountryRegionCode);
                if (regEncontrado != null)
                {
                    gObjConecionAW.Configuration.ProxyCreationEnabled = false;
                    gObjConecionAW.Entry(regEncontrado).CurrentValues.SetValues(pCountryRegion);
                    gObjConecionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Deleted;
                    gObjConecionAW.SaveChanges();
                    lobjRespuesta = true;
                }

            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            finally
            {
                gObjConecionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        //***********Procedimientos Almacenados*************//
        public List<recCountryRegions_Result> recCountryRegion_PA()
        {
            List<recCountryRegions_Result> lobjRespuesta = new List<recCountryRegions_Result>();

            try
            {
                lobjRespuesta = gObjConecionAW.recCountryRegions().ToList();
            }
            catch (Exception lEX)
            {

                throw lEX;
            }
            return lobjRespuesta;
        }

        public recCountryRegionsxId_Result recCountryRegion_PA(string pId)
        {
            recCountryRegionsxId_Result lobjRespuesta = new recCountryRegionsxId_Result();

            try
            {
                lobjRespuesta = gObjConecionAW.recCountryRegionsxId(pId).FirstOrDefault();
            }
            catch (Exception lEX)
            {

                throw lEX;
            }
            return lobjRespuesta;
        }

        public bool insCountryRegion_PA(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gObjConecionAW.insCountryRegions(pCountryRegion.CountryRegionCode, pCountryRegion.Name) == 1)
                {
                    lobjRespuesta = true;
                }            }
            catch (Exception lEX)
            {

                throw lEX;
            }
            return lobjRespuesta;
        }

        public bool modCountryRegion_PA(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gObjConecionAW.modCountryRegions(pCountryRegion.CountryRegionCode, pCountryRegion.Name) == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEX)
            {

                throw lEX;
            }
            return lobjRespuesta;
        }

        public bool delCountryRegion_PA(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gObjConecionAW.delCountryRegions(pCountryRegion.CountryRegionCode) == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEX)
            {

                throw lEX;
            }
            return lobjRespuesta;
        }


    }
}
