using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotelproject.Entities
{
    public class Content: DbObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Picture Image { get; set; }

    }
}