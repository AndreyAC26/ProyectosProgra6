using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IsrvCountryRegion
{
    //[OperationContract]

    //***************Entidades*************//
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


    //***********Procedimientos Almacenados*************//
    [OperationContract]
    List<recCountryRegions_Result> recCountryRegion_PA();

    [OperationContract]
    recCountryRegionsxId_Result recCountryRegion_PA(string pId);

    [OperationContract]
    bool insCountryRegion_PA(CountryRegion pCountryRegion);

    [OperationContract]
    bool modCountryRegion_PA(CountryRegion pCountryRegion);

    [OperationContract]
    bool delCountryRegion_PA(CountryRegion pCountryRegion);
}
