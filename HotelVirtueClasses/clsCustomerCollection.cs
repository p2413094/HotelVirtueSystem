using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelVirtueClasses
{
    public class clsCustomerCollection
    {
        //private data member for the allCustomers list
        public List<clsCustomer> mAllCustomers = new List<clsCustomer>();
        
        //public property for Count
        public int Count
        {
            get
            {
                //return the count properly of the private list
                return mAllCustomers.Count;
            }
            set
            {
                //later
            }

        }

        //public property for allCustomers
        public List<clsCustomer> AllCustomers
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllCustomers;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllCustomers = value;
            }
        }

        public List<clsCustomer> CustomerList { get; set; }

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
                mAllCustomers.Add(ACustomer);
                //increment the Index
                Index++;
            }

        }

        

    }

    
}

