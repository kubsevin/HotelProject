using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class Register
    {
        [Display(Name = "Adı")]
        public string FirstName { get; set; }
        [Display(Name = "Soyadı")]
        public string LastName { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "T.C. Kimlik Numarası")]
        public string IdentityNumber { get; set; }
    }
}