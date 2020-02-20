using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelVirtueClasses
{
    public class clsBooking
    {
        private Int32 mBookingId;
        private Int32 mCustomerId;
        private Int32 mHotelId;
        private Int32 mAdminId;
        private DateTime mDateTimeOfBooking;

        public int BookingId
        {
            get { return mBookingId; }
            set { mBookingId = value; }
        }

        public int CustomerId
        {
            get { return mCustomerId; }
            set { mCustomerId = value; }
        }

        public int HotelId
        {
            get { return mHotelId; }
            set { mHotelId = value; }
        }
        
        public int AdminId
        {
            get { return mAdminId; }
            set { mAdminId = value; }
        }

        public DateTime DateTimeOfBooking
        {
            get { return mDateTimeOfBooking; }
            set { mDateTimeOfBooking = value; }
        }


        public DateTime ArrivalDate { get; set; }
        public int BookingLineId { get; set; }
        public DateTime DepartureDate { get; set; }
        public int RoomId { get; set; }
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

        public bool Find(int bookingId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookingId", bookingId);
            DB.Execute("sproc_tblBooking_FilterByBookingId");
            if (DB.Count == 1)
            {
                mBookingId = Convert.ToInt32(DB.DataTable.Rows[0]["BookingId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mHotelId = Convert.ToInt32(DB.DataTable.Rows[0]["HotelId"]);
                mAdminId = Convert.ToInt32(DB.DataTable.Rows[0]["AdminId"]);
                mDateTimeOfBooking = Convert.ToDateTime(DB.DataTable.Rows[0]["DateTimeOfBooking"]);
                return true;
            }

            else
            {
                return false;
            }          
        }
    }
}
