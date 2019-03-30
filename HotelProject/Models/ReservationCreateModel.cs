using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class ReservationCreateModel
    {
        [Display(Name = "Kişi Sayısı")]
        public int PersonCount { get; set; }
        [Display(Name = "Toplam Tutar")]
        public double TotalMoney { get; set; }
        [Display(Name = "Giriş Tarihi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckInDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Çıkış Tarihi")]
        public DateTime CheckOutDate { get; set; }
       //public Room RezervedRoom { get; set; }
       //public User User { get; set; }
    }
}