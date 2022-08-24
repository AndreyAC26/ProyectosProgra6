using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface ICitasAD
    {
        List<Citas> recCitas_ENT();
        Citas recCitasXId_ENT(int pId);
        bool insCitas_ENT(Citas pCitas);
        bool modCitas_ENT(Citas pCitas);
        bool delCitas_ENT(Citas pCitas);

    }
}
