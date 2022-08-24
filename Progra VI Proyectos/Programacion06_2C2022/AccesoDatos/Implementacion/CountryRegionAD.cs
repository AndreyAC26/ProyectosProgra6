using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class CountryRegionAD : ICountryRegionAD
    {

        private AWEntidades gObjConexionAW;        

        public CountryRegionAD(AWEntidades lObjConexionAW)
        {
            gObjConexionAW = lObjConexionAW;
        }

        //**************ENTIDADES**************//
        public List<CountryRegion> recCountryRegion_ENT()
        {
            List <CountryRegion> lobjRespuesta = new List<CountryRegion>();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.CountryRegion.ToList();
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }
        
        public CountryRegion recCountryRegionXId_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.CountryRegion.ToList().Find(cr=>cr.CountryRegionCode == pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool insCountryRegion_ENT(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false; 
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.CountryRegion.Find(pCountryRegion.CountryRegionCode);
                if(regEncontrado == null)
                {
                    gObjConexionAW.CountryRegion.Add(pCountryRegion);
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta=true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool modCountryRegion_ENT(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.CountryRegion.Find(pCountryRegion.CountryRegionCode);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pCountryRegion);
                    gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Modified;
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool delCountryRegion_ENT(CountryRegion pCountryRegion)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.CountryRegion.Find(pCountryRegion.CountryRegionCode);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pCountryRegion);
                    gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Deleted;
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        //**************PROCEDIMIENTOS ALMACENADOS**************//
        public List<recCountryRegions_Result> recCountryRegion_PA()
        {
            List<recCountryRegions_Result> lobjRespuesta = new List<recCountryRegions_Result>();
            try
            {
                lobjRespuesta = gObjConexionAW.recCountryRegions().ToList();
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public recCountryRegionsxId_Result recCountryRegionXId_PA(string pId)
        {
            recCountryRegionsxId_Result lobjRespuesta = new recCountryRegionsxId_Result();
            try
            {
                lobjRespuesta = gObjConexionAW.recCountryRegionsxId(pId).FirstOrDefault();
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
                if(gObjConexionAW.insCountryRegions(pCountryRegion.CountryRegionCode, pCountryRegion.Name) == 1)
                {
                    lobjRespuesta = true;
                }
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
                if (gObjConexionAW.modCountryRegions(pCountryRegion.CountryRegionCode, pCountryRegion.Name) == 1)
                {
                    lobjRespuesta = true;
                }
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
                if (gObjConexionAW.delCountryRegions(pCountryRegion.CountryRegionCode) == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

    }
}
