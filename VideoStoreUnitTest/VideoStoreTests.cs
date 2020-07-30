using System.Data;
using DSD_2_VideoStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace VideoStoreUnitTest
{
    [TestClass]
    public class VideoStoreTests
    {
        //create an instance of the Database Class
        private Database myDatabase = new Database();

        //Testing the connection to the database is getting data
        [TestMethod]
        public void TestConnection()
        {
            Assert.IsInstanceOfType(myDatabase.FillDGVCustomersWithCustomers(), typeof(DataTable));
        }

        [TestMethod]
        public void 
    }
}