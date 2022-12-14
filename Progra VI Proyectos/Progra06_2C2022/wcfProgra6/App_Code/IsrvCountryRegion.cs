using Entidades;
using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract]
public interface IsrvCountryRegion
{
    //*************Entidades*************//

    [OperationContract]
    List<CountryRegion> recCountryRegion_ENT();

    [OperationContract]
    CountryRegion recCountryRegionXId_ENT(string pId);

    [OperationContract]
    bool insCountryRegion_ENT(CountryRegion pCountryRegion);

    [OperationContract]
    bool modCountryRegion_ENT(CountryRegion pCountryRegion);

    [OperationContract]
    bool delCountryRegion_ENT(CountryRegion pCountryRegion);

    //*************Procedimientos Almacenados*************//

    [OperationContract]
    List<recCountryRegions_Result> recCountryRegion_PA();

    [OperationContract]
    recCountryRegionsxId_Result recCountryRegionsxId_PA(string pId);

    [OperationContract]
    bool insCountryRegion_PA(CountryRegion pCountryRegion);

    [OperationContract]
    bool modCountryRegion_PA(CountryRegion pCountryRegion);

    [OperationContract]
    bool delCountryRegion_PA(CountryRegion pCountryRegion);
}
