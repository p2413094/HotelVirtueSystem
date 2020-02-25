﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelVirtueClasses;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstBookingLineCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsBookingLineCollection allBookingLines = new clsBookingLineCollection();
            Assert.IsNotNull(allBookingLines);
        }

        [TestMethod]
        public void BookingListOk()
        {           
            clsBookingLineCollection allBookingLines = new clsBookingLineCollection();
            List<clsBookingLine> testList = new List<clsBookingLine>();
            clsBookingLine testItem = new clsBookingLine();
            testItem.BookingLineId = 22;
            testItem.BookingId = 1;
            testItem.RoomId = 1;
            testItem.UnderFive = 1;
            testItem.FiveToSixteen = 1;
            testItem.SixteenUpwards = 1;
            testItem.ArrivalDate = Convert.ToDateTime("20/02/2020");
            testItem.DepartureDate = Convert.ToDateTime("23/02/2020");
            testItem.GymAccess = true;
            testItem.LateCheckout = true;
            testItem.Other = "Test2";
            testList.Add(testItem);
            allBookingLines.BookingLineList = testList;
            Assert.AreEqual(allBookingLines.BookingLineList, testList);
        }

        [TestMethod]
        public void ThisBookingLinePropertyOk()
        {
            clsBookingLineCollection allBookingLines = new clsBookingLineCollection();
            clsBookingLine testBookingLine = new clsBookingLine();
            testBookingLine.BookingLineId = 22;
            testBookingLine.BookingId = 1;
            testBookingLine.RoomId = 1;
            testBookingLine.UnderFive = 1;
            testBookingLine.FiveToSixteen = 1;
            testBookingLine.SixteenUpwards = 1;
            testBookingLine.ArrivalDate = Convert.ToDateTime("25/02/2020");
            testBookingLine.DepartureDate = Convert.ToDateTime("28/02/2020");
            testBookingLine.GymAccess = true;
            testBookingLine.LateCheckout = true;
            testBookingLine.Other = "Test2";
            allBookingLines.thisBookingLine = testBookingLine;
            Assert.AreEqual(allBookingLines.thisBookingLine, testBookingLine);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsBookingLineCollection allBookingLines = new clsBookingLineCollection();
            List<clsBookingLine> testList = new List<clsBookingLine>();
            clsBookingLine testItem = new clsBookingLine();
            testItem.BookingId = 1;
            testItem.RoomId = 1;
            testItem.UnderFive = 1;
            testItem.FiveToSixteen = 1;
            testItem.SixteenUpwards = 1;
            testItem.ArrivalDate = Convert.ToDateTime("25/02/2020");
            testItem.DepartureDate = Convert.ToDateTime("28/02/2020");
            testItem.GymAccess = true;
            testItem.LateCheckout = false;
            testItem.Other = "Test2";
            testList.Add(testItem);
            allBookingLines.BookingLineList = testList;
            Assert.AreEqual(allBookingLines.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsBookingLineCollection allBookingLines = new clsBookingLineCollection();
            clsBookingLine testItem = new clsBookingLine();
            Int32 primaryKey = 0;
            testItem.BookingId = 1;
            testItem.RoomId = 1;
            testItem.UnderFive = 2;
            testItem.FiveToSixteen = 2;
            testItem.SixteenUpwards = 2;
            testItem.ArrivalDate = DateTime.Now.Date;
            testItem.DepartureDate = DateTime.Now.Date.AddDays(2);
            testItem.GymAccess = true;
            testItem.LateCheckout = false;
            testItem.Other = "Test";
            allBookingLines.thisBookingLine = testItem;
            primaryKey = allBookingLines.Add();
            testItem.BookingLineId = primaryKey;
            allBookingLines.thisBookingLine.Find(primaryKey);
            Assert.AreEqual(allBookingLines.thisBookingLine, testItem);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void testBookingLineIdFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.BookingLineId != 3)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testBookingIdFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.BookingId != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testRoomIdFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.RoomId != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testUnderFiveFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.UnderFive != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testFiveToSixteenFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.FiveToSixteen != 2)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testSixteenUpwardsFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.SixteenUpwards != 4)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testArrivalDateFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.ArrivalDate != Convert.ToDateTime("09/02/2020"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testDepartureDateFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.DepartureDate != Convert.ToDateTime("12/02/2020"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testGymAccessFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.GymAccess != true)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testLateCheckoutFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.LateCheckout != true)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void testOtherFound()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean found = false;
            Boolean ok = true;
            Int32 bookingLineId = 3;
            found = aBookingLine.Find(bookingLineId);
            if (aBookingLine.Other != "Test1")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
    }
}