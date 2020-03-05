using System;
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
        public void TwoCustomersPresent()
        {
            //create an instance of the class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreNotEqual(Customers.Count, 2);
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
            Customers.AllCustomers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Customers.AllCustomers, TestList);
        }

       
    }
}
