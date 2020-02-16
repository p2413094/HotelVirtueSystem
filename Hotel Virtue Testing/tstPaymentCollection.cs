using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HotelVirtueClasses;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsPaymentColection AllPayments = new clsPaymentColection();
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOk()
        {
            clsPaymentColection AllPayments = new clsPaymentColection();
            List<clsPayment> testList = new List<clsPayment>();
            clsPayment testItem = new clsPayment();
            testItem.Amount = 79.99m;
            testItem.BookingLineId = 1;
            testItem.CardNumber = "1234123412341234";
            testItem.CardType = "VISA";
            testItem.CustomerId = 1;
            testItem.DateTimeOfPayment = DateTime.Now;
            testItem.ExpiryDate = "07/21";
            testItem.NameOnCard = "MR JOHN SMITH";
            testItem.SecurityCode = "733";
            testList.Add(testItem);
            AllPayments.PaymentList = testList;
            Assert.AreEqual(AllPayments.PaymentList, testList);
        }   

        [TestMethod]
        public void ThisPaymentOk()
        {
            clsPaymentColection AllPayments = new clsPaymentColection();
            clsPayment testPayment = new clsPayment();
            testPayment.Amount = 79.99m;
            testPayment.BookingLineId = 1;
            testPayment.CardNumber = "1234123412341234";
            testPayment.CardType = "VISA";
            testPayment.CustomerId = 1;
            testPayment.DateTimeOfPayment = DateTime.Now;
            testPayment.ExpiryDate = "07/21";
            testPayment.NameOnCard = "MR JOHN SMITH";
            testPayment.SecurityCode = "733";
            AllPayments.ThisPayment = testPayment;
            Assert.AreEqual(AllPayments.ThisPayment, testPayment);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsPaymentColection AllPayments = new clsPaymentColection();
            List<clsPayment> testList = new List<clsPayment>();
            clsPayment testItem = new clsPayment();
            testItem.Amount = 79.99m;
            testItem.BookingLineId = 1;
            testItem.CardNumber = "1234123412341234";
            testItem.CardType = "VISA";
            testItem.CustomerId = 1;
            testItem.DateTimeOfPayment = DateTime.Now;
            testItem.ExpiryDate = "07/21";
            testItem.NameOnCard = "MR JOHN SMITH";
            testItem.SecurityCode = "733";
            testList.Add(testItem);
            AllPayments.PaymentList = testList;
            Assert.AreEqual(AllPayments.Count, testList.Count);
        }
    }
}
