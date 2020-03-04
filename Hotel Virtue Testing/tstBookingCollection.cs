using System;
using System.Collections.Generic;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstBookingCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsBookingCollection allBookings = new clsBookingCollection();
            Assert.IsNotNull(allBookings);
        }

        [TestMethod]
        public void BookingListOk()
        {
            clsBookingCollection allBookings = new clsBookingCollection();
            List<clsBooking> testList = new List<clsBooking>();
            clsBooking testItem = new clsBooking();
            testItem.AdminId = 1;
            testItem.BookingId = 1;
            testItem.CustomerId = 1;
            testItem.DateTimeOfBooking = DateTime.Now;
            testItem.HotelId = 1;
            testItem.Cancelled = false;
            testList.Add(testItem);
            allBookings.BookingList = testList;
            Assert.AreEqual(allBookings.BookingList, testList);
        }

        [TestMethod]
        public void ThisBookingPropertyOk()
        {
            clsBookingCollection allBookings = new clsBookingCollection();
            clsBooking testBooking = new clsBooking();
            testBooking.AdminId = 1;
            testBooking.BookingId = 1;
            testBooking.CustomerId = 1;
            testBooking.DateTimeOfBooking = DateTime.Now;
            testBooking.HotelId = 1;
            testBooking.Cancelled = false;
            allBookings.ThisBooking = testBooking;
            Assert.AreEqual(allBookings.ThisBooking, testBooking);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsBookingCollection allBookings = new clsBookingCollection();
            List<clsBooking> TestList = new List<clsBooking>();
            clsBooking TestItem = new clsBooking();
            TestItem.BookingId = 1;
            TestItem.CustomerId = 1;
            TestItem.HotelId = 1;
            TestItem.AdminId = 1;
            TestItem.Total = 90m;
            TestItem.Cancelled = false;
            TestItem.DateTimeOfBooking = DateTime.Now;
            TestList.Add(TestItem);
            allBookings.BookingList = TestList;
            Assert.AreEqual(allBookings.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsBookingCollection allBookings = new clsBookingCollection();
            clsBooking testItem = new clsBooking();
            Int32 primaryKey = 0;
            testItem.CustomerId = 1;
            testItem.HotelId = 1;
            testItem.AdminId = 1;
            testItem.DateTimeOfBooking = DateTime.Now;
            testItem.Total = 89.99m;
            allBookings.ThisBooking = testItem;
            primaryKey = allBookings.Add();
            testItem.BookingId = primaryKey;
            allBookings.ThisBooking.Find(primaryKey);
            Assert.AreEqual(allBookings.ThisBooking, testItem);
        }

        [TestMethod]
        public void tblBookingFindMethodOk()
        {
            clsBooking aBooking = new clsBooking();
            Boolean found = false;
            Int32 bookingId = 1;
            found = aBooking.Find(bookingId);
            Assert.IsTrue(found);
        }           
    }
}
