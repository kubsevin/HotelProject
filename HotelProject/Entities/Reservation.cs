namespace Hotelproject
{
    using OhmCrud;
    using System;

    public class Reservation : DbObject
    {
        public int PersonCount { get; set; }
        public double TotalMoney { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Room RezervedRoom { get; set; }

    }

}