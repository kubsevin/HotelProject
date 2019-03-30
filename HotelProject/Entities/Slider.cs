using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotelproject.Entities
{
    public class Slider:DbObject
    {
        public List<Picture> Pictures { get; set; }
        public Slider()
        {
            Pictures = new List<Picture>();
        }
    }
  
   
}