using Hotelproject;
using Hotelproject.Entities;
using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HotelProject.Classes
{
    public static class DbFactory
    {
        private static HotelContext _db = new HotelContext();
        private static GenelCrud<Comment> _commentCrud = null;
        public static GenelCrud<Comment> CommentCrud
        {
            get
            {
                if (_commentCrud == null)
                {
                    _commentCrud = new GenelCrud<Comment>(_db, _db.Comments);
                }
                return _commentCrud;
            }
        }

        private static GenelCrud<Content> _contentCrud = null;
        public static GenelCrud<Content> ContentCrud
        {
            get
            {
                if (_contentCrud == null)
                {
                    _contentCrud = new GenelCrud<Content>(_db, _db.Contents);
                }
                return _contentCrud;
            }
        }
        private static GenelCrud<Hotel> _hotelCrud = null;
        public static GenelCrud<Hotel> HotelCrud
        {
            get
            {
                if (_hotelCrud == null)
                {
                    _hotelCrud = new GenelCrud<Hotel>(_db, _db.Hotels);
                }
                return _hotelCrud;
            }
        }
        private static GenelCrud<Page> _pageCrud = null;
        public static GenelCrud<Page> PageCrud
        {
            get
            {
                if (_pageCrud == null)
                {
                    _pageCrud = new GenelCrud<Page>(_db, _db.Pages);
                }
                return _pageCrud;
            }
        }
        private static GenelCrud<PaymentInformation> _paymentInformationCrud = null;
        public static GenelCrud<PaymentInformation> PaymentInformationCrud
        {
            get
            {
                if (_paymentInformationCrud == null)
                {
                    _paymentInformationCrud = new GenelCrud<PaymentInformation>(_db, _db.PaymentInformations);
                }
                return _paymentInformationCrud;
            }
        }
        private static GenelCrud<Picture> _pictureCrud = null;
        public static GenelCrud<Picture> PictureCrud
        {
            get
            {
                if (_pictureCrud == null)
                {
                    _pictureCrud = new GenelCrud<Picture>(_db, _db.Pictures);
                }
                return _pictureCrud;
            }
        }
        private static GenelCrud<Reservation> _reservationCrud = null;
        public static GenelCrud<Reservation> ReservationCrud
        {
            get
            {
                if (_reservationCrud == null)
                {
                    _reservationCrud = new GenelCrud<Reservation>(_db, _db.Reservations);
                }
                return _reservationCrud;
            }
        }
        private static GenelCrud<Room> _roomCrud = null;
        public static GenelCrud<Room> RoomCrud
        {
            get
            {
                if (_roomCrud == null)
                {
                    _roomCrud = new GenelCrud<Room>(_db, _db.Rooms);
                }
                return _roomCrud;
            }
        }

        private static GenelCrud<RoomType> _roomTypeCrud = null;
        public static GenelCrud<RoomType> RoomTypeCrud
        {
            get
            {
                if (_roomTypeCrud == null)
                {
                    _roomTypeCrud = new GenelCrud<RoomType>(_db, _db.RoomTypes);
                }
                return _roomTypeCrud;
            }
        }
        private static GenelCrud<Slider> _sliderCrud = null;
        public static GenelCrud<Slider> SliderCrud
        {
            get
            {
                if (_sliderCrud == null)
                {
                    _sliderCrud = new GenelCrud<Slider>(_db, _db.Sliders);
                }
                return _sliderCrud;
            }
        }
        private static GenelCrud<Star> _starCrud = null;
        public static GenelCrud<Star> StarCrud
        {
            get
            {
                if (_starCrud == null)
                {
                    _starCrud = new GenelCrud<Star>(_db, _db.Stars);
                }
                return _starCrud;
            }
        }
        private static GenelCrud<User> _userCrud = null;
        public static GenelCrud<User> UserCrud
        {
            get
            {
                if (_userCrud == null)
                {
                    _userCrud = new GenelCrud<User>(_db, _db.Users);
                }
                return _userCrud;
            }
        }

    }
}