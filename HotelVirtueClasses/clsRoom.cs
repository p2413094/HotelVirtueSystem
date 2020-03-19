using System;

namespace HotelVirtueClasses
{
    public class clsRoom
    {
        public int HotelId { get; set; }
        public decimal Price { get; set; }
        public int RoomFloor { get; set; }
        public int RoomId { get; set; }
        public int RoomNo { get; set; }
        public int RoomTypeId { get; set; }
        public bool Accessible { get; set; }
        public bool Available { get; set; }

        public string Valid( string hotelId, string price, string roomFloor, string roomNo, string roomTypeId)
        {
            return "";
        }

        public bool Find(int roomId)
        {
            throw new NotImplementedException();
        }
    }
}