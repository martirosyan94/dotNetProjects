using System;
using System.Collections.Generic;

#nullable disable

namespace SupermarketSystem.Models
{
    public partial class GoodsInfoTbl
    {
        public int Id { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? Ammount { get; set; }
        public int? PurchcasePrise { get; set; }
        public int? SalePrice { get; set; }
        public int? GoodsNameTblId { get; set; }

        public virtual GoodsNameTbl GoodsNameTbl { get; set; }
    }
}
