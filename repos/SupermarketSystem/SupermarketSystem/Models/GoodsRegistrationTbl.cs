using System;
using System.Collections.Generic;

#nullable disable

namespace SupermarketSystem.Models
{
    public partial class GoodsRegistrationTbl
    {
        public int Id { get; set; }
        public int? DocumentNumber { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? SuplierTblId { get; set; }

        public virtual SuplierTbl SuplierTbl { get; set; }
    }
}
