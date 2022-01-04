using System;
using System.Collections.Generic;

#nullable disable

namespace SupermarketSystem.Models
{
    public partial class GoodsNameTbl
    {
        public GoodsNameTbl()
        {
            GoodsInfoTbls = new HashSet<GoodsInfoTbl>();
        }

        public int Id { get; set; }
        public int? Code { get; set; }
        public string Name { get; set; }
        public int? GoodsGroupTblId { get; set; }

        public virtual GoodsGroupTbl GoodsGroupTbl { get; set; }
        public virtual ICollection<GoodsInfoTbl> GoodsInfoTbls { get; set; }
    }
}
