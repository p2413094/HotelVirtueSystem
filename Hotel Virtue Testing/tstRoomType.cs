using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstRoomType
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsRoomType aRoomType = new clsRoomType();
            Assert.IsNotNull(aRoomType);
        }

        [TestMethod]
        public void RoomTypeIdPropertyOk()
        {
            clsRoomType aRoomType = new clsRoomType();
            Int32 testData = 1;
            aRoomType.RoomTypeId = testData;
            Assert.AreEqual(aRoomType.RoomTypeId, testData);
        }

    }
}
