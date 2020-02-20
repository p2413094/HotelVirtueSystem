using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelVirtueClasses
{
    public class clsBookingLine
    {
        private Int32 mBookingLineId;
        private Int32 mBookingId;
        private Int32 mRoomId;
        private Int32 mUnderFive;
        private Int32 mFiveToSixteen;
        private Int32 mSixteenUpwards;
        private DateTime mArrivalDate;
        private DateTime mDepartureDate;
        private Boolean mGymAccess;
        private Boolean mLateCheckout;
        private string mOther;

        public int BookingLineId
        {
            get { return mBookingLineId; }
            set { mBookingLineId = value; }
        }
        public int BookingId
        {
            get { return mBookingId; }
            set { mBookingId = value; }
        }

        public int RoomId
        {
            get { return mRoomId; }
            set { mRoomId = value; }
        }

        public int UnderFive
        {
            get { return mUnderFive; }
            set { mUnderFive = value; }
        }
        public int FiveToSixteen
        {
            get { return mFiveToSixteen; }
            set { mFiveToSixteen = value; }
        }

        public int SixteenUpwards
        {
            get { return mSixteenUpwards; }
            set { mSixteenUpwards = value; }
        }
        public DateTime ArrivalDate
        {
            get { return mArrivalDate; }
            set { mArrivalDate = value; }
        }

        public DateTime DepartureDate
        {
            get { return mDepartureDate; }
            set { mDepartureDate = value; }
        }
        public bool GymAccess
        {
            get { return mGymAccess; }
            set { mGymAccess = value; }
        }
        public bool LateCheckout
        {
            get { return mLateCheckout; }
            set { mLateCheckout = value; }
        }
        public string Other
        {
            get { return mOther; }
            set { mOther = value; }
        }

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