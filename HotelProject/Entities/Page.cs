using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotelproject.Entities
{
    public class Page:DbObject
    {
        public string Name { get; set; }
        public Slider Slider { get; set; }
        public List<Content> Contents { get; set; }
        public Page()
        {
            Contents = new List<Content>();
        }
    }
}