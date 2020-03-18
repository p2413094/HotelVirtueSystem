using System;
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
    }
}
