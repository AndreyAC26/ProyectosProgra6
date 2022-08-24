using Entidades;
using System.Collections.Generic;

namespace AccesoDatos.Interfaces
{
    public interface ISalesCurrencyAD
    {
        //****************Entidades****************//

        List<Currency> recSalesCurrency_ENT();
        Currency recCurrencyXId_ENT(string pId);
        bool insCurrency_ENT(Currency pCurrency);
        bool modCurrency_ENT(Currency pCurrency);
        bool delCurrency_ENT(Currency pCurrency);

        //****************Procedimientos Almacenados****************//

        List<recCurrency_Result> recCurrency_PA();
        recCurrencyxId_Result recCurrencyXId_PA(string pId);
        bool insCurrency_PA(Currency pCurrency);
        bool modCurrency_PA(Currency pCurrency);
        bool delCurrency_PA(Currency pCurrency);


    }
}
