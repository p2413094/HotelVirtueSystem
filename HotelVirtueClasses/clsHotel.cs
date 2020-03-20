using System;

namespace HotelVirtueClasses
{
    public class clsHotel
    {
        public int HotelId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string Location { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Name { get; set; }
        public int NumberofGuests { get; set; }
        public int UnderFive { get; set; }
        public int FiveToSixteen { get; set; }
        public int SixteenUpwards { get; set; }
        public string PostCode { get; set; }

        public string Valid(DateTime arrivalDate, DateTime departureDate)
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
            return error;
        }
    }
}