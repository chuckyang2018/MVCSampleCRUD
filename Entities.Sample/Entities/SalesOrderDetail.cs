//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities.Sample.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesOrderDetail
    {
        public int SalesOrderID { get; set; }
        public int SalesOrderDetailID { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public short OrderQty { get; set; }
        public int ProductID { get; set; }
        public int SpecialOfferID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscount { get; set; }
        public decimal LineTotal { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }
    }
}
