using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDND_ES.Models.Entities
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        [Required(ErrorMessage = "Username can't be empty!")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre(Tekrar) zorunludur.")]
        [Display(Name = "Password(again)")]
        [Compare("Password", ErrorMessage = "Passwords are not the same")]
        public string ConfirmPassword { get; set; }
    }
}