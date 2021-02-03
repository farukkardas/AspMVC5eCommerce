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
        [StringLength(40, ErrorMessage = "Maksimum 40 karakter içerebilir!")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string CustomerName { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(40, ErrorMessage = "Maksimum 40 karakter içerebilir!")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string CustomerLastName { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(15, ErrorMessage = "Maksimum 15 karakter içerebilir!")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string CustomerCity { get; set; }

   
        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "Maksimum 100 karakter içerebilir!")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string CustomerMail { get; set; }

        public bool Durum { get; set; }
        public ICollection<SaleMovement> CustomerSaleMovement { get; set; }
    }
}