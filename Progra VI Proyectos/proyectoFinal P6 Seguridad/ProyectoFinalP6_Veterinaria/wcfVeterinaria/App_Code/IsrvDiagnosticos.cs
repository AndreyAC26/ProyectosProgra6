using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvDiagnosticos" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvDiagnosticos
{
    ///////****ENTIDADES****/////
    [OperationContract]
    List<Diagnósticos> recDiagnosticos_ENT();
    [OperationContract]
    Diagnósticos recDiagnosticosXId_ENT(int pId);
    [OperationContract]
    bool insDiagnósticos_ENT(Diagnósticos pDiagnosticos);
    [OperationContract]
    bool modDiagnósticos_ENT(Diagnósticos pDiagnosticos);
    [OperationContract]
    bool delDiagnósticos_ENT(Diagnósticos pDiagnosticos);


    ///////****PROCEDIMIENTOS ALMACENADOS****/////
    //[OperationContract]
    //void DoWork();
}
