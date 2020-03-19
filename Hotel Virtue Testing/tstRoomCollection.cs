using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstRoomCollection
    {

        [TestMethod]
        public void InstanceOk()
        {
            clsRoomCollection allRooms = new clsRoomCollection();
            Assert.IsNotNull(allRooms);
        }
    }
}
