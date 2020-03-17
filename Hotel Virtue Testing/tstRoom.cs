using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstRoom
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsRoom aRoom = new clsRoom();
            Assert.IsNotNull(aRoom);
        }
        [TestMethod]
        public void HotelIdPropertyOk()
        {
            clsRoom aRoom = new clsRoom();
            Int32 testData = 1;
            aRoom.HotelId = testData;
            Assert.AreEqual(aRoom.HotelId, testData);
        }
    }
}
