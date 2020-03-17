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

        public void PricePropertyOk()
        {
            clsRoom aRoom = new clsRoom();
            decimal testData = 79.99m;
            aRoom.Price = testData;
            Assert.AreEqual(aRoom.Price, testData);
        }

        [TestMethod]
        public void RoomFloorPropertyOk()
        {
            clsRoom aRoom = new clsRoom();
            Int32 testData = 1;
            aRoom.RoomFloor = testData;
            Assert.AreEqual(aRoom.RoomFloor, testData);
        }

        [TestMethod]
        public void RoomIdPropertyOk()
        {
            clsRoom aRoom = new clsRoom();
            Int32 testData = 1;
            aRoom.RoomId = testData;
            Assert.AreEqual(aRoom.RoomId, testData);
        }

        [TestMethod]
        public void RoomNoPropertyOk()
        {
            clsRoom aRoom = new clsRoom();
            Int32 testData = 1;
            aRoom.RoomNo = testData;
            Assert.AreEqual(aRoom.RoomNo, testData);
        }

        [TestMethod]
        public void RoomTypeIdOk()
        {
            clsRoom aRoom = new clsRoom();
            Int32 testData = 1;
            aRoom.RoomTypeId = testData;
            Assert.AreEqual(aRoom.RoomTypeId, testData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsRoom aRoom = new clsRoom();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoom = "1";
            //invoke the method 
            Error = aRoom.Valid(someRoom);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsRoom aRoom = new clsRoom();
            Boolean found = false;
            Int32 RoomId = 1;
            found = aRoom.Find(RoomId);
            Assert.IsTrue(found);
        }


        [TestMethod]
        public void HotelIdLessOne()
        {
            //create an instance of the class we want to create 
            clsRoom aRoom = new clsRoom();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoom = "";
            //invoke the method 
            Error = aRoom.Valid(someRoom);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HotelIdMinBoundary()
        {
            //create an instance of the class we want to create 
            clsRoom aRoom = new clsRoom();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoom = "1";
            //invoke the method 
            Error = aRoom.Valid(someRoom);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelIdMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsRoom aRoom = new clsRoom();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoom = "2";
            //invoke the method 
            Error = aRoom.Valid(someRoom);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelIdMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsRoom aRoom = new clsRoom();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoom = "999";
            //invoke the method 
            Error = aRoom.Valid(someRoom);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HotelIdMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsRoom aRoom = new clsRoom();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoom = "1000";
            //invoke the method 
            Error = aRoom.Valid(someRoom);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }
    }
}
