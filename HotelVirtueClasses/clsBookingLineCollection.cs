using System;
using System.Collections.Generic;

namespace HotelVirtueClasses
{
    public class clsBookingLineCollection
    {
        List<clsBookingLine> mBookingLineList = new List<clsBookingLine>();
        clsBookingLine mThisBookingLine = new clsBookingLine();

        public List<clsBookingLine> BookingLineList
        {
            get { return mBookingLineList; }
            set { mBookingLineList = value; }
        }

        public int Count
        {
            get { return mBookingLineList.Count; }
            set { }
        }
        public clsBookingLine thisBookingLine
        {
            get { return mThisBookingLine; }
            set { mThisBookingLine = value; }
        }

        public clsBookingLineCollection()
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblBookingLine_SelectAll");
            recordCount = DB.Count;
            while (index < recordCount)
            {
                clsBookingLine aBookingLine = new clsBookingLine();
                aBookingLine.BookingLineId = Convert.ToInt32(DB.DataTable.Rows[index]["BookingLineId"]);
                aBookingLine.BookingId = Convert.ToInt32(DB.DataTable.Rows[index]["BookingId"]);
                aBookingLine.UnderFive = Convert.ToInt32(DB.DataTable.Rows[index]["UnderFive"]);
                aBookingLine.FiveToSixteen = Convert.ToInt32(DB.DataTable.Rows[index]["FiveToSixteen"]);
                aBookingLine.SixteenUpwards = Convert.ToInt32(DB.DataTable.Rows[index]["SixteenUpwards"]);
                aBookingLine.ArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[index]["ArrivalDate"]);
                aBookingLine.DepartureDate = Convert.ToDateTime(DB.DataTable.Rows[index]["DepartureDate"]);
                aBookingLine.GymAccess = Convert.ToBoolean(DB.DataTable.Rows[index]["GymAccess"]);
                aBookingLine.LateCheckout = Convert.ToBoolean(DB.DataTable.Rows[index]["LateCheckout"]);
                aBookingLine.Other = Convert.ToString(DB.DataTable.Rows[index]["Other"]);
                mBookingLineList.Add(aBookingLine);
                index++;
            }
            
        }

        public int Add()
        {
            Int32 bookingId;
            clsBookingCollection bookings = new clsBookingCollection();
            bookings.ThisBooking.CustomerId = 1;
            bookings.ThisBooking.HotelId = 1;
            bookings.ThisBooking.AdminId = 1;
            bookings.ThisBooking.DateTimeOfBooking = DateTime.Now;
            bookingId = bookings.Add();

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookingId", bookingId);
            DB.AddParameter("@RoomId", mThisBookingLine.RoomId);
            DB.AddParameter("@UnderFive", mThisBookingLine.UnderFive);
            DB.AddParameter("@FiveToSixteen", mThisBookingLine.FiveToSixteen);
            DB.AddParameter("@SixteenUpwards", mThisBookingLine.SixteenUpwards);
            DB.AddParameter("@ArrivalDate", mThisBookingLine.ArrivalDate);
            DB.AddParameter("@DepartureDate", mThisBookingLine.DepartureDate);
            DB.AddParameter("@GymAccess", mThisBookingLine.GymAccess);
            DB.AddParameter("@LateCheckout", mThisBookingLine.LateCheckout);
            DB.AddParameter("@Other", mThisBookingLine.Other);

            return DB.Execute("sproc_tblBookingLine_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookingLineId", mThisBookingLine.BookingLineId);
            DB.Execute("sproc_tblBookingLine_Delete");

            clsBookingCollection bookings = new clsBookingCollection();
            bookings.ThisBooking.BookingId = mThisBookingLine.BookingId;
            bookings.Delete();
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookingLineId", mThisBookingLine.BookingLineId);
            DB.AddParameter("@Other", mThisBookingLine.Other);
            DB.Execute("sproc_tblBookingLine_Update");
        }
    }
}