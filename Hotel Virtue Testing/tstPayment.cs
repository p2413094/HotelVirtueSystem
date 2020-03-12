using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsPayment aPayment = new clsPayment();
            Assert.IsNotNull(aPayment);
        }

        [TestMethod]
        public void PaymentIdPropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            Int32 testData = 1;
            aPayment.PaymentId = testData;
            Assert.AreEqual(aPayment.PaymentId, testData);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            Int32 testData = 1;
            aPayment.CustomerId = testData;
            Assert.AreEqual(aPayment.CustomerId, testData);
        }

        [TestMethod]
        public void BookingLineIdPropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            Int32 testData = 1;
            aPayment.BookingLineId = testData;
            Assert.AreEqual(aPayment.BookingLineId, testData);
        }

        [TestMethod]
        public void DateTimeOfPaymentPropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            DateTime testData = DateTime.Now;
            aPayment.DateTimeOfPayment = testData;
            Assert.AreEqual(aPayment.DateTimeOfPayment, testData);
        }

        [TestMethod]
        public void AmountPropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            decimal testData = 79.99m;
            aPayment.Amount = testData;
            Assert.AreEqual(aPayment.Amount, testData);
        }

        [TestMethod]
        public void CardNumberPropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            string testData = "1234123412341234";
            aPayment.CardNumber = testData;
            Assert.AreEqual(aPayment.CardNumber, testData);
        }

        [TestMethod]
        public void NameOnCardPropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            string testData = "MR JOHN SMITH";
            aPayment.NameOnCard = testData;
            Assert.AreEqual(aPayment.NameOnCard, testData);
        }

        [TestMethod]
        public void ExpiryDatePropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            string testData = "09/23";
            aPayment.ExpiryDate = testData;
            Assert.AreEqual(aPayment.ExpiryDate, testData);
        }

        [TestMethod]
        public void SecurityCodePropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            string testData = "123";
            aPayment.SecurityCode = testData;
            Assert.AreEqual(aPayment.SecurityCode, testData);
        }

        [TestMethod]
        public void CardTypePropertyOk()
        {
            clsPayment aPayment = new clsPayment();
            string testData = "VISA";
            aPayment.CardType = testData;
            Assert.AreEqual(aPayment.CardType, testData);
        }


        [TestMethod]
        public void ValidMethodOk()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "MR JOHN SMITH";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void cardNumberMinMinusOne()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "123412341234123";
            string nameOnCard = "MR JOHN SMITH";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void cardNumberMinBoundary()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "MR JOHN SMITH";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void cardNumberMinPlusOne()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "12341234123412341";
            string nameOnCard = "MR JOHN SMITH";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void cardNumberMaxPlusOne()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "12341234123412341";
            string nameOnCard = "MR JOHN SMITH";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void cardNumberMid()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412";
            string nameOnCard = "MR JOHN SMITH";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void cardNumberAllDigits()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "MR JOHN SMITH";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void cardNumberExtremeMax()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "";
            cardNumber = cardNumber.PadRight(500, '1');
            string nameOnCard = "MR JOHN SMITH";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardMinMinusOne()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "M";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardMinBoundary()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "MR";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardMinPlusOne()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "MR ";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardMaxMinusOne()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "";
            nameOnCard = nameOnCard.PadRight(21, 'M');
            aPayment.CardType = "VISA";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardMaxBoundary()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "";
            nameOnCard = nameOnCard.PadRight(21, 'M');
            aPayment.CardType = "VISA";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardMaxPlusOne()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "";
            nameOnCard = nameOnCard.PadRight(23, 'M');
            aPayment.CardType = "VISA";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardMid()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "MR JOHN SMIT";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardExtremeMax()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "";
            nameOnCard = nameOnCard.PadRight(500, 'M');
            aPayment.CardType = "VISA";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardVisaTypeMaxPlusOne()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "";
            nameOnCard = nameOnCard.PadRight(22, 'A');
            aPayment.CardType = "VISA";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameOnCardMasterCardTypeMaxPlusOne()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "";
            nameOnCard = nameOnCard.PadRight(22, 'A');
            aPayment.CardType = "VISA";
            string expiryDate = "09/23";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void testFunction()
        {
            clsPayment aPayment = new clsPayment();
            string error = "";
            string cardNumber = "1234123412341234";
            string nameOnCard = "MR ";
            string expiryDate = "09/21";
            string securityCode = "123";
            error = aPayment.Valid(cardNumber, nameOnCard, expiryDate, securityCode);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void testPaymentIdFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.PaymentId != 3)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testCustomerIdFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.CustomerId != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testBookingLineIdFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.BookingLineId != 3)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testDateTimeOfPaymentFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.DateTimeOfPayment != Convert.ToDateTime("2020-02-16 17:09:09.1500000"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
            
        }

        [TestMethod]
        public void testCardNumberFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.CardNumber != "1234123412341234")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testNameOnCardFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.NameOnCard != "MR JOHN SMITH")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testExpiryDateFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.ExpiryDate != "02/21")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testSecurityCodeFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.SecurityCode != "000")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testCardTypeFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.CardType != "VISA")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testAmountFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean found = false;
            Boolean ok = true;
            Int32 PaymentId = 3;
            found = aPayment.Find(PaymentId);
            if (aPayment.Amount != 80)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        
    }
}
