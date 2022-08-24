using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;//AGREGAR

namespace AccesoDatos.Interfaces
{
    public interface IDiagnosticos
    {
        ///////****ENTIDADES****/////
        List<Diagnósticos> recDiagnosticos_ENT();
        Diagnósticos recDiagnosticosXId_ENT(int pId);
        bool insDiagnosticos_ENT(Diagnósticos pDiagnostico);
        bool modDiagnosticos_ENT(Diagnósticos pDiagnostico);
        bool delDiagnosticos_ENT(Diagnósticos pDiagnostico);

        //////////****PROCEDIMIENTOS ALMACENADOS****/////
    }
}
