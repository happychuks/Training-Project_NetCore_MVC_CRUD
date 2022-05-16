using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCore_MVC_CRUD.Models
{
    public class EmployeeMVcClass
    {
        [Key]
        public int EmployeeID { get; set; }


        [Required(ErrorMessage ="Enter Employee Surname")]
        [Display(Name ="Surname")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Enter Employee Firstname")]
        [Display(Name = "Firstname")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }


        [Display(Name = "Middlename")]
        [DataType(DataType.Text)]
        public string MiddleName { get; set; }


        [Required(ErrorMessage = "Enter Employee Mobile No")]
        [Display(Name = "Mobile No")]
        [DataType(DataType.PhoneNumber)]
        public string MobileNo { get; set; }


        [Required(ErrorMessage = "Enter Employee Address")]
        [Display(Name = "Residential Address")]
        public string ResidentialAddress { get; set; }


        [Required(ErrorMessage = "Enter Employee Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter Employee Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Enter Employee Age")]
        [Display(Name = "Age")]
        [Range(18,65)]
        public int Age { get; set; }


        [Required(ErrorMessage = "Enter Employee Marital Status")]
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }


        [Required(ErrorMessage = "Enter Employee Job Role")]
        [Display(Name = "Job Role")]
        public string JobRole { get; set; }


        [Required]
        [Display(Name = "Band Level")]
        public string Band { get; set; }

        
        [NotMapped]
        public IEnumerable<SelectListItem> BandList { set; get; }


    }
}
