
using HotelProject.Entities.Enums;
using OhmCrud;
using System.Collections.Generic;

namespace Hotelproject
{
    public class User:DbObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public List<Reservation> Reservations { get; set; }
       // public List<Comment> Comments { get; set; }
        public UserType UserType { get; set; }
        public List<PaymentInformation> PaymentInformation { get; set; }
        public User()
        {
            PaymentInformation = new List<PaymentInformation>();
            Reservations = new List<Reservation>();
        }


    }

}