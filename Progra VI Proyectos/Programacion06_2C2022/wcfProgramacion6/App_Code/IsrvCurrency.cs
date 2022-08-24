using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvCurrency" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvCurrency
{
    [OperationContract]
    List<Currency> recCurrency_ENT();

    [OperationContract]
    Currency recCurrencyXId_ENT(string pId);

    [OperationContract]
    bool insCurrency_ENT(Currency pCurrency);

    [OperationContract]
    bool modCurrency_ENT(Currency pCurrency);

    [OperationContract]
    bool delCurrency_ENT(Currency pCurrency);
}
