using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName ="Varchar")]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string ProductBrand { get; set; }
        public short ProductStock { get; set; }
        public decimal ProductPurchasePrice { get; set; }
        public decimal ProductSalePrice { get; set; }
        public bool ProductState { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string ProductImage { get; set; }
        public Category ProductCategory { get; set; }
        public ICollection<SaleMovement> ProductSaleMovements { get; set; }
    }
}