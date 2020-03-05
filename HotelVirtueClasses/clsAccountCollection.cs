using System.Collections.Generic;

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
        clsAccount AAccount = new clsAccount();
        //set the customer to 1
        AAccount.AccountId = 1;
        //add trhe customer to the private list of customers
        mAllAccounts.Add(AAccount);
        //re initialise the ACustomer object to accept new line
        AAccount = new clsAccount();
        //set the customer to 1
        AAccount.AccountId = 2;
        //Add the second customer private list of customers
        mAllAccounts.Add(AAccount);
        //add the second customer to the private list 
        mAllAccounts.Add(AAccount);
        //private list now contains two new customers
    }

}