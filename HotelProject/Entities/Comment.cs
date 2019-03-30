using OhmCrud;

namespace Hotelproject
{
    public class Comment: DbObject
    {
        public string Title { get; set; }
        public string Content { get; set; }
         public User User { get; set; } //dbfirst çalışsaydık user bu şekilde oluşturmamız gerekirdi.
    }

}