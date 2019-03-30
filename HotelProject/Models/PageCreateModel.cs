using Hotelproject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class PageCreateModel
    {
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Slayt")]
        public Slider Slider { get; set; }
        [Display(Name = "İçerik")]
        public List<Content> Contents { get; set; }
        public PageCreateModel()
        {
            Contents = new List<Content>();
        }
    }
}