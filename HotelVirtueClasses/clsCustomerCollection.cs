using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelVirtueClasses
{
    public class clsCustomerCollection
    {
        //private data member for the allCustomers list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thismAccount
        clsCustomer mThisCustomer = new clsCustomer();


        //public property for ThisAccount
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }


        //public property for Count
        public int Count
        {
            get
            {
                //return the count properly of the private list
                return mCustomerList.Count;
            }
            set
            {
                //later
            }

        }

        //public property for allCustomers
        public List<clsCustomer> CustomerList
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mCustomerList;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mCustomerList = value;
            }
        }

       

        public clsCustomerCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the rcord count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
             RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount) 
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in fields from the current record
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.ContactNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["ContactNumber"]);
                //add the customer to the private data member
                mCustomerList.Add(ACustomer);
                //increment the Index
                Index++;
            }

        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisAddress
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@ContactNumber", mThisCustomer.ContactNumber);
            //return the primary key of the new record
            return DB.Execute("sproc_tblCustomer_Insert");
        }


    }

    
}

