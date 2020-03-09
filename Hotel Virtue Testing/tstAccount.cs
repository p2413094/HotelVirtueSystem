﻿using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstAccount
    {
        [TestMethod]
        public void TestMethod1()
        {
            //created an instance of customer class
            clsAccount AAccount = new clsAccount();
            //test to see if t exists
            Assert.IsNotNull(AAccount);
        }

        [TestMethod]
        public void AccountIdPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            Int32 TestData = 1;
            //assign the data to the property 
            AAccount.AccountId = TestData;
            //test to see two values are the same
            Assert.AreEqual(AAccount.AccountId, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            Int32 TestData = 1;
            //assign the data to the property 
            AAccount.CustomerId = TestData;
            //test to see two values are the same
            Assert.AreEqual(AAccount.CustomerId, TestData);
        }

        [TestMethod]
        public void CityPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            string TestData = "Leicestershire";
            //assign the data to the property 
            AAccount.City = TestData;
            //test to see two values are the same
            Assert.AreEqual(AAccount.City, TestData);
        }

        [TestMethod]
        public void HouseNumberPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            string TestData = "2 hopkins haven";
            //assign the data to the property
            AAccount.HouseNumber = TestData;
            //test to see two values are the same
            Assert.AreEqual(AAccount.HouseNumber, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            string TestData = "Geraldssff3";
            //assign the data to the property
            AAccount.Password = TestData;
            //test to see two values are the same
            Assert.AreEqual(AAccount.Password, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            string TestData = "Gerald";
            //assign the data to the property
            AAccount.PostCode = TestData;
            //test to see two values are the same
            Assert.AreEqual(AAccount.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data
            string TestData = "Gerald btown 23";
            //assign the data to the property
            AAccount.Street = TestData;
            //test to see two values are the same
            Assert.AreEqual(AAccount.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data
            string testData = "Leicester";
            //assign the data to the property
            AAccount.Town = testData;
            //test to see two values are the same
            Assert.AreEqual(AAccount.Town, testData);
        }
    }
}
