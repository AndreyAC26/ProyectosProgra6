using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IsrvCitas
{
    [OperationContract]
    List<Citas> recCitas_ENT();
    [OperationContract]
    Citas recCitasXId_ENT(int pId);
    [OperationContract]
    bool insCitas_ENT(Citas pCitas);
    [OperationContract]
    bool modCitas_ENT(Citas pCitas);
    [OperationContract]
    bool delCitas_ENT(Citas pCitas);
}
