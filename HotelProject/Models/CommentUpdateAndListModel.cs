using Hotelproject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class CommentUpdateAndListModel
    {

        public string ID { get; set; }
        [Display(Name = "YorumYapanKişi")]
        public User Commenter { get; set; }
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [Display(Name = "İçerik")]
        public string Content { get; set; }
    }
}