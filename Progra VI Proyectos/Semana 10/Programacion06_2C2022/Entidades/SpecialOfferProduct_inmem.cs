//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpecialOfferProduct_inmem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecialOfferProduct_inmem()
        {
            this.SalesOrderDetail_inmem = new HashSet<SalesOrderDetail_inmem>();
        }
    
        public int SpecialOfferID { get; set; }
        public int ProductID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Product_inmem Product_inmem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail_inmem> SalesOrderDetail_inmem { get; set; }
        public virtual SpecialOffer_inmem SpecialOffer_inmem { get; set; }
    }
}
