using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IsrvCurrency
{
    //*************Entidades*************//
    [OperationContract]

    List<Currency> recSalesCurrency_ENT();
    Currency recCurrencyXId_ENT(string pId);

    [OperationContract]
    bool modCurrency_ENT(Currency pCurrency);

    [OperationContract]
    bool insCurrency_ENT(Currency pCurrency);

    [OperationContract]
    bool delCurrency_ENT(Currency pCurrency);

    //*************Procedimientos Almacenados*************//

    [OperationContract]
    List<recCurrency_Result> recCurrency_PA();

    [OperationContract]
    recCurrencyxId_Result recCurrencyXId_PA(string pId);

    [OperationContract]
    bool insCurrency_PA(Currency pCurrency);

    [OperationContract]
    bool modCurrency_PA(Currency pCurrency);

    [OperationContract]
    bool delCurrency_PA(Currency pCurrency);
}
