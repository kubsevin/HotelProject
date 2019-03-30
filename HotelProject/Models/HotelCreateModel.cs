using Hotelproject;
using Hotelproject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class HotelCreateModel
    {
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Fax")]
        public string Fax { get; set; }
        [Display(Name = "Yorumlar")]
        public List<Comment> Comments { get; set; }
        public List<Picture> Pictures { get; set; }
        public HotelCreateModel()
        {
            Comments = new List<Comment>();
            Pictures = new List<Picture>();
        }
    }
}