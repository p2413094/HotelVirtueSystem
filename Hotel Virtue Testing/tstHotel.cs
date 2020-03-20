using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstHotel
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsHotel aHotel = new clsHotel();
            Assert.IsNotNull(aHotel);
        }

        [TestMethod]
        public void HotelIdPropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            Int32 testData = 1;
            aHotel.HotelId = testData;
            Assert.AreEqual(aHotel.HotelId, testData);
        }

        [TestMethod]
        public void AddressPropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            string testData = "Leicester Road";
            aHotel.Address = testData;
            Assert.AreEqual(aHotel.Address, testData);
        }

        [TestMethod]
        public void CityPropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            string testData = "Leicester";
            aHotel.City = testData;
            Assert.AreEqual(aHotel.City, testData);

        }

        [TestMethod]
        public void ArrivalDatePropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            DateTime testData = DateTime.Now.Date;
            aHotel.ArrivalDate = testData;
            Assert.AreEqual(aHotel.ArrivalDate, testData);
        }

        [TestMethod]
        public void DepartureDatePropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            DateTime testData = DateTime.Now.Date.AddDays(3);
            aHotel.DepartureDate = testData;
            Assert.AreEqual(aHotel.DepartureDate, testData);
        }

        [TestMethod]
        public void NamePropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            string testData = "Hotel Village";
            aHotel.Name = testData;
            Assert.AreEqual(aHotel.Name, testData);

        }

        [TestMethod]
        public void NumberofGuestsPropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            Int32 testData = 5;
            aHotel.NumberofGuests = testData;
            Assert.AreEqual(aHotel.NumberofGuests, testData);

        }

        [TestMethod]
        public void UnderFivePropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            Int32 testData = 1;
            aHotel.UnderFive = testData;
            Assert.AreEqual(aHotel.UnderFive, testData);
        }

        [TestMethod]
        public void FiveToSixteenPropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            Int32 testData = 1;
            aHotel.FiveToSixteen = testData;
            Assert.AreEqual(aHotel.FiveToSixteen, testData);
        }

        [TestMethod]
        public void SixteenUpwardsPropertyOk()
        {
            clsHotel aHotel = new clsHotel();
            Int32 testData = 1;
            aHotel.SixteenUpwards = testData;
            Assert.AreEqual(aHotel.SixteenUpwards, testData);
        }

        [TestMethod]
        public void ArrivalDateExtremeMin()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(-100);
            DateTime departureDate = DateTime.Now.Date;
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateMinMinusOne()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(-1);
            DateTime departureDate = DateTime.Now.Date;
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateMinBoundary()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateMinPlusOne()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(1);
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ArrivalDateExtremeMax()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date.AddDays(100);
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateExtremeMin()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(-100);
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateMinMinusOne()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(-1);
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateMinBoundary()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(1);
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateMinPlusOne()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(2);
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DepartureDateExtremeMax()
        {
            clsHotel aHotel = new clsHotel();
            string error = "";
            DateTime arrivalDate = DateTime.Now.Date;
            DateTime departureDate = DateTime.Now.Date.AddDays(100);
            error = aHotel.Valid(arrivalDate, departureDate);
            Assert.AreNotEqual(error, "");
        }




    }
}
