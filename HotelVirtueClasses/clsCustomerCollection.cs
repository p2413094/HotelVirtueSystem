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

        public clsCustomerCollection()
        {
            //create an instance of the customer class to store a customer
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount) ;
            {
                //create a new instance of the customer class
                clsCustomer ACustomer = new clsCustomer();
                //get the customer name
                ACustomer.FirstName = DB.DataTable.Rows[Index]["FirstName"].ToString();
                //get the primary key
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                //add the customer to the private data member
                mAllCustomers.Add(ACustomer);
                //increment the Index
                Index++;
            }

        }

    }

    
}

