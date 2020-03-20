using System;
using System.Collections.Generic;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstHotelCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsHotelCollection allHotels = new clsHotelCollection();
            Assert.IsNotNull(allHotels);
        }

        public void HotelListOK()
        {
            clsHotelCollection allHotels = new clsHotelCollection();
            List<clsHotel> testList = new List<clsHotel>();
            clsHotel testItem = new clsHotel();
            testItem.HotelId = 1;
            testItem.Address = "Leicester Road";
            testItem.Address = "leicester";
            testItem.Address = "Leicester Road";
            testItem.ArrivalDate = DateTime.Now;
            testItem.DepartureDate = DateTime.Now;
            testItem.Name = "Hotel Village";
            testItem.NumberofGuests = 4;
            testItem.UnderFive = 1;
            testItem.PostCode = "LE19 1SH";
            testList.Add(testItem);
            allHotels.HotelList = testList;
            Assert.AreEqual(allHotels.HotelList, testList);


        }
    }
}
