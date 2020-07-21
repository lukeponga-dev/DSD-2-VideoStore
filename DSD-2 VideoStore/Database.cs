using System;
using System.Data;
using System.Data.SqlClient;

namespace DSD_2_VideoStore
{
    public class Database
    {
        //Create a Connection, Command, Adapter
        private SqlConnection Connection = new SqlConnection(); // connect to db

        private SqlCommand Command = new SqlCommand(); // give it a query
        private SqlDataAdapter da = new SqlDataAdapter(); // hold the results

        public Database()
        {
            //change the connection string to your db
            var connectionString = @"Data Source=DESKTOP-BOJJVGV\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True;Connect Timeout=30;";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }

        public int CustID { get; set; }
        public int MovieID { get; set; }
        public int RMID { get; set; }
        public string DateReturned { get; set; }
        public DateTime Today { get; set; }

        //Takes all data from Customers
        public DataTable FillDGVCustomersWithCustomers()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Customer", Connection))
            {
                //connect to DB and get SQL
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }

            return dt;
        }

        //Takes all data from Movies
        public DataTable FillDGVMoviesWithMovies()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Movies", Connection))
            {
                //connect to DB and get SQL
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }

            return dt;
        }

        //Takes all data from Rented Movies
        public DataTable FillDGVRentalsWithCustomerAndMoviesRented()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from RentedMovies", Connection))
            {
                //connect to DB and get SQL
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }

            return dt;
        }

        public string AddOrUpdateCustomer(string CustID, string FirstName, string LastName, string Address,
            string Phone, string AddOrUpdate)
        {
            try
            {
                //Add gets passed through the parameter
                if (AddOrUpdate == "Add")
                {
                    //Create and open a connection to SQL Server
                    var query =
                        "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES  (@FirstName, @LastName, @Address, @Phone)";

                    var objCommand = new SqlCommand(query, Connection); //Create a Command object
                    //use parameters to prevent SQL injections
                    objCommand.Parameters.AddWithValue("@FirstName", FirstName);
                    objCommand.Parameters.AddWithValue("@LastName", LastName);
                    objCommand.Parameters.AddWithValue("@Address", Address);
                    objCommand.Parameters.AddWithValue("@Phone", Phone);
                    Connection.Open();
                    // add in the SQL
                    objCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                // update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    var objCommand =
                        new SqlCommand(
                            "UPDATE Customer set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone  where CustID = @CustID",
                            Connection);
                    //use parameters to prevent SQL injections
                    objCommand.Parameters.AddWithValue("@FirstName", FirstName);
                    objCommand.Parameters.AddWithValue("@LastName", LastName);
                    objCommand.Parameters.AddWithValue("@Address", Address);
                    objCommand.Parameters.AddWithValue("@Phone", Phone);
                    objCommand.Parameters.AddWithValue("@CustID", CustID);
                    Connection.Open();
                    // add in the SQL
                    objCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return AddOrUpdate + " is Successful";
            }
            catch (Exception e)
            {
                Connection.Close();
                return " has failed with " + e;
            }
        }

        public string DeleteCustomer(string CustID, string DeleteCust)
        {
            try
            {
                if (DeleteCust == "Delete")
                {
                    var objCommand = new SqlCommand("DELETE FROM Customer where CustID = @CustID", Connection);

                    objCommand.Parameters.AddWithValue("CustID", CustID);
                    Connection.Open();
                    objCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return "Customer ID #" + CustID + " Successfully Deleted";
            }
            catch (Exception e)
            {
                Connection.Close();
                return " Failed " + e;
            }
        }

        public string AddOrUpdateMovie(string MovieID, string Title, string Genre, string Year, string Rating,
            string Plot, string Copies, string Rental_Cost, string AddOrUpdate)
        {
            try
            {
                //Add gets passed through the parameter
                if (AddOrUpdate == "Add")
                {
                    //Create and open a connection to SQL Server
                    var query = "INSERT INTO Movies (Title, Genre, Year, Rating, Plot, Copies, Rental_Cost) " +
                                "VALUES  (@Title, @Genre, @Year, @Rating, @Plot, @Copies, @Rental_Cost)";

                    var objCommand = new SqlCommand(query, Connection); //Create a Command object
                    //use parameters to prevent SQL injections
                    objCommand.Parameters.AddWithValue("@Title", Title);
                    objCommand.Parameters.AddWithValue("@Genre", Genre);
                    objCommand.Parameters.AddWithValue("@Year", Year);
                    objCommand.Parameters.AddWithValue("@Rating", Rating);
                    objCommand.Parameters.AddWithValue("@Plot", Plot);
                    objCommand.Parameters.AddWithValue("@Copies", Copies);
                    objCommand.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                    Connection.Open();
                    // add in the SQL
                    objCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                // Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    var objCommand =
                        new SqlCommand(
                            "UPDATE Movies set Title = @Title, Genre = @Genre, Year = @Year, Rating = @Rating, Plot = @Plot, Copies = @Copies, Rental_Cost = @Rental_Cost where MovieID = @MovieID",
                            Connection);
                    //use parameters to prevent SQL injections
                    objCommand.Parameters.AddWithValue("@Title", Title);
                    objCommand.Parameters.AddWithValue("@Genre", Genre);
                    objCommand.Parameters.AddWithValue("@Year", Year);
                    objCommand.Parameters.AddWithValue("@Rating", Rating);
                    objCommand.Parameters.AddWithValue("@Plot", Plot);
                    objCommand.Parameters.AddWithValue("@Copies", Copies);
                    objCommand.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                    objCommand.Parameters.AddWithValue("@MovieID", MovieID);
                    Connection.Open();
                    // add in the SQL
                    objCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return AddOrUpdate + " Successful";
            }
            catch (Exception e)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();
                return " has failed with " + e;
            }
        }

        public string DeleteMovies(string MovieID, string DeleteMovie)
        {
            try
            {
                if (DeleteMovie == "Delete")
                {
                    //Create a query
                    var objCommand = new SqlCommand("DELETE FROM Movies where MovieID = @MovieID", Connection);
                    // create params
                    objCommand.Parameters.AddWithValue("MovieID", MovieID);
                    //create and open DB Connection
                    Connection.Open();
                    objCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return " Movie ID #" + MovieID + " Successfully Deleted";
            }
            catch (Exception e)
            {
                // need to get it to close a second time if it jumps the first connection.close
                Connection.Close();
                return " Failed " + e;
            }
        }

        public string IssueMovie(string MovieID, string CustID, DateTime DateRented)
        {
            try
            {
                //Create a query
                var objCommand = new SqlCommand("INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) VALUES (@MovieID, @CustID, @DateRented)", Connection);
                // create params
                objCommand.Parameters.AddWithValue("@MovieID", MovieID);
                objCommand.Parameters.AddWithValue("@CustID", CustID);
                objCommand.Parameters.AddWithValue("@DateRented", DateRented);

                //create and open DB Connection
                Connection.Open();
                objCommand.ExecuteNonQuery();
                Connection.Close();

                return " Movie Successfully Rented";
            }
            catch (Exception e)
            {
                // need to get it to close a second time if it jumps the first connection.close
                Connection.Close();
                return " failed " + e;
            }
        }

        public string ReturnMovie(string ID)
        {
            try
            {
                Today = System.DateTime.Now;

                string query = "UPDATE RentedMovies set DateReturned = @Today WHERE RMID = @ID";
                var myCommand = new SqlCommand(query, Connection);
                // create the parameters
                myCommand.Parameters.AddWithValue("Today", Today);
                myCommand.Parameters.AddWithValue("ID", ID);
                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();

                return " Return is Successful";
            }
            catch (Exception e)
            {
                //need to get it to close a second time as it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();

                return "Return has Failed with " + e;
            }
        }
    }
}