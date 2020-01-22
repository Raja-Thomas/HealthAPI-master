using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ClientApp.Models
{
    public class Employees
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the first name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [Display(Name = "FIRST NAME")]
        [StringLength(255, ErrorMessage = "Minimum 3 characters required", MinimumLength = 3)]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Enter the last name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [StringLength(255, ErrorMessage = "Minimum 3 characters required", MinimumLength = 3)]
        [Display(Name = "LAST NAME")]
        public string lastName { get; set; }
        [Display(Name = "NICK NAME")]
        public string nickName { get; set; }
        [Required(ErrorMessage = "Enter the email")]
        [EmailAddress(ErrorMessage = "Enter valid e-mail address.")]
        [Display(Name = "EMAIL")]
        public string Email { get; set; }
        [Display(Name = "ADDRESS")]
        [Required(ErrorMessage = "Enter the Address")]
        [StringLength(255, ErrorMessage = "Minimum 5 characters required", MinimumLength = 5)]
        public string Address { get; set; }
        [Display(Name = "ADDRESS2")]
        public string Address2 { get; set; }
        [Display(Name = "CITY")]
        [Required(ErrorMessage = "Enter the city")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [StringLength(255, ErrorMessage = "Minimum 3 characters required", MinimumLength = 3)]
        public string city { get; set; }
        [Display(Name = "COUNTRY")]
        [Required(ErrorMessage = "Enter the country")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [StringLength(255, ErrorMessage = "Minimum 3 characters required", MinimumLength = 3)]
        public string country { get; set; }
        public string DOB { get; set; }
        [Display(Name = "GENDER")]
        public string gender { get; set; }
        [Display(Name = " PASSWORD")]
        [StringLength(255, ErrorMessage = "Must be 6 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the password")]
        public string Password { get; set; }
        [Display(Name = " STATE")]
        [Required(ErrorMessage = "Enter the state")]
        public string State { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "CONFIRM PASSWORD")]
         [Compare("Password",
        ErrorMessage = "Password does not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "MOBILE")]
        [Required(ErrorMessage = "Enter the mobile number")]
        [StringLength(255, ErrorMessage = "Minimum 8 characters required", MinimumLength = 8)]
        public string mobile { get; set; }
    }
}
