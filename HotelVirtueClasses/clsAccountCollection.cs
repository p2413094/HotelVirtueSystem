﻿using System;
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
            //var for the index 
            Int32 Index = 0;
            //var to store the rcord count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblAccount_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsAccount AAccount = new clsAccount();
                //read in fields from the current record
                AAccount.AccountId = Convert.ToInt32(DB.DataTable.Rows[Index]["AccountId"]);
                AAccount.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AAccount.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                AAccount.HouseNumber = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AAccount.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AAccount.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AAccount.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                AAccount.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //add the customer to the private data member
                mAllAccounts.Add(AAccount);
                //increment the Index
                Index++;
            }
        }


    }
}