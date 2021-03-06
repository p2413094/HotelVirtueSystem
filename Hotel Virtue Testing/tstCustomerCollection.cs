﻿using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data 
            Int32 SomeCount = 2;
            //assign the data to the property 
            AllCustomers.Count = SomeCount;
            //test to see two values are the same
            Assert.AreNotEqual(AllCustomers.Count, SomeCount);
        }



        [TestMethod]
        public void AllCustomersOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection Customers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.CustomerId = 1;
            TestItem.ContactNumber = 1;
            TestItem.FirstName = "Gerald";
            TestItem.LastName = "Johnson";
            TestItem.EmailAddress = "charlie@gmail.com";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Customers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Customers.CustomerList, TestList);
        }

       [TestMethod]
       public void ListAndCountOK()
        {
            //create an instance of the class nwe want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "smith";
            TestItem.EmailAddress = "jordan@gmail.com";
            TestItem.ContactNumber = 435365465;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties 
            TestCustomer.CustomerId = 1;
            TestCustomer.FirstName = "John";
            TestCustomer.LastName = "smith";
            TestCustomer.EmailAddress = "jordan@gmail.com";
            TestCustomer.ContactNumber = 435365465;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
    }
}
