using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string CustomerName { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string CustomerLastName { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string CustomerCity { get; set; }

   
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CustomerMail { get; set; }
        public ICollection<SaleMovement> CustomerSaleMovement { get; set; }
    }
}