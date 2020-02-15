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
    }
}
