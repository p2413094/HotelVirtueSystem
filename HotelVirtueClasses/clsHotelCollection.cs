﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelVirtueClasses
{
    public class clsHotelCollection
    {
        List<clsHotel> mAllHotelsList = new List<clsHotel>();
        clsHotel mThisHotel = new clsHotel();

        public clsHotelCollection()
        {
            Int32 Index = 0;
            Int32 recordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblHotel_SelectAll");
            recordCount = DB.Count;

            while (Index < recordCount)
            {
                clsHotel aHotel = new clsHotel();
                aHotel.HotelId = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelId"]);
                aHotel.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                aHotel.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                aHotel.ArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ArrivalDate"]);
                aHotel.DepartureDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DepartureDate"]);
                aHotel.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);

                mAllHotelsList.Add(aHotel);
                Index++;
            }


        }

        public List<clsHotel> HotelList
        {
            get { return mAllHotelsList; }
            set { mAllHotelsList = value; }
        }

        public int Count
        {
            get { return mAllHotelsList.Count; }
            set { }
        }

        public clsHotel ThisHotel
        {
            get { return mThisHotel; }
            set { mThisHotel = value; }
        }
    }
}