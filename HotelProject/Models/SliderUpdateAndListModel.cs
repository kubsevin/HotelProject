using Hotelproject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class SliderUpdateAndListModel
    {
        public string ID { get; set; }
        public List<Picture> Pictures { get; set; }
        public SliderUpdateAndListModel()
        {
            Pictures = new List<Picture>();
        }
    }
}