using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstBookingLine
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Assert.IsNotNull(aBookingLine);
        }

        [TestMethod]
        public void BookingLineIdPropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Int32 testData = 1;
            aBookingLine.BookingLineId = testData;
            Assert.AreEqual(aBookingLine.BookingLineId, testData);
        }

        [TestMethod]
        public void RoomIdPropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Int32 testData = 1;
            aBookingLine.RoomId = testData;
            Assert.AreEqual(aBookingLine.RoomId, testData);
        }

        [TestMethod]
        public void UnderFivePropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Int32 testData = 1;
            aBookingLine.UnderFive = testData;
            Assert.AreEqual(aBookingLine.UnderFive, testData);
        }

        [TestMethod]
        public void FiveToSixteenPropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Int32 testData = 1;
            aBookingLine.FiveToSixteen = testData;
            Assert.AreEqual(aBookingLine.FiveToSixteen, testData);
        }

        [TestMethod]
        public void SixteenUpwardsPropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Int32 testData = 1;
            aBookingLine.SixteenUpwards = testData;
            Assert.AreEqual(aBookingLine.SixteenUpwards, testData);
        }

        [TestMethod]
        public void ArrivalDatePropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            DateTime testData = DateTime.Now.Date;
            aBookingLine.ArrivalDate = testData;
            Assert.AreEqual(aBookingLine.ArrivalDate, testData);
        }

        [TestMethod]
        public void DepartureDatePropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            DateTime testData = DateTime.Now.Date.AddDays(3);
            aBookingLine.DepartureDate = testData;
            Assert.AreEqual(aBookingLine.DepartureDate, testData);
        }

        [TestMethod]
        public void GymAccessPropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean testData = true;
            aBookingLine.GymAccess = testData;
            Assert.AreEqual(aBookingLine.GymAccess, testData);
        }


        [TestMethod]
        public void LateCheckoutPropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            Boolean testData = true;
            aBookingLine.LateCheckout = testData;
            Assert.AreEqual(aBookingLine.LateCheckout, testData);
        }

        [TestMethod]
        public void OtherPropertyOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string testData = "Champagne on arrival";
            aBookingLine.Other = testData;
            Assert.AreEqual(aBookingLine.Other, testData);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateExtremeMin()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(-100);
            DateTime departureDate = DateTime.Now.Date;
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreNotEqual(error, "");
        }


        [TestMethod]
        public void ArrivalDateMinMinusOne()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(-1);
            DateTime departureDate = DateTime.Now.Date;
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateMinBoundary()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards); 
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateMinPlusOne()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(1);
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards); 
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateExtremeMax()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(100);
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards); 
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateExtremeMin()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(-100);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards); 
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateMinMinusOne()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(-1);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards); 
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateMinBoundary()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards); 
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateMinPlusOne()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(2);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards); 
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateExtremeMax()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(100);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards); 
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OtherExtremeMin()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OtherMinBoundary()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "t";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherMinPlusOne()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "te";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherMaxMinusOne()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "";
            other = other.PadRight(49, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherMaxBoundary()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "";
            other = other.PadRight(50, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherMaxPlusOne()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "";
            other = other.PadRight(51, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OtherMid()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "";
            other = other.PadRight(25, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OtherExtremeMax()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "";
            other = other.PadRight(250, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void MaximumOccupancySmallest()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "";
            other = other.PadRight(50, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 1;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void MaximumOccupancyBigger()
        {
            clsBookingLine aBookingLine = new clsBookingLine();
            string error = "";
            string other = "";
            other = other.PadRight(50, 't');
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(3);
            Int32 roomId = 1;
            Int32 underFive = 1;
            Int32 fiveToSixteen = 1;
            Int32 SixteenUpwards = 5;
            error = aBookingLine.Valid(arrivalDate, departureDate, other, roomId, underFive, fiveToSixteen, SixteenUpwards);
            Assert.AreNotEqual(error, "");
        }
    }
}