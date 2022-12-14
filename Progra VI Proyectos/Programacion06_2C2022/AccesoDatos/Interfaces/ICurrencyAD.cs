using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface ICurrencyAD
    {
        //**************ENTIDADES**************//
        List<Currency> recCurrency_ENT();
        Currency recCurrencyXId_ENT(string pId);
        bool insCurrency_ENT(Currency pCurrency);
        bool modCurrency_ENT(Currency pCurrency);
        bool delCurrency_ENT(Currency pCurrency);
        //**************PROCEDIMIENTOS ALMACENADOS**************//
        List<recCurrency_Result> recCurrency_PA();
        recCurrencyxId_Result recCurrencyXId_PA(string pId);
        bool insCurrency_PA(Currency pCurrency);
        bool modCurrency_PA(Currency pCurrency);
        bool delCurrency_PA(Currency pCurrency);
    }
}
