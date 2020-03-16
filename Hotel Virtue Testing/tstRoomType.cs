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

        [TestMethod]
        public void MaximumOccupancyPropertyOK()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create some test data to assign to the property 
            Int32 MaximumOccupancy = 1;
            //assign the data to the property 
            aRoomType.MaximumOccupancy = MaximumOccupancy;
            //test to see that the two values are the same 
            Assert.AreEqual(aRoomType.MaximumOccupancy, MaximumOccupancy);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "This room consists of a single bed";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void RoomDescriptionLessOne()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void RoomDescriptionMinBoundary()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "This room consists of a single bed.";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "This room consists of 3 single beds.";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }


    }
}
