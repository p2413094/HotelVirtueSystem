using System;

namespace HotelVirtueClasses
{
    public class clsRoom
    {
        private Int32 mHotelId;
        public int HotelId
        {
            get
            {
                return mHotelId;
            }
            set
            {
                mHotelId = value;
            }
        }
        private decimal mPrice;
        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        private int mRoomFloor;
        public int RoomFloor
        {
            get
            {
                return mRoomFloor;
            }
            set
            {
                mRoomFloor = value;
            }
        }
        private int mRoomId;
        public int RoomId
        {
            get
            {
                return mRoomId;
            }
            set
            {
                mRoomId = value;
            }
        }
        private int mRoomNumber;
        public int RoomNumber
        {
            get
            {
                return mRoomNumber;
            }
            set
            {
                mRoomNumber = value;
            }
        }

        private int mRoomTypeId;
        public int RoomTypeId
        {
            get
            {
                return mRoomTypeId;
            }
            set
            {
                mRoomTypeId = value;
            }
        }

        private Boolean mAccessible;
        public bool Accessible
        {
            get
            {
                return mAccessible;
            }
            set
            {
                mAccessible = value;
            }
        }

        private Boolean mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }

        public string Valid(string RoomId, string Price, string RoomFloor, string RoomNumber, string RoomTypeId)
        {
            try
            {
                if (RoomId == "")
                {
                    //return a blank string
                    return "No Room Id Entered";
                }
                else
                {
                    int value = Convert.ToInt32(RoomId);
                    if (value > 1000)
                    {
                        //return a blank string
                        return "Room Id > 1000";
                    }
                  
                }

                if (Convert.ToDecimal(Price) > 100)
                {
                    return "Price > 1000";
                }

                if (Convert.ToInt32(RoomFloor) > 10)
                {
                    return "RoomFloor > 10";
                }

                if (Convert.ToInt32(RoomNumber) > 200)
                {
                    return "RoomNumber > 200" ;
                }

                if (Convert.ToInt32(RoomTypeId) > 1000)
                {
                    return "RoomTypeId > 1000";
                }

                return "";
            }
            catch (Exception ex)
            {
                //return a blank string
                return "Generic Error : " + ex.Message;
            }
        }

        public bool Find(int RoomId)
        {
            //initialise the DBConnection
            clsDataConnection DB = new clsDataConnection();
            //add the room id parameter
            DB.AddParameter("@RoomId", RoomId);
            //execute the query
            DB.Execute("sproc_tblRoom_FilterByRoomId");
            //if the record was found
            if (DB.Count == 1)
            {


                //get the HotelId
                mHotelId = Convert.ToInt32(DB.DataTable.Rows[0]["HotelId"]);
                //get the Price
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                //get the RoomFloor
                mRoomFloor = Convert.ToInt32(DB.DataTable.Rows[0]["RoomFloor"]);
                //get the RoomNumber
                mRoomNumber = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNumber"]);
                //get the room type id
                mRoomTypeId = Convert.ToInt32(DB.DataTable.Rows[0]["RoomTypeId"]);
                //get the available added

                try
                {
                    mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                }
                catch
                {
                    mAvailable = true;
                }
                //return success
                return true;
            }
            else
            {
                //return failure
                return false;
            }

        }
    }

    

}