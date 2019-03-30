using OhmCrud;

namespace Hotelproject
{
    public class PaymentInformation: DbObject
    {
        public string NameOnCard { get; set; }
        public string CreditCardNo { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }

        public int CVC { get; set; }



    }
}