using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotelproject.Entities
{
    public class Picture:DbObject
    {
        public string ImageUrl { get; set; }
    }
}