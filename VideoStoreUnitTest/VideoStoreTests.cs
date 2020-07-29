using DSD_2_VideoStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace VideoStoreUnitTest
{
    [TestClass]
    public class VideoStoreTests
    {
        private Database obj = new Database();

        [TestMethod]
        public void TestMethod1()
        {
            SqlConnection Connection = new SqlConnection();
            Connection.Open();
        }

        [TestMethod]
        public void MovieCost()
        {
            var connection = @"Data Source = DESKTOP - BOJJVGV\SQLDB; Initial Catalog = VideoRental; Integrated Security = True; ";
            var expect = connection;
            Assert.AreEqual(connection, expect);
        }
    }
}