using Entidades;
using System.Collections.Generic;

namespace AccesoDatos.Interfaces
{
    public interface ICountryRegionAD
     {
        //***********Entidades***************//

        List<CountryRegion> recCountryRegion_ENT();
        CountryRegion recCountryRegionXId_ENT(string pId);
        bool insCountryRegion_ENT(CountryRegion pCountryRegion);
        bool modCountryRegion_ENT(CountryRegion pCountryRegion);
        bool delCountryRegion_ENT(CountryRegion pCountryRegion);

        //***********Procedimientos Almacenados*************//

        List<recCountryRegions_Result> recCountryRegion_PA();
        recCountryRegionsxId_Result recCountryRegion_PA(string pId);
        bool insCountryRegion_PA(CountryRegion pCountryRegion);
        bool modCountryRegion_PA(CountryRegion pCountryRegion);
        bool delCountryRegion_PA(CountryRegion pCountryRegion);
    }


}
