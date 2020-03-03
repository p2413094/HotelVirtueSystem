using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstAccountCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsAccountCollection AllAccounts = new clsAccountCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllAccounts);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class
            clsAccountCollection AllAccounts = new clsAccountCollection();
            //create some test data 
            Int32 SomeCount = 1;
            //assign the data to the property 
            AllAccounts.Count = SomeCount;
            //test to see two values are the same
            Assert.AreEqual(AllAccounts.Count, SomeCount);
        }

        [TestMethod]
        public void AllAccountsOk()
        {
            //create an instance of the class we want to create
            clsAccountCollection Accounts = new clsAccountCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsAccount> TestList = new List<clsAccount>();
            //add an item to the list 
            //create the item of test data
            clsAccount TestItem = new clsAccount();
            //set its properties 
            TestItem.AccountId = 1;
            TestItem.CustomerId = 1;
            TestItem.City = "Gerald";
            TestItem.HouseNumber = "Johnson street 3";
            TestItem.Password = "csgjhgvcjhgs";
            TestItem.PostCode = "LE3 56D";
            TestItem.Street = "Johnson street 3";
            TestItem.Town = "Manchester";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Accounts.AllAccounts = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Accounts.AllAccounts, TestList);
        }
    }
}
