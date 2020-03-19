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
        public void UpdateMethodOK()
        {
            //create an instance of the class nwe want to create
            clsAccountCollection AllAccounts = new clsAccountCollection();
            //create the item of test data
            clsAccount TestItem = new clsAccount();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountId = 25;
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
            //modify the test data 
            TestItem.AccountId = 11;
            TestItem.CustomerId = 1;
            TestItem.City = "Londn";
            TestItem.Town = "Newha	";
            TestItem.PostCode = "LOw 32S";
            TestItem.Street = "Hopkins t";
            TestItem.HouseNo = "Order hoe 33";
            TestItem.Password = "ghghsgh3";
            TestItem.UserName = "clockz23";
            //set record
            AllAccounts.ThisAccount = TestItem;
            //update record
            AllAccounts.Update();
            //finf the record
            AllAccounts.ThisAccount.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAccounts.ThisAccount, TestItem);
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
            TestItem.AccountId = 7;
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

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class nwe want to create
            clsAccountCollection AllAccounts = new clsAccountCollection();
            //create the item of test data
            clsAccount TestItem = new clsAccount();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountId = 19;
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
            Boolean Found = AllAccounts.ThisAccount.Find(PrimaryKey);
            //test to see that he recod is not found
            Assert.AreEqual(AllAccounts.ThisAccount, TestItem);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 1;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }


        [TestMethod]
        public void AccountIdMinLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 0;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void AccountIdMinBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 1;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void AccountIdMinPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 2;
            //create some test data to test method
            Int32 TestData = 2;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void AccountIdMaxLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 99;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void AccountIdMaxBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 100;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void AccountIdMaxPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 101;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }


        [TestMethod]
        public void AccountIdMid()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 50;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void AccountIdExtremeMax()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 1000000;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }


        [TestMethod]
        public void SecondValidMethodOk()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "Gerald";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMinLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMinBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMinPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMaxLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMaxBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMid()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameExtremeMax()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ThirdValidMethodOk()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "Gerald";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMinBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMid()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityExtremeMax()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FourthValidMethodOk()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "Gerald";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMinLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMinBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FifthValidMethodOk()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "Gerald";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SixthValidMethodOk()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "Gerald";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SeventhValidMethodOk()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "Gerald";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetExtremeMax()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EigthValidMethodOk()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "Gerald";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMinBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownExtremeMax()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NinthValidMethodOk()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 1;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }


        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 0;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMinBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 1;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 2;
            //create some test data to test method
            Int32 TestData = 2;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 99;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMaxBoundary()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 100;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 101;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }


        [TestMethod]
        public void CustomerIdMid()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 50;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 1000000;
            //invoke the method
            Error = AAccount.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the customer class
            clsAccount AAccount = new clsAccount();
            //create a string variable to store the result of the validation
            Boolean Found = false;
            //create some test data to test method
            Int32 AccountId = 1;
            //invoke the method
            Found = AAccount.Find(AccountId);
            //test to see that the result is OK
            Assert.IsTrue(Found);
        }

    }



}
