﻿using System;
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
            Int32 SomeCount = 2;
            //assign the data to the property 
            AllAccounts.Count = SomeCount;
            //test to see two values are the same
            Assert.AreNotEqual(AllAccounts.Count, SomeCount);
        }

  

        [TestMethod]
        public void AccountsListOK()
        {
            //create an instance of the class we want to create
            clsAccountCollection AllAccounts = new clsAccountCollection();
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
            TestItem.HouseNo = "Johnson street 3";
            TestItem.Password = "csgjhgvcjhgs";
            TestItem.PostCode = "LE3 56D";
            TestItem.Street = "Johnson street 3";
            TestItem.Town = "Manchester";
            TestItem.UserName = "clockerz23";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAccounts.AccountList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAccounts.AccountList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class nwe want to create
            clsAccountCollection AllAccounts = new clsAccountCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsAccount> TestList = new List<clsAccount>();
            //add an item to the list
            //create the item of test data
            clsAccount TestItem = new clsAccount();
            //set its properties
            TestItem.AccountId = 1;
            TestItem.CustomerId = 1;
            TestItem.City = "London";
            TestItem.Town = "Newham	";
            TestItem.PostCode = "LON 32S";
            TestItem.Street = "Hopkins st";
            TestItem.HouseNo = "Order house 33";
            TestItem.Password = "ghghsghdag3";
            TestItem.UserName = "clockerz23";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAccounts.AccountList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAccounts.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisAccountPropertyOk()
        {
            //create an instance of the class we want to create
            clsAccountCollection AllAccounts = new clsAccountCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            clsAccount TestAccount = new clsAccount();
            //set its properties 
            TestAccount.AccountId = 1;
            TestAccount.CustomerId = 1;
            TestAccount.City = "Gerald";
            TestAccount.HouseNo = "Johnson street 3";
            TestAccount.Password = "csgjhgvcjhgs";
            TestAccount.PostCode = "LE3 56D";
            TestAccount.Street = "Johnson street 3";
            TestAccount.Town = "Manchester";
            TestAccount.UserName = "clockerz23";
            //assign the data to the property
            AllAccounts.ThisAccount = TestAccount;
            //test to see that the two values are the same
            Assert.AreEqual(AllAccounts.ThisAccount, TestAccount);
        }
    }
}
