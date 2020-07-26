using DSD_2_VideoStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStoreUnitTest
{
    [TestClass]
    public class VideoStoreTests
    {
        private Database myDatabase = new Database();

        [TestMethod]
        public void TestMethod1()
        {
            var CustID = myDatabase.CustID;
        }
    }
}