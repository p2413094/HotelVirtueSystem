using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelVirtueClasses
{
    public class clsRoomTypeCollection
    {
        List<clsRoomType> mAllRoomTypesList = new List<clsRoomType>();
        clsRoomType mThisRoomType = new clsRoomType();


        public clsRoomTypeCollection()
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblRoomType_SelectAll");
            recordCount = DB.Count;

            while (index < recordCount)
            {
                clsRoomType aRoomType = new clsRoomType();
                aRoomType.RoomTypeId = Convert.ToInt32(DB.DataTable.Rows[index]["RoomTypeId"]);
                aRoomType.SingleBed = Convert.ToInt32(DB.DataTable.Rows[index]["SingleBed"]);
                aRoomType.DoubleBed = Convert.ToInt32(DB.DataTable.Rows[index]["DoubleBed"]);
                aRoomType.Description = Convert.ToString(DB.DataTable.Rows[index]["Description"]);
                aRoomType.MaximumOccupancy = Convert.ToInt32(DB.DataTable.Rows[index]["MaximumOccupancy"]);

                mAllRoomTypesList.Add(aRoomType);
                index++;
            }


        }


        public List<clsRoomType> AllRoomTypesList
        {
            get { return mAllRoomTypesList; }
            set { mAllRoomTypesList = value; }
        }

        public int Count
        {
            get { return mAllRoomTypesList.Count; }
            set { }

        }

        public clsRoomType ThisRoomType
        {
            get { return mThisRoomType; }
            set { mThisRoomType = value; }
        }

        public clsRoomType thisRoomType { get; set; }
        public List<clsRoomType> RoomTypeList { get; set; }

        public int AddRoomType()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("RoomTypeId", mThisRoomType.RoomTypeId);
            DB.AddParameter("SingleBed", mThisRoomType.SingleBed);
            DB.AddParameter("DoubleBed", mThisRoomType.DoubleBed);
            DB.AddParameter("Description", mThisRoomType.Description);
            DB.AddParameter("MaximumOccupancy", mThisRoomType.MaximumOccupancy);
            return DB.Execute("sproc_tblRoomType_Insert");
        }
        public void DeleteRoomType()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@RoomTypeId", mThisRoomType.RoomTypeId);
            DB.Execute("sproc_tblRoomType_Delete");
        }



    }
}
