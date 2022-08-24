using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvMascotas" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvMascotas
{

    ///////****ENTIDADES****/////
    [OperationContract]
    List<Mascotas> recMascotas_ENT();
    [OperationContract]
    Mascotas recMascotasXId_ENT(int pId);
    [OperationContract]
    bool insMascotas_ENT(Mascotas pMascotas);
    [OperationContract]
    bool modMascotas_ENT(Mascotas pMascotas);
    [OperationContract]
    bool delMascotas_ENT(Mascotas pMascotas);

    ///////****PROCEDIMIENTOS ALMACENADOS****/////
    //[OperationContract]
    // void DoWork();
}
