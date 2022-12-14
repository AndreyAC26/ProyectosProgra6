using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IMascotasLN
    {
        List<Mascotas> recMascotas_ENT();
        Mascotas recMascotasXId_ENT(int pId);
        bool insMascotas_ENT(Mascotas pMascotas);
        bool modMascotas_ENT(Mascotas pMascotas);
        bool delMascotas_ENT(Mascotas pMascotas);
    }
}
