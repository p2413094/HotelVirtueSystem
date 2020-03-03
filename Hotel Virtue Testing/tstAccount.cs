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
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            Int32 SomeAccountId = 1;
            //assign the data to the property 
            AAccount.AccountId = SomeAccountId;
            //test to see two values are the same
            Assert.AreEqual(AAccount.AccountId, SomeAccountId);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            Int32 SomeCustomerId = 1;
            //assign the data to the property 
            AAccount.CustomerId = SomeCustomerId;
            //test to see two values are the same
            Assert.AreEqual(AAccount.CustomerId, SomeCustomerId);
        }

        [TestMethod]
        public void CityPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            string SomeCity = "Leicestershire";
            //assign the data to the property 
            AAccount.City = SomeCity;
            //test to see two values are the same
            Assert.AreEqual(AAccount.City, SomeCity);
        }

        [TestMethod]
        public void HouseNumberPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            string SomeHouseNumber = "2 hopkins haven";
            //assign the data to the property
            AAccount.HouseNumber = SomeHouseNumber;
            //test to see two values are the same
            Assert.AreEqual(AAccount.HouseNumber, SomeHouseNumber);
        }

        [TestMethod]
        public void PasswordPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            string SomePassword = "Geraldssff3";
            //assign the data to the property
            AAccount.Password = SomePassword;
            //test to see two values are the same
            Assert.AreEqual(AAccount.Password, SomePassword);
        }

        [TestMethod]
        public void PostCodePropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            string SomePostCode = "Gerald";
            //assign the data to the property
            AAccount.PostCode = SomePostCode;
            //test to see two values are the same
            Assert.AreEqual(AAccount.PostCode, SomePostCode);
        }

        [TestMethod]
        public void StreetPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data
            string SomeStreet = "Gerald btown 23";
            //assign the data to the property
            AAccount.Street = SomeStreet;
            //test to see two values are the same
            Assert.AreEqual(AAccount.Street, SomeStreet);
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
