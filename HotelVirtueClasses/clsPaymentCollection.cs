using System.Collections.Generic;
using System;

namespace HotelVirtueClasses
{
    public class clsPaymentCollection
    {
        List<clsPayment> mPaymentList = new List<clsPayment>();
        clsPayment mThisPayment = new clsPayment();

        public List<clsPayment> PaymentList
        {
            get { return mPaymentList; }
            set { mPaymentList = value; }
        }
        public int Count
        {
            get { return mPaymentList.Count; }
            set { }
        }
        public clsPayment ThisPayment
        {
            get { return mThisPayment; }
            set { mThisPayment = value; }
        }

        public clsPaymentCollection()
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblPayment_SelectAll");
            recordCount = DB.Count;
            while (index < recordCount)
            {
                clsPayment aPayment = new clsPayment();
                aPayment.Amount = Convert.ToDecimal(DB.DataTable.Rows[index]["Amount"]);
                aPayment.BookingLineId = Convert.ToInt32(DB.DataTable.Rows[index]["BookingLineId"]);
                aPayment.CardNumber = Convert.ToString(DB.DataTable.Rows[index]["CardNumber"]);
                aPayment.CardType = Convert.ToString(DB.DataTable.Rows[index]["CardType"]);
                aPayment.CustomerId = Convert.ToInt32(DB.DataTable.Rows[index]["CustomerId"]);
                aPayment.DateTimeOfPayment = Convert.ToDateTime(DB.DataTable.Rows[index]["DateTimeOfPayment"]);
                aPayment.ExpiryDate = Convert.ToString(DB.DataTable.Rows[index]["ExpiryDate"]);
                aPayment.NameOnCard = Convert.ToString(DB.DataTable.Rows[index]["NameOnCard"]);
                aPayment.PaymentId = Convert.ToInt32(DB.DataTable.Rows[index]["PaymentId"]);
                aPayment.SecurityCode = Convert.ToString(DB.DataTable.Rows[index]["SecurityCode"]);
                mPaymentList.Add(aPayment);
                index++;
            }
        }

        public int Add()
        {
            mThisPayment.PaymentId = 123;
            return ThisPayment.PaymentId;
        }
    }
}