using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class srvCountryRegion : IsrvCountryRegion
{

    private readonly ICountryRegionLN gobjCountryRegionLN = new CountryRegionLN();

    //*************Entidades*************//

    public List<CountryRegion> recCountryRegion_ENT()
    {
        List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
        try
        {
            lobjRespuesta = gobjCountryRegionLN.recCountryRegion_ENT();
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
            lobjRespuesta = gobjCountryRegionLN.recCountryRegionXId_ENT(pId);

        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insCountryRegion_ENT(CountryRegion pCountryRegion)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCountryRegionLN.insCountryRegion_ENT(pCountryRegion);
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
            lobjRespuesta = gobjCountryRegionLN.modCountryRegion_ENT(pCountryRegion);
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
            lobjRespuesta = gobjCountryRegionLN.delCountryRegion_ENT(pCountryRegion);
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
            lobjRespuesta = gobjCountryRegionLN.recCountryRegion_PA();
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
            lobjRespuesta = gobjCountryRegionLN.recCountryRegionsxId_PA(pId);
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
            lobjRespuesta = gobjCountryRegionLN.insCountryRegion_PA(pCountryRegion);
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
            lobjRespuesta = gobjCountryRegionLN.modCountryRegion_PA(pCountryRegion);
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
            lobjRespuesta = gobjCountryRegionLN.delCountryRegion_PA(pCountryRegion);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

}
