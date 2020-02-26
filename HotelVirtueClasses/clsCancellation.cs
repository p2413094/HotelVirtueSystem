using System;
using System.Collections.Generic;

namespace HotelVirtueClasses
{
    public class clsCancellation
    {
        private Int32 mCancellationId;
        private Int32 mBookingLineId;
        private DateTime mDateTimeOfCancellation;
        private string mReason;

        public int CancellationId
        {
            get { return mCancellationId; }
            set { mCancellationId = value; }
        }

        public int BookingLineId
        {
            get { return mBookingLineId; }
            set { mBookingLineId = value; }
        }

        public DateTime DateTimeOfCancellation
        {
            get { return mDateTimeOfCancellation; }
            set { mDateTimeOfCancellation = value; }
        }

        public string Reason
        {
            get { return mReason; }
            set { mReason = value; }
        }

        public List<string> ErrorList = new List<string>();

        public string Valid(string reason)
        {
            string Error = "";
            if (reason.Length > 50)
            {
                Error = "Cancellation reason must not be longer than 50 characters";
                ErrorList.Add(Error);
            }
            if (reason.Length == 0)
            {
                Error = "Cancellation reason must not be blank";
                ErrorList.Add(Error);
            }
            return Error;
        }

        public bool Find(int cancellationId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CancellationId", cancellationId);
            DB.Execute("sproc_tblCancellation_FilterByCancellationId");
            if (DB.Count == 1)
            {
                mCancellationId = Convert.ToInt32(DB.DataTable.Rows[0]["CancellationId"]);
                mBookingLineId = Convert.ToInt32(DB.DataTable.Rows[0]["BookingLineId"]);
                mDateTimeOfCancellation = Convert.ToDateTime(DB.DataTable.Rows[0]["DateTimeOfCancellation"]);
                mReason = Convert.ToString(DB.DataTable.Rows[0]["Reason"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}