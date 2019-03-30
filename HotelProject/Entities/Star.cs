using OhmCrud;

namespace Hotelproject
{
    public class Star: DbObject
    {
        public int LikeCount { get; set; }
        public int UnlikeCount { get; set; }
    }

}