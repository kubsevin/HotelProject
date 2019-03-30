using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class PaymentInformationModel
    {
        [Display(Name = "Kartın Adı")]
        public string NameOnCard { get; set; }
        [Display(Name = "Kredi Kartı Numarası")]
        public string CreditCardNo { get; set; }
        [Display(Name = "Son Kullanım Ayı")]
        public int ExpirationMonth { get; set; }
        [Display(Name = "Son Kullanım Yılı")]
        public int ExpirationYear { get; set; }
        public int CVC { get; set; }

    }
}