using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class Expenses
    {
        [Key]
        public int ExpenseId { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string ExpenseDeclaration { get; set; }
        public DateTime ExpenseDate { get; set; }
        public decimal ExpensePrice { get; set; }
    }
}