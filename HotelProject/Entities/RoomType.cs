using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotelproject.Entities
{
    public class RoomType :DbObject
    {
        public string Name { get; set; }
        public List<Picture> Pictures { get; set; }
        public RoomType()
        {
            Pictures = new List<Picture>();
        }
    }
}