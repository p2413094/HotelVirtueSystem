using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HotelVirtueClasses
{

    public class clsAccountCollection
    {
        //private data member for the allCustomers list
         List<clsAccount> mAccountList = new List<clsAccount>();
        //private data member thismAccount
        clsAccount mThisAccount = new clsAccount();



        //public property for ThisAccount
        public clsAccount ThisAccount
        {
            get
            {
                return mThisAccount;
            }
            set
            {
                mThisAccount = value;
            }
        }


            //public property for Count
        public int Count
        {
            get
            {
                //return the count properly of the private list
                return mAccountList.Count;
            }
            set
            {
                //later
            }

        }

        //public property for allCustomers
        public List<clsAccount> AccountList
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAccountList;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAccountList = value;
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
                AAccount.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AAccount.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AAccount.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AAccount.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                AAccount.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //add the customer to the private data member
                mAccountList.Add(AAccount);
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
            DB.AddParameter("@AccountId", mThisAccount.AccountId);
            DB.AddParameter("@CustomerId", mThisAccount.CustomerId);
            DB.AddParameter("@City", mThisAccount.City);
            DB.AddParameter("@HouseNo", mThisAccount.HouseNo);
            DB.AddParameter("@PostCode", mThisAccount.PostCode);
            DB.AddParameter("@Street", mThisAccount.Street);
            DB.AddParameter("@Town", mThisAccount.Town);
            DB.AddParameter("@Password", mThisAccount.Password);
            DB.AddParameter("@UserName", mThisAccount.UserName);
            //return the primary key of the new record
            return DB.Execute("sproc_tblAccount_Insert");
        }

        public void Delete()
        {
            //deletes record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@AccountId", mThisAccount.AccountId);
            //execute 
            DB.Execute("sproc_tblAccount_Delete");
        }
    }
}