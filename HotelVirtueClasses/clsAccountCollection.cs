using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HotelVirtueClasses
{

    public class clsAccountCollection
    {
        //private data member for the allCustomers list
        public List<clsAccount> mAllAccounts = new List<clsAccount>();

        //public property for Count
        public int Count
        {
            get
            {
                //return the count properly of the private list
                return mAllAccounts.Count;
            }
            set
            {
                //later
            }

        }

        //public property for allCustomers
        public List<clsAccount> AllAccounts
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllAccounts;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllAccounts = value;
            }
        }

        public clsAccountCollection()
        {
            //create an instance of the customer class to store a customer
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblAccount_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount) ;
            {
                //create a new instance of the customer class
                clsAccount AAccount = new clsAccount();
                //get the customer name
                AAccount.City = DB.DataTable.Rows[Index]["City"].ToString();
                //get the primary key
                AAccount.AccountId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                //add the customer to the private data member
                mAllAccounts.Add(AAccount);
                //increment the Index
                Index++;
            }
        }

    }
}