using System;

namespace HotelVirtueClasses
{
    public class clsRoomType
    {
        public int RoomTypeId { get; set; }
        public int DoubleBed { get; set; }
        public object SingleBed { get; set; }
        public string Description { get; set; }
        public string Descripton { get; set; }
        public int MaximumOccupancy { get; set; }

        public string Valid(string someRoomType)
        {
            //if the name of the county is not blank 
            if (someRoomType != "")
            {
                //return a blank string 
                return "";
            }
            else
            {
                //otherwise return an error message
                return "The room type may not be blank!";
            }

        }
    }
}