using System;
using System.Collections.Generic;

#nullable disable

namespace SupermarketSystem.Models
{
    public partial class GoodsGroupTbl
    {
        public GoodsGroupTbl()
        {
            GoodsNameTbls = new HashSet<GoodsNameTbl>();
        }

        public int Id { get; set; }
        public int? Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GoodsNameTbl> GoodsNameTbls { get; set; }
    }
}
