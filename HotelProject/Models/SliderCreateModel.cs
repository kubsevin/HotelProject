using Hotelproject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class SliderCreateModel
    {
        public List<Picture> Pictures { get; set; }
        public SliderCreateModel()
        {
            Pictures = new List<Picture>();
        }
    }
}