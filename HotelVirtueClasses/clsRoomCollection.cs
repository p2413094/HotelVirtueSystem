using System.Collections.Generic;
using System;

namespace HotelVirtueClasses
{
    public class clsRoomCollection
    {
        List<clsRoom> mRoomList = new List<clsRoom>();
        clsRoom mThisRoom = new clsRoom();

        public List<clsRoom> RoomList
        {
            get { return mRoomList; }
            set { mRoomList = value; }
        }
        public int Count
        {
            get { return mRoomList.Count; }
            set { }
        }
        public clsRoom ThisRoom
        {
            get { return mThisRoom; }
            set { mThisRoom = value; }
        }

        public clsRoomCollection()
        {
            Int32 Index = 0;
            Int32 recordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblRoom_SelectAll");
            recordCount = DB.Count;
            while (Index < recordCount)
            {
                clsRoom aRoom = new clsRoom();
                aRoom.RoomId = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomId"]);
                aRoom.Accessible = Convert.ToBoolean(DB.DataTable.Rows[Index]["Accessible"]);
                aRoom.HotelId = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelId"]);
                aRoom.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                aRoom.RoomFloor = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomFloor"]);
                aRoom.RoomNo = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomNo"]);
                aRoom.RoomTypeId = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomTypeId"]);
                aRoom.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
              
                mRoomList.Add(aRoom);
                Index++;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@RoomId", mThisRoom.RoomId);
            DB.AddParameter("@Accessible", mThisRoom.Accessible);
            DB.AddParameter("@HotelId", mThisRoom.HotelId);
            DB.AddParameter("@Amount", mThisPayment.Amount);
            DB.AddParameter("@CardNumber", mThisPayment.CardNumber);
            DB.AddParameter("@NameOnCard", mThisPayment.NameOnCard);
            DB.AddParameter("@ExpiryDate", mThisPayment.ExpiryDate);
            DB.AddParameter("@SecurityCode", mThisPayment.SecurityCode);
            DB.AddParameter("@CardType", mThisPayment.CardType);
            return DB.Execute("sproc_tblPayment_Insert");
        }
    }
}