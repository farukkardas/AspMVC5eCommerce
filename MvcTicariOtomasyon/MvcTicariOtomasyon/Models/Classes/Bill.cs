using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string BillSerialNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string BillOrderNo { get; set; }

        public DateTime BillDate { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string TaxOffice { get; set; }
        public DateTime BillHour { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string BillDeliever { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string BillReceiver { get; set; }

        public ICollection<BillContent> BillContents { get; set; }

    }
}