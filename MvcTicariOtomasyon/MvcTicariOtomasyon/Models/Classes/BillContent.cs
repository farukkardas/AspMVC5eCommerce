using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class BillContent
    {
        [Key]
        public int BillContentId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Declaration { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice  { get; set; }
        public decimal TotalPrice { get; set; }

        public Bill Bills { get; set; }
    }
}