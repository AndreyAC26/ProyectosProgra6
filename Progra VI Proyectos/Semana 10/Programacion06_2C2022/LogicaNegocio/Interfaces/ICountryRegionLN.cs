using Entidades;
using System.Collections.Generic;

namespace LogicaNegocio.Interfaces
{
    public interface ICountryRegionLN
    {
        //**************ENTIDADES**************//
        List<CountryRegion> recCountryRegion_ENT();
        CountryRegion recCountryRegionXId_ENT(string pId);
        bool insCountryRegion_ENT(CountryRegion pCountryRegion);
        bool modCountryRegion_ENT(CountryRegion pCountryRegion);
        bool delCountryRegion_ENT(CountryRegion pCountryRegion);
        //**************PROCEDIMIENTOS ALMACENADOS**************//
        List<recCountryRegions_Result> recCountryRegion_PA();
        recCountryRegionsxId_Result recCountryRegionXId_PA(string pId);
        bool insCountryRegion_PA(CountryRegion pCountryRegion);
        bool modCountryRegion_PA(CountryRegion pCountryRegion);
        bool delCountryRegion_PA(CountryRegion pCountryRegion);
    }
}
