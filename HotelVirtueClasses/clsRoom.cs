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

        public string Valid(string someRoom)
        {
            throw new NotImplementedException();
        }

        public bool Find(int roomId)
        {
            throw new NotImplementedException();
        }
    }
}