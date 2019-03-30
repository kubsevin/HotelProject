using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class Login
    {
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}