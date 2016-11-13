using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Group30_Final_Project.Models
{
    public class Employee
    {
        public string EmployeeID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        public string EmployeeFirstName { get; set; }

        [RegularExpression(@"/^[A - Z]$/", ErrorMessage = "Please enter only one letter.")]
        [Display(Name = "MI")]
        public string EmployeeMI { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        public string EmployeeLastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid email address.")]
        public string EmployeeEmail { get; set; }

        public string Password { get; set; }

        [Required(ErrorMessage = "Social Security number is required.")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "Please enter a valid Phone number.")]
        [Display(Name = "SSN")]
        public string EmployeeSSN { get; set; }

        public string EmployeeType { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid phone number.")]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$", ErrorMessage = "Please enter a valid Phone number.")]
        [DisplayFormat(DataFormatString = "{0:(###)###-####}",
            ApplyFormatInEditMode = true)]
        public string EmployeePhone { get; set; }

        public String EmployeeStreetAddress1 { get; set; }

        public String EmployeeStreetAddress2 { get; set; }

        [DataType(DataType.PostalCode, ErrorMessage = "Please enter a valid ZIP code.")]
        public String EmployeeZip { get; set; }

    }
}