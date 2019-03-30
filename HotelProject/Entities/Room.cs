using Hotelproject.Entities;
using OhmCrud;
using System.Collections.Generic;

namespace Hotelproject
{
    public class Room: DbObject
    {
        public List<Comment> Comment { get; set; }
        public List<Picture> Pictures { get; set; }
        public string Description { get; set; }
        public double RoomPrice { get; set; }
        public RoomType RoomType { get; set; }
                                           //    public bool RoomIsEmpty { get; set; } bunu controller halledecek
        public Room()
        {
            Comment = new List<Comment>();//her list görüdüğünü constractırın da tanımla
            Pictures = new List<Picture>();
        }

    }

}