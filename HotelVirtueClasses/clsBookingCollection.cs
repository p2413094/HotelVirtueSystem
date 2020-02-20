using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelVirtueClasses
{
    public class clsBookingCollection
    {
        List<clsBooking> mBookingList = new List<clsBooking>();
        clsBooking mThisBooking = new clsBooking();

        public clsBookingCollection()
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblBooking_SelectAll");
            recordCount = DB.Count;

            while (index < recordCount)
            {
                clsBooking ABooking = new clsBooking();
                ABooking.BookingId = Convert.ToInt32(DB.DataTable.Rows[index]["BookingId"]);
                ABooking.CustomerId = Convert.ToInt32(DB.DataTable.Rows[index]["CustomerId"]);
                ABooking.HotelId = Convert.ToInt32(DB.DataTable.Rows[index]["HotelId"]);
                ABooking.AdminId = Convert.ToInt32(DB.DataTable.Rows[index]["AdminId"]);
                ABooking.DateTimeOfBooking = Convert.ToDateTime(DB.DataTable.Rows[index]["DateTimeOfBooking"]);
                mBookingList.Add(ABooking);
                index++;
            }
        }

        public List<clsBooking> BookingList
        {
            get { return mBookingList; }
            set { mBookingList = value; }
        }

        public int Count
        {
            get { return mBookingList.Count; }
            set { }
        }
        public clsBooking ThisBooking
        {
            get { return mThisBooking; }
            set { mThisBooking = value; }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerId", mThisBooking.CustomerId);
            DB.AddParameter("HotelId", mThisBooking.HotelId);
            DB.AddParameter("AdminId", mThisBooking.AdminId);
            DB.AddParameter("DateTimeOfBooking", mThisBooking.DateTimeOfBooking);   
            return DB.Execute("sproc_tblBooking_Insert");
        }
    }
}
