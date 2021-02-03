using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class Product
    {
        [Key] public int ProductId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string ProductBrand { get; set; }

        
        [Range(0, Int32.MaxValue, ErrorMessage = "Sadece integer değer girebilirsiniz")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public short ProductStock { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public decimal ProductPurchasePrice { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public decimal ProductSalePrice { get; set; }
        
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public bool ProductState { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string ProductImage { get; set; }

        
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public virtual Category ProductCategory { get; set; }
        public ICollection<SaleMovement> ProductSaleMovements { get; set; }
    }
}