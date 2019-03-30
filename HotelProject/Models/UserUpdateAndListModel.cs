using Hotelproject;
using HotelProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class UserUpdateAndListModel
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
        [Display(Name = "E mail")]
        public string Email { get; set; }
        [Display(Name = "T.C Kimlik No")]
        public string IdentityNumber { get; set; }
        [Display(Name = "Rezervasyonlar")]
        public List<Reservation> Reservations { get; set; }
        // public List<Comment> Comments { get; set; }
        public UserType UserType { get; set; }
        [Display(Name = "Ödeme Bilgileri")]
        public List<PaymentInformation> PaymentInformation { get; set; }
        public UserUpdateAndListModel()
        {
            PaymentInformation = new List<PaymentInformation>();
            Reservations = new List<Reservation>();
        }
    }
}