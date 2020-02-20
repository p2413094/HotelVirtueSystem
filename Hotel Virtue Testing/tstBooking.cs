using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstBooking
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsBooking aBooking = new clsBooking();
            Assert.IsNotNull(aBooking);
        }

        [TestMethod]
        public void BookingIdPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.BookingId = testData;
            Assert.AreEqual(aBooking.BookingId, testData);
        }

        [TestMethod]
        public void BookingLineIdPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.BookingLineId = testData;
            Assert.AreEqual(aBooking.BookingLineId, testData);
        }

        [TestMethod]
        public void AdminIdPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.AdminId = testData;
            Assert.AreEqual(aBooking.AdminId, testData);
        }

        [TestMethod]
        public void HotelIdPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.HotelId = testData;
            Assert.AreEqual(aBooking.HotelId, testData);
        }

        [TestMethod]
        public void RoomIdPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.RoomId = testData;
            Assert.AreEqual(aBooking.RoomId, testData);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.CustomerId = testData;
            Assert.AreEqual(aBooking.CustomerId, testData);
        }

        [TestMethod]
        public void ArrivalDatePropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            DateTime testData = DateTime.Now.Date;
            aBooking.ArrivalDate = testData;
            Assert.AreEqual(aBooking.ArrivalDate, testData);
        }

        [TestMethod]
        public void DepartureDatePropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            DateTime testData = DateTime.Now.Date.AddDays(3);
            aBooking.DepartureDate = testData;
            Assert.AreEqual(aBooking.DepartureDate, testData);
        }

        [TestMethod]
        public void DateTimeOfBookingPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            DateTime testData = DateTime.Now;
            aBooking.DateTimeOfBooking = testData;
            Assert.AreEqual(aBooking.DateTimeOfBooking, testData);
        }

        [TestMethod]
        public void UnderFivePropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.UnderFive = testData;
            Assert.AreEqual(aBooking.UnderFive, testData);
        }

        [TestMethod]
        public void FiveToSixteenPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.FiveToSixteen = testData;
            Assert.AreEqual(aBooking.FiveToSixteen, testData);
        }

        [TestMethod]
        public void SixteenUpwardsPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.SixteenUpwards = testData;
            Assert.AreEqual(aBooking.SixteenUpwards, testData);
        }
      
        [TestMethod]
        public void GymAccessPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Boolean testData = true;
            aBooking.GymAccess = testData;
            Assert.AreEqual(aBooking.GymAccess, testData);
        }

        [TestMethod]
        public void LateCheckoutPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Boolean testData = true;
            aBooking.LateCheckout = testData;
            Assert.AreEqual(aBooking.LateCheckout, testData);
        }

        [TestMethod]
        public void OtherPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            string testData = "Champagne on arrival";
            aBooking.Other = testData;
            Assert.AreEqual(aBooking.Other, testData);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateExtremeMin()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(-100);
            DateTime departureDate = DateTime.Now.Date;
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateMinMinusOne()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(-1);
            DateTime departureDate = DateTime.Now.Date;
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateMinBoundary()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateMinPlusOne()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(1);
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateExtremeMax()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(100);
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateExtremeMin()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(-100);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateMinMinusOne()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(-1);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateMinBoundary()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateMinPlusOne()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(2);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateExtremeMax()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(100);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }        

        [TestMethod]
        public void OtherExtremeMin()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OtherMinBoundary()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherMinPlusOne()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "te";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherMaxMinusOne()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "";
            other = other.PadRight(49, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherMaxBoundary()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "";
            other = other.PadRight(50, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherMaxPlusOne()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "";
            other = other.PadRight(51, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OtherMid()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "";
            other = other.PadRight(25, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherExtremeMax()
        {
            clsBooking aBooking = new clsBooking();
            string error = "";
            string other = "";
            other = other.PadRight(250, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            error = aBooking.Valid(arrivalDate, departureDate, other);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void tblBookingTestBookingIdFound()
        {
            clsBooking aBooking = new clsBooking();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingId = 1;
            found = aBooking.Find(bookingId);
            if (aBooking.BookingId != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void tblBookingTestCustomerIdFound()
        {
            clsBooking aBooking = new clsBooking();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingId = 1;
            Int32 customerId = 1;
            found = aBooking.Find(bookingId);
            if (aBooking.CustomerId != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void tblBookingTestHotelIdFound()
        {
            clsBooking aBooking = new clsBooking();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingId = 1;
            Int32 hotelId = 1;
            found = aBooking.Find(bookingId);
            if (aBooking.HotelId != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void tblBookingAdminIdFound()
        {
            clsBooking aBooking = new clsBooking();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingId = 1;
            Int32 adminId = 1;
            found = aBooking.Find(bookingId);
            if (aBooking.AdminId != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void tblBookingDateTimeOfBookingFound()
        {
            clsBooking aBooking = new clsBooking();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingId = 1;
            DateTime dateTimeOfBooking = Convert.ToDateTime("02/08/2020 16:13:54");
            found = aBooking.Find(bookingId);
            if (aBooking.DateTimeOfBooking != Convert.ToDateTime("02/08/2020 16:13:54"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
    }
}
