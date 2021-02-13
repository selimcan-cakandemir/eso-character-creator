using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectElderScrolls.Models
{
    public class AppUser
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Username can't be left empty!")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email can't be left empty!")]
        [EmailAddress(ErrorMessage = "Input must be an e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password required.")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password(again) required.")]
        [Display(Name = "Password(again)")]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }
    }
}