using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IsrvMascotas
{
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
}
