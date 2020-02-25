using System;
using HotelVirtueClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstCancellationCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCancellationCollection allCancellations = new clsCancellationCollection();
            Assert.IsNotNull(allCancellations);
        }

        [TestMethod]
        public void PaymentListOk()
        {
            clsCancellationCollection AllCancellations = new clsCancellationCollection();
            List<clsCancellation> testList = new List<clsCancellation>();
            clsCancellation testItem = new clsCancellation();
            testItem.BookingLineId = 229;
            testItem.Reason = "Cheaper elsewhere";
            testList.Add(testItem);
            AllCancellations.CancellationList = testList;
            Assert.AreEqual(AllCancellations.CancellationList, testList);
        }     

        [TestMethod]
        public void ThisCancellationPropertyOk()
        {
            clsCancellationCollection AllCancellations = new clsCancellationCollection();
            clsCancellation testCancellation = new clsCancellation();
            testCancellation.BookingLineId = 229;
            testCancellation.Reason = "Cheaper elsewhere";
            AllCancellations.thisCancellation = testCancellation;
            Assert.AreEqual(AllCancellations.thisCancellation, testCancellation);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsCancellationCollection allPayments = new clsCancellationCollection();
            List<clsCancellation> testList = new List<clsCancellation>();
            clsCancellation testItem = new clsCancellation();
            testItem.BookingLineId = 229;
            testItem.Reason = "Cheaper elsewhere";
            testItem.DateTimeOfCancellation = DateTime.Now;
            testList.Add(testItem);
            allPayments.CancellationList = testList;
            Assert.AreEqual(allPayments.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsCancellationCollection allCancellations = new clsCancellationCollection();
            clsCancellation testCancellation = new clsCancellation();
            Int32 primaryKey = 0;
            testCancellation.BookingLineId = 3;
            testCancellation.DateTimeOfCancellation = DateTime.Now;
            testCancellation.Reason = "19:15";
            allCancellations.thisCancellation.Add();
            testCancellation.CancellationId = primaryKey;
            allCancellations.thisCancellation.Find(primaryKey);
            Assert.AreEqual(allCancellations.thisCancellation, testCancellation);
        }
    }
}
