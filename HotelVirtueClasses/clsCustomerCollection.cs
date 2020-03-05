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
            clsCustomer ACustomer = new clsCustomer();
            //set the customer to 1
            ACustomer.CustomerId = 1;
            //add trhe customer to the private list of customers
            mAllCustomers.Add(ACustomer);
            //re initialise the ACustomer object to accept new line
            ACustomer = new clsCustomer();
            //set the customer to 1
            ACustomer.CustomerId = 2;
            //Add the second customer private list of customers
            mAllCustomers.Add(ACustomer);
            //add the second customer to the private list 
            mAllCustomers.Add(ACustomer);
            //private list now contains two new customers
        }

    }

    
}

