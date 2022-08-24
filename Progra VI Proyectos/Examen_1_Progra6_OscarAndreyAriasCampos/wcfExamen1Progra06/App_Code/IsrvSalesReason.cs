using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IsrvSalesReason
{
    [OperationContract]
    List<SalesReason> recSalesReason_ENT();

    [OperationContract]
    SalesReason recSalesReasonXId_ENT(int pId);

    [OperationContract]
    bool insSalesReason_ENT(SalesReason pSalesReason);

    [OperationContract]
    bool modSalesReason_ENT(SalesReason pSalesReason);

    [OperationContract]
    bool delSalesReason_ENT(SalesReason pSalesReason);

}
