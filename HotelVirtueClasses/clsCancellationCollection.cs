using System;
using System.Collections.Generic;

namespace HotelVirtueClasses
{
    public class clsCancellationCollection
    {
        public List<clsCancellation> CancellationList
        {
            get { return mCancellationList; }
            set { mCancellationList = value; }
        }

        private List<clsCancellation> mCancellationList = new List<clsCancellation>();
        public clsCancellation thisCancellation;

        public clsCancellationCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCancellation_SelectAll");
            Int32 RecordCount = DB.Count;
            Int32 Index = 0;
            while (Index < RecordCount)
            {
                clsCancellation ACancellation = new clsCancellation();
                ACancellation.Reason = DB.DataTable.Rows[Index]["Reason"].ToString();
                ACancellation.CancellationId = Convert.ToInt32(DB.DataTable.Rows[Index]["CancellationId"]);
                mCancellationList.Add(ACancellation);
                Index++;
            }

        }

        public int Count
        {
            get
            {
                return mCancellationList.Count;
            }
            set
            {
                //
            }
        }

       
    }
}
