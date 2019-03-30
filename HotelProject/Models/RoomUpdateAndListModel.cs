using Hotelproject;
using Hotelproject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class RoomUpdateAndListModel
    {
        [Display(Name = "Yorumlar")]
        public List<Comment> Comment { get; set; }
        public List<Picture> Pictures { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Oda Ücreti")]
        public double RoomPrice { get; set; }
        [Display(Name = "Oda Tipi")]
        public RoomType RoomType { get; set; }
        //    public bool RoomIsEmpty { get; set; } bunu controller halledecek
        public RoomUpdateAndListModel()
        {
            Comment = new List<Comment>();//her list görüdüğünü constractırın da tanımla
            Pictures = new List<Picture>();
        }
    }
}