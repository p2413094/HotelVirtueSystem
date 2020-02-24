using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            //created an instance of customer class
            clsCustomer ACustomer = new clsCustomer();
            //test to see if t exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 testData = 1;
            ACustomer.CustomerId = testData;
            Assert.AreEqual(ACustomer.CustomerId, testData);
        }

        [TestMethod]
        public void ContactNumberPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 testData = 1;
            ACustomer.ContactNumber = testData;
            Assert.AreEqual(ACustomer.ContactNumber, testData);
        }

        [TestMethod]
        public void FirstNamePropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "Gerald";
            ACustomer.FirstName = testData;
            Assert.AreEqual(ACustomer.FirstName, testData);
        }

        [TestMethod]
        public void LastNamePropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "Johnson";
            ACustomer.LastName = testData;
            Assert.AreEqual(ACustomer.LastName, testData);
        }

        [TestMethod]
        public void EmailAddressPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "Gerald";
            ACustomer.EmailAddress = testData;
            Assert.AreEqual(ACustomer.EmailAddress, testData);
        }


        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the customer class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            Int32 Error = 1;
            //create some test data to test method
            Int32 SomeCustomerId = 1;
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerId);
            //test to see that the result is OK
            Assert.AreEqual(Error, 1);
        }


    }
}
