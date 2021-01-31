    using System;
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string AdminUsername { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string AdminPassword { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(1)]
        public string Authority { get; set; }
    }
}