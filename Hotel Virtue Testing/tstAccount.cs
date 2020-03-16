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
        public void UserNamePropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create test data
            string TestData = "clockerz23";
            //assogn data to property
            AAccount.UserName = TestData;
            //test to see two values
            Assert.AreEqual(AAccount.UserName, TestData);
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
        public void HouseNoPropertyOk()
        {
            //create an instance of the class
            clsAccount AAccount = new clsAccount();
            //create some test data 
            string TestData = "2 hopkins haven";
            //assign the data to the property
            AAccount.HouseNo = TestData;
            //test to see two values are the same
            Assert.AreEqual(AAccount.HouseNo, TestData);
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


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class nwe want to create
            clsAccountCollection AllAccounts = new clsAccountCollection();
            //create the item of test data
            clsAccount TestItem = new clsAccount();
            //var to store the primary key
            Int32 PrimaryKey = 0;
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
            //set ThisAccount to the testData
            AllAccounts.ThisAccount = TestItem;
            //add the record 
            PrimaryKey = AllAccounts.Add();
            //set the primary key of the test data 
            TestItem.AccountId = PrimaryKey;
            //finf the record
            AllAccounts.ThisAccount.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAccounts.ThisAccount, TestItem);
        }
    }
}
