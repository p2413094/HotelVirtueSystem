using System;
using System.Collections.Generic;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstRoomTypeCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsRoomTypeCollection allRoomTypes = new clsRoomTypeCollection();
            Assert.IsNotNull(allRoomTypes);
        }

        [TestMethod]
        public void ThisRoomTypePropertyOk()
        {
            clsRoomTypeCollection AllRoomTypes = new clsRoomTypeCollection();
            clsRoomType testRoomType = new clsRoomType();
            testRoomType.RoomTypeId = 24;
            testRoomType.Description = "This room consists of a single bed.";
            AllRoomTypes.thisRoomType = testRoomType;
            Assert.AreEqual(AllRoomTypes.thisRoomType, testRoomType);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsRoomTypeCollection allRoomTypes = new clsRoomTypeCollection();
            List<clsRoomType> testList = new List<clsRoomType>();
            clsRoomType testItem = new clsRoomType();
            testItem.RoomTypeId = 24;
            testItem.someRoomType = "This room consists of a single bed.";
            testItem.SingleBed = 1;
            testList.Add(testItem);
            allRoomTypes.RoomTypeList = testList;
            Assert.AreEqual(allRoomTypes.Count, testList.Count);
        }

    }
}

