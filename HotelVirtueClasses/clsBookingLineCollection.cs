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
            return mThisBookingLine.BookingLineId;
        }
    }
}