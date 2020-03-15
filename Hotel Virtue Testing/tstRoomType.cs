using System;
using HotelVirtueClasses;
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

        [TestMethod]
        public void DoubleBedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create some test data to assign to the property 
            Int32 DoubleBed = 1;
            //assign the data to the property 
            aRoomType.DoubleBed = DoubleBed;
            //test to see that the two values are the same 
            Assert.AreEqual(aRoomType.DoubleBed, DoubleBed);

        }

        [TestMethod]
        public void SingleBedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create some test data to assign to the property 
            Int32 SingleBed = 1;
            //assign the data to the property 
            aRoomType.SingleBed = SingleBed;
            //test to see that the two values are the same 
            Assert.AreEqual(aRoomType.SingleBed, SingleBed);

        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create some test data to assign to the property 
            string someRoomType = "This room consists of a single bed";
            //assign the data to the property 
            aRoomType.Description = someRoomType;
            //test to see that the two values are the same 
            Assert.AreNotEqual(aRoomType.Descripton, someRoomType);
        }

    }
}
