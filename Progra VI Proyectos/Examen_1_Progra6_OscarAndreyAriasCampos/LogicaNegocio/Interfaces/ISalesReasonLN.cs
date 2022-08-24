using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface ISalesReasonLN
    {
        List<SalesReason> recSalesReason_ENT();

        SalesReason recSalesReasonXId_ENT(int pId);

        bool insSalesReason_ENT(SalesReason pSalesReason);

        bool modSalesReason_ENT(SalesReason pSalesReason);

        bool delSalesReason_ENT(SalesReason pSalesReason);
    }
}
