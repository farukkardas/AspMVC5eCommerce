using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class SaleMovement
    {
        [Key]
        public int SaleMovementId { get; set; }
        public DateTime SaleMovementDate  { get; set; }
        public int SaleMovementUnit { get; set; }
        public decimal SaleMovementPrice { get; set; }
        public decimal SaleMovementTotalPrice { get; set; }

        public Product Products { get; set; }
        public Customer Customers { get; set; }
        public Employee Employees { get; set; }

    }
}