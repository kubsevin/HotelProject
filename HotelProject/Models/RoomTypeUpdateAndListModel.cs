using Hotelproject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class RoomTypeUpdateAndListModel
    {
        public string ID { get; set; }
        [Display(Name = "Adı")]
        public string Name { get; set; }
        public List<Picture> Pictures { get; set; }
        public RoomTypeUpdateAndListModel()
        {
            Pictures = new List<Picture>();
        }
    }
}