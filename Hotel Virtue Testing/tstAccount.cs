using System;
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
            clsAccount AAccount = new clsAccount();
            Int32 testData = 1;
            AAccount.AccountId = testData;
            Assert.AreEqual(AAccount.AccountId, testData);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            clsAccount AAccount = new clsAccount();
            Int32 testData = 1;
            AAccount.CustomerId = testData;
            Assert.AreEqual(AAccount.CustomerId, testData);
        }

        [TestMethod]
        public void CityPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "Leicestershire";
            ACustomer.City = testData;
            Assert.AreEqual(ACustomer.City, testData);
        }

        [TestMethod]
        public void HouseNumberPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "2 hopkins haven";
            ACustomer.HouseNumber = testData;
            Assert.AreEqual(ACustomer.HouseNumber, testData);
        }

        [TestMethod]
        public void PasswordPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "Geraldssff3";
            ACustomer.Password = testData;
            Assert.AreEqual(ACustomer.Password, testData);
        }

        [TestMethod]
        public void PostCodePropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "Gerald";
            ACustomer.PostCode = testData;
            Assert.AreEqual(ACustomer.PostCode, testData);
        }

        [TestMethod]
        public void StreetPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "Gerald btown 23";
            ACustomer.Street = testData;
            Assert.AreEqual(ACustomer.Street, testData);
        }

        [TestMethod]
        public void TownPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "Leicester";
            ACustomer.Town = testData;
            Assert.AreEqual(ACustomer.Town, testData);
        }
    }
}
