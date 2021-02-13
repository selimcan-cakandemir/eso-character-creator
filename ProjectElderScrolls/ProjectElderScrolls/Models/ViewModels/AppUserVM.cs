using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectElderScrolls.Models.ViewModels
{
    public class AppUserVM
    {
        [Required(ErrorMessage = "Username can't be empty!")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password required.")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}