    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Classes
{
    public class Department
    {
        [Key] 
        public int DepartmentId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(40, ErrorMessage = "Maksimum 30 karakter içerebilir!")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string DepartmentName { get; set; }
        public bool State { get; set; }
        public ICollection<Employee> EmployeesDepartment { get; set; }

    }
}