//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVC_Demo_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required, Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public System.DateTime HireDate { get; set; }

        [Required, Display(Name = "Email Address")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please provide valid email address")]
        public string Email { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int DepartmentID { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
