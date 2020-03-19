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

    }
}
