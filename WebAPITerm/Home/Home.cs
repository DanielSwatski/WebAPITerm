using System;

namespace TermProjectAPI
{
    public class Home
    {
        public String Homeaddress { get; set; }
        public String SellerUsername { get; set; }
        public String State { get; set; }
        public int ZipCode { get; set; }
        public String PropertyType { get; set; }
        public int HomeSize { get; set; }
        public int BedRoomNumber { get; set; }
        public int BathRoomNumber { get; set; }
        public String Amenities { get; set; }
        public String HVAC { get; set; }
        public String Utilities { get; set; }
        public int Yearbuilt { get; set; }
        public String Garage { get; set; }
        public String Description { get; set; }
        public int AskingPrice { get; set; }
        public String DateListed { get; set; }
        public String Photos { get; set; }


        public Home()
        {
        }

    }
}