namespace Hotelproject
{
    using Hotelproject.Entities;
    using System.Data.Entity;
    using System.Linq;

    public class HotelContext : DbContext
    {
        // Your context has been configured to use a 'HotelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Hotelproject.HotelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HotelContext' 
        // connection string in the application configuration file.
        public HotelContext()
            : base("name=HotelContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Star> Stars { get; set; }
        public virtual DbSet<PaymentInformation> PaymentInformations { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }





    }
}