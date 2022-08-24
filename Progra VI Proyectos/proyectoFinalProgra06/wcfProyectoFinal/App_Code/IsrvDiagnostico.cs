using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IsrvDiagnostico
{
    [OperationContract]
    List<Diagnósticos> recDiagnósticos_ENT();
    [OperationContract]
    Diagnósticos recDiagnósticosXId_ENT(int pId);
    [OperationContract]
    bool insDiagnósticos_ENT(Diagnósticos pDiagnósticos);
    [OperationContract]
    bool modDiagnósticos_ENT(Diagnósticos pDiagnósticos);
    [OperationContract]
    bool delDiagnósticos_ENT(Diagnósticos pDiagnósticos);
}
