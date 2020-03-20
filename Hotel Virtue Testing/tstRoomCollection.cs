using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void RoomListOK()
        {
            clsRoomCollection allRooms = new clsRoomCollection();
            List<clsRoom> testList = new List<clsRoom>();
            clsRoom testItem = new clsRoom();
            testItem.HotelId = 1;
            testItem.Accessible = true;
            testItem.Price = 79.99m;
            testItem.RoomFloor = 5;
            testItem.RoomId = 14;
            testItem.RoomNumber = 6;
            testItem.RoomTypeId = 15;
            testList.Add(testItem);
            allRooms.RoomList = testList;
            Assert.AreEqual(allRooms.RoomList, testList);


        }
    }
}

    


