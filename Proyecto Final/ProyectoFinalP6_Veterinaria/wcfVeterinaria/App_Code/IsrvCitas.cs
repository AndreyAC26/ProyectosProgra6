using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvCitas" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvCitas
{
    ///////****ENTIDADES****/////
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

    ///////****PROCEDIMIENTOS ALMACENADOS****/////
    //[OperationContract]
    //void DoWork();
}
