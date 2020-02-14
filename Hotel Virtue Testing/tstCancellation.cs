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
    }
}
