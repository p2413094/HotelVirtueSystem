using System;
using HotelVirtueClasses;

namespace HotelVirtueClasses
{
    public class clsRoom
    {
        
        
       
       
       
        //HotelId private member variable
        private string mHotelId;
        //HotelId public property
        public string HotelId
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

        //Price private member variable
        private decimal mPrice;
        //Price  public property
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

        //RoomFloor private member variable
        private int mRoomFloor;


        //RoomFloor public property
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

        //RoomId private member variable
        private string mRoomId;
        //RoomId public property
        public string RoomId
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

        //RoomNumber private member variable
        private int mRoomNumber;
        //RoomNumber public property
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

        //RoomTypeId private member variable
        private string mRoomTypeId;
        //RoomTypeId public property
        public string RoomTypeId
        {
            get
            {
                return mRoomTypeId;
            }
            set
            {
                mHotelId = value;
            }
        }

        //Accessible private member variable
        private Boolean mAccessible;
        //Accessible public property
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

        //Available private member variable
        private Boolean mAvailable;


        //Available public property
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

        public string Valid( string hotelId, string price, string roomFloor, string roomNumber, string roomTypeId)
        {
            return "";
        }

        public bool Find(int roomId)
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
                mHotelId = Convert.ToString(DB.DataTable.Rows[0]["HotelId"]);
                //get the Price
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                //get the RoomFloor
                mRoomFloor = Convert.ToInt32(DB.DataTable.Rows[0]["RoomFloor"]);
                //get the RoomNumber
                mRoomNumber = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNumber"]);
                //get the room type id
                mRoomTypeId = Convert.ToString(DB.DataTable.Rows[0]["RoomTypeId"]);
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
