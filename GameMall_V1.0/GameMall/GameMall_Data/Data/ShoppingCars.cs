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
    
    public partial class ShoppingCars
    {
        public int ShoppingCarId { get; set; }
        public int CustomerId { get; set; }
        public int GoodsId { get; set; }
        public int VersionId { get; set; }
        public int ShoppingCarGoodsNumber { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Goods Goods { get; set; }
        public virtual Versions Versions { get; set; }
    }
}