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
            Int32 SomeCustomerId = 1;
            //assign the data to the property 
            ACustomer.CustomerId = SomeCustomerId;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.CustomerId, SomeCustomerId);
        }

        [TestMethod]
        public void ContactNumberPropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Int32 SomeContactNumber = 1;
            //assign the data to the property
            ACustomer.ContactNumber = SomeContactNumber;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.ContactNumber, SomeContactNumber);
        }

        [TestMethod]
        public void FirstNamePropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string SomeFirstName = "Gerald";
            //assign the data to the property
            ACustomer.FirstName = SomeFirstName;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void LastNamePropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string SomeLastName = "Johnson";
            //assign the data to the property
            ACustomer.LastName = SomeLastName;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.LastName, SomeLastName);
        }

        [TestMethod]
        public void EmailAddressPropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string SomeEmailAddress = "Gerald";
            //assign the data to the property
            ACustomer.EmailAddress = SomeEmailAddress;
            //test to see two values are the same
            Assert.AreEqual(ACustomer.EmailAddress, SomeEmailAddress);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 0;
            //create some test data to test method
            Int32 SomeCustomerId = 1;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
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
            Int32 SomeCustomerId = 0;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
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
            Int32 SomeCustomerId = 1;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
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
            Int32 SomeCustomerId = 2;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
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
            Int32 SomeCustomerId = 99;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
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
            Int32 SomeCustomerId = 100;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
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
            Int32 SomeCustomerId = 101;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
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
            Int32 SomeCustomerId = 50;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
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
            Int32 SomeCustomerId = 1000000;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
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
            Int64 SomeContactNumber = 12345678910;
            //invoke the method
            Error = ACustomer.Valid(SomeContactNumber);
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
            Int64 SomeContactNumber = 123456789;
            //invoke the method
            Error = ACustomer.Valid(SomeContactNumber);
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
            Int64 SomeContactNumber = 12345678910;
            //invoke the method       
            Error = ACustomer.Valid(SomeContactNumber);
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
            Int64 SomeContactNumber = 12345678101;
            //invoke the method
            Error = ACustomer.Valid(SomeContactNumber);
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
            Int64 SomeContactNumber = 123456789101;
            //invoke the method
            Error = ACustomer.Valid(SomeContactNumber);
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
            Int64 SomeContactNumber = 12345678910;
            //invoke the method
            Error = ACustomer.Valid(SomeContactNumber);
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
            Int64 SomeContactNumber = 123456789101;
            //invoke the method
            Error = ACustomer.Valid(SomeContactNumber);
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
            Int64 SomeContactNumber = 123456;
            //invoke the method
            Error = ACustomer.Valid(SomeContactNumber);
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
            Int64 SomeContactNumber = 1234567892341;
            //invoke the method
            Error = ACustomer.Valid(SomeContactNumber);
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
            String SomeFirstName = "Gerald";
            //invoke the method
            Error = ACustomer.Valid(SomeFirstName);
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
            String SomeFirstName = "";
            //invoke the method
            Error = ACustomer.Valid(SomeFirstName);
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
            String SomeFirstName = "a";
            //invoke the method
            Error = ACustomer.Valid(SomeFirstName);
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
            String SomeFirstName = "aa";
            //invoke the method
            Error = ACustomer.Valid(SomeFirstName);
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
            String SomeFirstName = "aaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeFirstName);
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
            String SomeFirstName = "aaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeFirstName);
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
            String SomeFirstName = "aaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeFirstName);
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
            String SomeFirstName = "aaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeFirstName);
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
            String SomeFirstName = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeFirstName);
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
            String SomeLastName = "Gerald";
            //invoke the method
            Error = ACustomer.Valid(SomeLastName);
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
            String SomeLastName = "";
            //invoke the method
            Error = ACustomer.Valid(SomeLastName);
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
            String SomeLastName = "a";
            //invoke the method
            Error = ACustomer.Valid(SomeLastName);
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
            String SomeLastName = "aa";
            //invoke the method
            Error = ACustomer.Valid(SomeLastName);
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
            String SomeLastName = "aaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeLastName);
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
            String SomeLastName = "aaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeLastName);
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
            String SomeLastName = "aaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeLastName);
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
            String SomeLastName = "aaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeLastName);
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
            String SomeLastName = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeLastName);
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
            String SomeEmailAddress = "Gerald";
            //invoke the method
            Error = ACustomer.Valid(SomeEmailAddress);
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
            String SomeEmailAddress = "";
            //invoke the method
            Error = ACustomer.Valid(SomeEmailAddress);
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
            String SomeEmailAddress = "a";
            //invoke the method
            Error = ACustomer.Valid(SomeEmailAddress);
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
            String SomeEmailAddress = "aa";
            //invoke the method
            Error = ACustomer.Valid(SomeEmailAddress);
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
            String SomeEmailAddress = "aaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeEmailAddress);
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
            String SomeEmailAddress = "aaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeEmailAddress);
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
            String SomeEmailAddress = "aaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeEmailAddress);
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
            String SomeEmailAddress = "aaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeEmailAddress);
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
            String SomeEmailAddress = "aaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeEmailAddress);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

    }
}
