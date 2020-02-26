using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelVirtueClasses;

namespace Hotel_Virtue_Testing
{
    [TestClass]
    public class tstCancellation
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCancellation aCancellation = new clsCancellation();
            Assert.IsNotNull(aCancellation);
        }

        [TestMethod]
        public void CancellationIdPropertyOk()
        {
            clsCancellation aCancellation = new clsCancellation();
            Int32 CancellationId = 1;
            aCancellation.CancellationId = CancellationId;
            Assert.AreEqual(aCancellation.CancellationId, CancellationId);
        }

        [TestMethod]
        public void ReasonPropertyOk()
        {
            clsCancellation aCancellation = new clsCancellation();
            string Reason = "Reason";
            aCancellation.Reason = Reason;
            Assert.AreEqual(aCancellation.Reason, Reason);
        }

        [TestMethod]
        public void DateTimeOfCancellationPropertyOk()
        {
            clsCancellation aCancellation = new clsCancellation();
            DateTime dateTimeOfCancellation = DateTime.Now;
            aCancellation.DateTimeOfCancellation = dateTimeOfCancellation;
            Assert.AreEqual(aCancellation.DateTimeOfCancellation, dateTimeOfCancellation);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsCancellationCollection AllCancellations = new clsCancellationCollection();
            clsCancellation testItem = new clsCancellation();
            Int32 primaryKey = 0;
            testItem.BookingLineId = 3;
            testItem.DateTimeOfCancellation = DateTime.Now;
            testItem.Reason = "TEST3";
            AllCancellations.thisCancellation = testItem;
            primaryKey = AllCancellations.Add();
            testItem.CancellationId = primaryKey;
            Assert.AreEqual(AllCancellations.thisCancellation, testItem);
        }

        [TestMethod]
        public void ReasonMinLessOne()
        {
            clsCancellation aCancellation = new clsCancellation();
            string Error = "";
            string reason = "";
            Error = aCancellation.Valid(reason);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMinBoundary()
        {
            clsCancellation aCancellation = new clsCancellation();
            string Error = "";
            string reason = "a";
            Error = aCancellation.Valid(reason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMinPlusOne()
        {
            clsCancellation aCancellation = new clsCancellation();
            string Error = "";
            string reason = "ab";
            Error = aCancellation.Valid(reason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMaxLessOne()
        {
            clsCancellation aCancellation = new clsCancellation();
            string Error = "";
            string reason = "0123456789012345678901234567890123456789012345678";
            Error = aCancellation.Valid(reason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMaxBoundary()
        {
            clsCancellation aCancellation = new clsCancellation();
            string Error = "";
            string reason = "01234567890123456789012345678901234567890123456789";
            Error = aCancellation.Valid(reason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMaxPlusOne()
        {
            clsCancellation aCancellation = new clsCancellation();
            string Error = "";
            string reason = "012345678901234567890123456789012345678901234567890";
            Error = aCancellation.Valid(reason);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMid()
        {
            clsCancellation aCancellation = new clsCancellation();
            string Error = "";
            string reason = "0123456789012345678901234";
            Error = aCancellation.Valid(reason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonExtremeMax()
        {
            clsCancellation aCancellation = new clsCancellation();
            string Error = "";
            string reason = "";
            reason = reason.PadRight(500, 'a');
            Error = aCancellation.Valid(reason);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsCancellation aCancellation = new clsCancellation();
            Boolean found = false;
            Int32 cancellationId = 3;
            found = aCancellation.Find(cancellationId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void CancellationIdFound()
        {
            clsCancellation aCancellation = new clsCancellation();
            Boolean found = false;
            Boolean ok = true;
            Int32 cancellationId = 3;
            found = aCancellation.Find(cancellationId);
            if (aCancellation.CancellationId != 3)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void BookingLineIdFound()
        {
            clsCancellation aCancellation = new clsCancellation();
            Boolean found = false;
            Boolean ok = true;
            Int32 cancellationId = 3;
            found = aCancellation.Find(cancellationId);
            if (aCancellation.BookingLineId != 3)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void DateTimeOfCancellationFound()
        {
            clsCancellation aCancellation = new clsCancellation();
            Boolean found = false;
            Boolean ok = true;
            Int32 cancellationId = 3;
            found = aCancellation.Find(cancellationId);
            if (aCancellation.DateTimeOfCancellation != Convert.ToDateTime("17/02/2020 17:59:11"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void ReasonFound()
        {
            clsCancellation aCancellation = new clsCancellation();
            Boolean found = false;
            Boolean ok = true;
            Int32 cancellationId = 3;
            found = aCancellation.Find(cancellationId);
            if (aCancellation.Reason != "Cheaper elsewhere")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
    }
}
