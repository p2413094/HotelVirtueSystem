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
            //string variable to store the error message 
            string Error = "";
            //if the name of the Room Description is more than 300 characters 
           if (someRoomType.Length > 300)
           {
                //return an error message
                Error = "The Room Description cannot have more than 300 characters";
           }
           if (someRoomType.Length ==0)
           {
                //return an error message
                Error = "The Room Description may not be blank!";
           }
            return Error;

        }
    }
}