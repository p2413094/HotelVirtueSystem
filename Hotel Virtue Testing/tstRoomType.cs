﻿using System;
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

        [TestMethod]
        public void RoomDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "Each room is contemporary  design and extremely comfortable featuring a super-comfy King bed, modern en-suite bathroom with walk in rainfall shower head, large flat screen TV, tea and coffee facilities, Alexa Dot technology and free Wi-Fi. Access to Health & Fitness Club is £5.00 per room per night";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomDescriptionMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "Each room is contemporary  design and extremely comfortable featuring a super-comfy King bed, modern en-suite bathroom with walk in rainfall shower head, large flat screen TV, tea and coffee facilities, Alexa Dot technology and free Wi-Fi. Access to Health & Fitness Club is £5.00 per room per night.";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "Each room is contemporary  design and extremely comfortable featuring a super-comfy King bed, modern en-suite bathroom with walk in rainfall shower head, large flat screen TV, tea and coffee facilities, Alexa Dot technology and free Wi-Fi. Access to Health & Fitness Club is £5.00 per room per night..";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomDescriptionMid()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "Each room is contemporary  design and extremely comfortable featuring a super-comfy King bed, modern en-suite bathroom with walk in rainfall shower he";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomDescriptionExtremeMax()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "";
            //pad the string with characters
            someRoomType = someRoomType.PadRight(500, 'a');
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomTypeIdLessOne()
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
        public void RoomTypeIdMinBoundary()
        {
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string RoomTypeId = "1";
            Error = aRoomType.Valid(RoomTypeId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomTypeIdMinPlusOne()
        {
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string RoomTypeId = "2";
            Error = aRoomType.Valid(RoomTypeId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomTypeIdMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string RoomTypeId = "999";
            Error = aRoomType.Valid(RoomTypeId);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomTypeIdMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "1000";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomTypeIdMaxPlusOne()
        {
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string someRoomType = "1001";
            Error = aRoomType.Valid(someRoomType);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomTypeMid()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "500";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomTypeIdExtremeMax()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "";
            //pad the string with characters
            someRoomType = someRoomType.PadRight(500, 'a');
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SingleBedLessOne()
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
        public void SingleBedMinBoundary()
        {
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string SingleBed = "1";
            Error = aRoomType.Valid(SingleBed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SingleBedMinPlusOne()
        {
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string SingleBed = "2";
            Error = aRoomType.Valid(SingleBed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SingleBedMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string SingleBed = "1";
            Error = aRoomType.Valid(SingleBed);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SingleBedMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "2";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SingleBedMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "3";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SingleBedMid()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "1";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SingleBedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "10";
            //pad the string with characters
            someRoomType = someRoomType.PadRight(500, 'a');
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DoubleBedLessOne()
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
        public void DoubleBedMinBoundary()
        {
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string DoubleBed = "1";
            Error = aRoomType.Valid(DoubleBed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DoubleBedMinPlusOne()
        {
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string DoubleBed = "2";
            Error = aRoomType.Valid(DoubleBed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DoubleBedMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            string Error = "";
            string DoubleBed = "1";
            Error = aRoomType.Valid(DoubleBed);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DoubleBedMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "2";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DoubleBedMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "3";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DoubleBedMid()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "1";
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DoubleBedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsRoomType aRoomType = new clsRoomType();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method 
            string someRoomType = "4";
            //pad the string with characters
            someRoomType = someRoomType.PadRight(500, 'a');
            //invoke the method 
            Error = aRoomType.Valid(someRoomType);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }
    }

}
