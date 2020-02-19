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
            DB.Execute("sproc_tblBookingLine_SelectAll");
            recordCount = DB.Count;

            while (index < recordCount)
            {
                clsBooking ABooking = new clsBooking();
                ABooking.BookingLineId = Convert.ToInt32(DB.DataTable.Rows[index]["BookingLineId"]);
                ABooking.BookingId = Convert.ToInt32(DB.DataTable.Rows[index]["BookingId"]);
                ABooking.RoomId = Convert.ToInt32(DB.DataTable.Rows[index]["RoomId"]);
                ABooking.UnderFive = Convert.ToInt32(DB.DataTable.Rows[index]["UnderFive"]);
                ABooking.FiveToSixteen = Convert.ToInt32(DB.DataTable.Rows[index]["FiveToSixteen"]);
                ABooking.SixteenUpwards = Convert.ToInt32(DB.DataTable.Rows[index]["SixteenUpwards"]);
                ABooking.ArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[index]["ArrivalDate"]);
                ABooking.DepartureDate = Convert.ToDateTime(DB.DataTable.Rows[index]["DepartureDate"]);
                ABooking.GymAccess = Convert.ToBoolean(DB.DataTable.Rows[index]["GymAccess"]);
                ABooking.LateCheckout = Convert.ToBoolean(DB.DataTable.Rows[index]["LateCheckout"]);
                ABooking.Other = Convert.ToString(DB.DataTable.Rows[index]["Other"]);
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
            DB.AddParameter("BookingId", mThisBooking.BookingId);
            DB.AddParameter("RoomId", mThisBooking.RoomId);
            DB.AddParameter("UnderFive", mThisBooking.UnderFive);
            DB.AddParameter("FiveToSixteen", mThisBooking.FiveToSixteen);
            DB.AddParameter("SixteenUpwards", mThisBooking.SixteenUpwards);
            DB.AddParameter("ArrivalDate", mThisBooking.ArrivalDate);
            DB.AddParameter("DepartureDate", mThisBooking.DepartureDate);
            DB.AddParameter("GymAccess", mThisBooking.GymAccess);
            DB.AddParameter("LateCheckout", mThisBooking.LateCheckout);
            DB.AddParameter("Other", mThisBooking.Other);
            return DB.Execute("sproc_tblBookingLine_Insert");
        }
    }
}
