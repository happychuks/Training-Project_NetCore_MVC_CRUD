using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_MVC_CRUD.Models
{
    [Table("EmployeeSalaryTable")]
    public class EmployeeSalaryScale
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Enter Employee Band Level")]

        [Display(Name = "Band Level")]
        public int Band { get; set; }


        [Display(Name = "Basic Salary")]
        public decimal BasicSalary { get; set; }


        [Display(Name = "Total Deductions")]
        public decimal Deductions { get; set; }


        [Display(Name = "Amount Payable")]
        public decimal AmountPaid { get; set; }
    }
}

