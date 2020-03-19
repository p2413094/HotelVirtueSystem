using System;
using HotelVirtueClasses;

namespace HotelVirtueClasses
{
    public class clsRoom
    {
        
        
       
       
        //public int RoomNumber { get; set; }
        //public int RoomTypeId { get; set; }
        //public bool Accessible { get; set; }
        //public bool Available { get; set; }

        //houseNo private member variable
        private string mHotelId;
        //HouseNo public property
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

        //houseNo private member variable
        private decimal mPrice;
        //HouseNo public property
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

        //houseNo private member variable
        private int mRoomFloor;
       

        //HouseNo public property
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

        //houseNo private member variable
        private string mRoomId;
        //HouseNo public property
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

        //houseNo private member variable
        private int mRoomNumber;
        //HouseNo public property
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

        //houseNo private member variable
        private string mRoomTypeId;
        //HouseNo public property
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

        //houseNo private member variable
        private Boolean mAccessible;
        //HouseNo public property
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

        //houseNo private member variable
        private Boolean mAvailable;
        

        //HouseNo public property
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
            //add the address no parameter
            DB.AddParameter("@RoomId", RoomId);
            //execute the query
            DB.Execute("sproc_tblRoom_FilterByRoomId");
            //if the record was found
            if (DB.Count == 1)
            {
                
               
                //get the house no
                mHotelId = Convert.ToString(DB.DataTable.Rows[0]["HotelId"]);
                //get the street
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                //get the town
                mRoomFloor = Convert.ToInt32(DB.DataTable.Rows[0]["RoomFloor"]);
                //get the post code
                mRoomNumber = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNumber"]);
                //get the county code
                mRoomTypeId = Convert.ToString(DB.DataTable.Rows[0]["RoomTypeId"]);
                //get the date added
               
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
