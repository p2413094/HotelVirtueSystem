using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //created an instance of customer class
            clsCustomer ACustomer = new clsCustomer();
            //test to see if t exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data 
            Int32 TestData = 1;
            //assign the data to the property 
            ACustomer.CustomerId = TestData;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void ContactNumberPropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.ContactNumber = TestData;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.ContactNumber, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "Gerald";
            //assign the data to the property
            ACustomer.FirstName = TestData;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "Johnson";
            //assign the data to the property
            ACustomer.LastName = TestData;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "Gerald";
            //assign the data to the property
            ACustomer.EmailAddress = TestData;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 1;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 0;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMinBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 1;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 2;
            //create some test data to test method
            Int32 TestData = 2;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 99;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMaxBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 100;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 101;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }


        [TestMethod]
        public void CustomerIdMid()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 50;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 TestData = 1000000;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void SecondValidMethodOk()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int64 Error = 1234567891;
            //create some test data to test method
            Int64 TestData = 12345678910;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, 1234567891);
        }

        [TestMethod]
        public void ContactNumberMinLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int64 Error = 1234567891;
            //create some test data to test method
            Int64 TestData = 123456789;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, 1234567891);
        }

        [TestMethod]
        public void ContactNumberMinBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int64 Error = 1234567891;
            //create some test data to test method
            Int64 TestData = 12345678910;
            //invoke the method       
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, 1234567891);
        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int64 Error = 1234567891;
            //create some test data to test method
            Int64 TestData = 12345678101;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, 1234567891);
        }

        [TestMethod]
        public void ContactNumberMaxLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int64 Error = 1234567891;
            //create some test data to test method
            Int64 TestData = 123456789101;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void ContactNumberMaxBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int64 Error = 1234567891;
            //create some test data to test method
            Int64 TestData = 12345678910;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, 1234567891);
        }

        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int64 Error = 1234567891;
            //create some test data to test method
            Int64 TestData = 123456789101;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, 1234567891);
        }

        [TestMethod]
        public void ContactNumberMid()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int64 Error = 1234567891;
            //create some test data to test method
            Int64 TestData = 123456;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, 0);
        }

        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int64 Error = 1234567891;
            //create some test data to test method
            Int64 TestData = 1234567892341;
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, 1234567891);
        }


        [TestMethod]
        public void ThirdValidMethodOk()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData  = "Gerald";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData  = "aaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FourthValidMethodOk()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "Gerald";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FifthValidMethodOk()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "Gerald";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "a";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxBoundary()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test method
            String TestData = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(TestData);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class nwe want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            //TestItem.CustomerId = 25;
            TestItem.ContactNumber = 1;
            TestItem.FirstName = "Gerald";
            TestItem.LastName = "Johnson";
            TestItem.EmailAddress = "charlie@gmail.com";
            //set ThisAccount to the testData
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data 
            TestItem.CustomerId = PrimaryKey;
            //finf the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

       

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Boolean Found = false;
            //create some test data to test method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see that the result is OK
            Assert.IsTrue(Found);
        }

    }
}
