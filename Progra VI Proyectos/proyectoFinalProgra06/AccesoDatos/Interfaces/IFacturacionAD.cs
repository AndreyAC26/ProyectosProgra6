﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IFacturacionAD
    {
        List<Facturacion> recFacturacion_ENT();
        Facturacion recFacturacionXId_ENT(int pId);
        bool insFacturacion_ENT(Facturacion pFacturacion);
        bool modFacturacion_ENT(Facturacion pFacturacion);
        bool delFacturacion_ENT(Facturacion pFacturacion);
    }
}
