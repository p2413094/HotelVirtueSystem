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
        private decimal mTotal;

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

        public decimal Total
        {
            get { return mTotal; }
            set { mTotal = value; }
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
                mTotal = Convert.ToDecimal(DB.DataTable.Rows[0]["Total"]);
                return true;
            }

            else
            {
                return false;
            }          
        }
    }
}
