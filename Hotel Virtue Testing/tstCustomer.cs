using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            clsCustomer aCustomer = new clsCustomer();
            Int32 testData = 1;
            aCustomer.CustomerId = testData;
            Assert.AreEqual(aCustomer.CustomerId, testData);
        }
    }
}