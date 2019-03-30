using Hotelproject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class RoomTypeCreateModel
    {
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Resimler")]
        public List<Picture> Pictures { get; set; }
        public RoomTypeCreateModel()
        {
            Pictures = new List<Picture>();
        }
    }
}