//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameMall_Data.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Evaluation = new HashSet<Evaluation>();
            this.Invoice = new HashSet<Invoice>();
            this.StockLog = new HashSet<StockLog>();
        }
    
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int CustomerId { get; set; }
        public int VersionId { get; set; }
        public int WarehouseId { get; set; }
        public int OrderGoodsNumber { get; set; }
        public float Price { get; set; }
        public int OrderStatus { get; set; }
        public System.DateTime OrderTime { get; set; }
        public string Express { get; set; }
        public string SellerMessage { get; set; }
        public string GoodsName { get; set; }
        public string VersionName { get; set; }
        public string DeliveryName { get; set; }
        public string TelNum { get; set; }
        public string Province { get; set; }
        public string Area { get; set; }
        public string Street { get; set; }
        public string DetailAddress { get; set; }
    
        public virtual Customers Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual Goods Goods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual Versions Versions { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLog> StockLog { get; set; }
    }
}
