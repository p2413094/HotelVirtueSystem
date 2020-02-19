using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelVirtueClasses
{
    public class clsBooking
    {
        public int AdminId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int BookingId { get; set; }
        public int BookingLineId { get; set; }
        public DateTime DepartureDate { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateTimeOfBooking { get; set; }
        public int UnderFive { get; set; }
        public int FiveToSixteen { get; set; }
        public int SixteenUpwards { get; set; }
        public string Other { get; set; }
        public bool GymAccess { get; set; }
        public bool LateCheckout { get; set; }

        public string Valid(DateTime arrivalDate, DateTime departureDate, string other)
        {
            string error = "";
            DateTime todaysDate = DateTime.Now.Date;
            DateTime todaysDateAddHundredDays = DateTime.Now.Date.AddDays(100);

            if (arrivalDate > todaysDate)
            {
                error += " Date must be right now, not in the future";
            }

            if (arrivalDate < todaysDate)
            {
                error += "Arrival date must not be in the past";
            }

            if (departureDate == arrivalDate)
            {
                error += "Departure date must at least one day after the arrival date";
            }

            if (departureDate < arrivalDate)
            {
                error += "Departure date must not be before the arrival date";
            }

            if (departureDate >= todaysDateAddHundredDays)
            {
                error += "Departure date must not be more than 100 days into the future";
            }
            

            if (other.Length <= 0)
            {
                error += "Other must not be empty";
            }

            if (other.Length > 50)
            {
                error += "Other must not be more than 50 characters";
            }

            return error;
        }
    }
}
