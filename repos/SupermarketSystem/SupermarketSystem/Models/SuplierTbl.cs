using System;
using System.Collections.Generic;

#nullable disable

namespace SupermarketSystem.Models
{
    public partial class SuplierTbl
    {
        public SuplierTbl()
        {
            GoodsRegistrationTbls = new HashSet<GoodsRegistrationTbl>();
        }

        public int Id { get; set; }
        public int? Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GoodsRegistrationTbl> GoodsRegistrationTbls { get; set; }
    }
}
