using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IServiciosLN
    {
        List<Servicios> recServicios_ENT();
        Servicios recServiciosXId_ENT(int pId);
        bool insServicios_ENT(Servicios pServicios);
        bool modServicios_ENT(Servicios pServicios);
        bool delServicios_ENT(Servicios pServicios);
    }
}
