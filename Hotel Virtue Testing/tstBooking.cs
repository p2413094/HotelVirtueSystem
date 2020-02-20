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
        public void CustomerIdPropertyOk()
        {
            clsBooking aBooking = new clsBooking();
            Int32 testData = 1;
            aBooking.CustomerId = testData;
            Assert.AreEqual(aBooking.CustomerId, testData);
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
