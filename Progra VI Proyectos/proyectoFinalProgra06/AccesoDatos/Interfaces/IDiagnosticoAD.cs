using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IDiagnosticoAD
    {
        List<Diagnósticos> recDiagnósticos_ENT();
        Diagnósticos recDiagnósticosXId_ENT(int pId);
        bool insDiagnósticos_ENT(Diagnósticos pDiagnósticos);
        bool modDiagnósticos_ENT(Diagnósticos pDiagnósticos);
        bool delDiagnósticos_ENT(Diagnósticos pDiagnósticos);
    }
}
