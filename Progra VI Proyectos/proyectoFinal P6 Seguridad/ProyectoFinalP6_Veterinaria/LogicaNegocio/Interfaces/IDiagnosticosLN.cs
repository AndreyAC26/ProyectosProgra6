using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public  interface IDiagnosticosLN
    {
        ///////****ENTIDADES****/////
        List<Diagnósticos> recDiagnosticos_ENT();
        Diagnósticos recDiagnosticosXId_ENT(int pId);
        bool insDiagnósticos_ENT(Diagnósticos pDiagnosticos);
        bool modDiagnósticos_ENT(Diagnósticos pDiagnosticos);
        bool delDiagnósticos_ENT(Diagnósticos pDiagnosticos);

        ///////****PROCEDIMIENTOS ALMACENADOS****/////
    }
}
