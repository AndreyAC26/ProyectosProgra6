using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvDeparment" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvDeparment
{
    [OperationContract]
    List<Department> recDeparment_ENT();
    [OperationContract]
    Department recDepartmentXId_ENT(short pId);
    [OperationContract]
    bool insDepartment_ENT(Department pDepartment);
    [OperationContract]
    bool modDepartment_ENT(Department pDepartment);
    [OperationContract]
    bool delDepartment_ENT(Department pDepartment);
}
