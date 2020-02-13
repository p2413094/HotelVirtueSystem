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
            testItem.ArrivalDate = DateTime.Now.Date;
            testItem.BookingId = 1;
            testItem.BookingLineId = 1;
            testItem.CustomerId = 1;
            testItem.DateTimeOfBooking = DateTime.Now;
            testItem.Extras = "Extras";
            testItem.HotelId = 1;
            testItem.Other = "Other";
            testItem.RoomId = 1;
            testItem.SixteenUpwards = 1;
            testItem.UnderFive = 1;
            testItem.FiveToSixteen = 1;
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
            testBooking.ArrivalDate = DateTime.Now.Date;
            testBooking.BookingId = 1;
            testBooking.BookingLineId = 1;
            testBooking.CustomerId = 1;
            testBooking.DateTimeOfBooking = DateTime.Now;
            testBooking.Extras = "Extras";
            testBooking.HotelId = 1;
            testBooking.Other = "Other";
            testBooking.RoomId = 1;
            testBooking.SixteenUpwards = 1;
            testBooking.UnderFive = 1;
            testBooking.FiveToSixteen = 1;
            allBookings.ThisBooking = testBooking;
            Assert.AreEqual(allBookings.ThisBooking, testBooking);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsBookingCollection allBookings = new clsBookingCollection();
            List<clsBooking> TestList = new List<clsBooking>();
            clsBooking TestItem = new clsBooking();
            TestItem.AdminId = 1;
            TestItem.ArrivalDate = DateTime.Now.Date;
            TestItem.BookingId = 1;
            TestItem.BookingLineId = 1;
            TestItem.CustomerId = 1;
            TestItem.DateTimeOfBooking = DateTime.Now;
            TestItem.DepartureDate = DateTime.Now.Date.AddDays(3);
            TestItem.FiveToSixteen = 1;
            TestItem.Other = "Other";
            TestItem.RoomId = 1;
            TestItem.SixteenUpwards = 1;
            TestItem.UnderFive = 1;
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
            testItem.AdminId = 1;
            testItem.ArrivalDate = DateTime.Now.Date;
            testItem.BookingId = 1;
            testItem.CustomerId = 1;
            testItem.DateTimeOfBooking = DateTime.Now;
            testItem.DepartureDate = DateTime.Now.Date.AddDays(3);
            testItem.FiveToSixteen = 1;
            testItem.Other = "Test2";
            testItem.Extras = "Extras";
            testItem.RoomId = 1;
            testItem.SixteenUpwards = 1;
            testItem.UnderFive = 1;
            allBookings.ThisBooking = testItem;
            primaryKey = allBookings.Add();
            testItem.BookingLineId = primaryKey;

            ////
            //allBookings.ThisBooking.Find(primaryKey);
            ////
            Assert.AreEqual(allBookings.ThisBooking, testItem);
        }
    }
}
