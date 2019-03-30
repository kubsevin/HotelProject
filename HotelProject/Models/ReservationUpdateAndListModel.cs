using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class ReservationUpdateAndListModel
    {
        public string ID { get; set; }
        [Display(Name = "Kişi Sayısı")]
        public int PersonCount { get; set; }
        [Display(Name = "Toplam Tutar")]
        public double TotalMoney { get; set; }
        [Display(Name = "Giriş Tarihi")]
        public DateTime CheckInDate { get; set; }
        [Display(Name = "Çıkış Tarihi")]
        public DateTime CheckOutDate { get; set; }
    }
}