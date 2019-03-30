using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotelproject.Entities
{
    public class Hotel:DbObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Fax { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Picture> Pictures { get; set; }
        public Hotel()
        {
            Comments = new List<Comment>();
            Pictures = new List<Picture>();
        }

    }
}