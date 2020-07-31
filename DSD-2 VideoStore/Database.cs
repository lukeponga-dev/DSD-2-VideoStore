using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DSD_2_VideoStore
{
    public class Database
    {
        private readonly SqlCommand Command = new SqlCommand();

        //Create connection and Command and an Adapter
        private readonly SqlConnection Connection = new SqlConnection();

        private SqlDataAdapter da = new SqlDataAdapter();

        // constructor sets the default upon loading the class
        public Database()
        {
            //change the connection string to your db
            var connectionString =
                @"Data Source=DESKTOP-BOJJVGV\SQLDB;Initial Catalog=VideoRental;Integrated Security=True;";

            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }

        //PROPERTIES
        public int CustID { get; set; }

        public int MovieID { get; set; }
        public int RMID { get; set; }
        public DateTime Today { get; set; }

        //Takes all data from Customers
        public DataTable FillDGVCustomerWithCustomers()
        {
            //Create a datatable
            var dt = new DataTable();
            using (da = new SqlDataAdapter("SELECT * from Customer", Connection))
            {
                //Get results of query
                Connection.Open();
                //Fill the table from the Database
                da.Fill(dt);
                //Close the connection
                Connection.Close();
            }

            return dt;
        }

        //Takes all data from Movies
        public DataTable FillDGVMoviesWithMovies()
        {
            //Create a datatable
            var dt = new DataTable();
            using (da = new SqlDataAdapter("SELECT * from Movies", Connection))
            {
                //Get results of query
                Connection.Open();
                //Fill the table from the Database
                da.Fill(dt);
                //Close the connection
                Connection.Close();
            }

            return dt;
        }

        //Takes all data from Rented Movies
        public DataTable FillDGVRentalsWithCustomerAndMoviesRented(bool Outonly)
        {
            //create a datatable
            var dt = new DataTable();
            //If the radio button is pressed
            string sqlQuery;
            if (Outonly)
                sqlQuery = "SELECT * FROM CustomersAndMoviesRented WHERE DateReturned IS NULL";
            else
                sqlQuery = "SELECT * FROM CustomersAndMoviesRented";
            using (da = new SqlDataAdapter(sqlQuery, Connection))
            {
                //Get results of query
                Connection.Open();
                //Fill the table from the Database
                da.Fill(dt);
                //Close the connection
                Connection.Close();
            }

            return dt;
        }

        //Fill TopCustomers with TopCustomers View method
        public DataTable FillDGVTopCustomersWithTopCustomers(string TotalRented)
        {
            var dt = new DataTable();

            using (var objCommand =
                new SqlCommand(
                    "SELECT CustID, [First Name], [Last Name], [Total Rented] FROM TopCustomers ORDER BY [Total Rented] DESC",
                    Connection))
            {
                objCommand.Parameters.AddWithValue("@CustID", TotalRented);
                Connection.Open();
                var reader = objCommand.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);
                Connection.Close();
            }

            return dt;
        }

        public DataTable FillDGVTopMoviesWithMostRentedMovies(string TotalTimesRented) //get best selling movies method
        {
            var dt = new DataTable();
            using (var objCommand =
                new SqlCommand("SELECT MovieID, [Movie Title], [Total Times Rented] FROM MostRentedMovies",
                    Connection))
            {
                objCommand.Parameters.AddWithValue("@MovieID", TotalTimesRented);
                Connection.Open();
                var reader = objCommand.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);
                reader.Close();
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
                    //Create a query and open a connection to SQL Server
                    using (var queryCommand = new SqlCommand(
                        "INSERT INTO Customer (FirstName, LastName, Address, Phone)" +
                        " VALUES (@FirstName, @LastName, @Address, @Phone)", Connection))
                    {
                        //use parameters to prevent SQL injections
                        queryCommand.Parameters.AddWithValue("@FirstName", FirstName);
                        queryCommand.Parameters.AddWithValue("@LastName", LastName);
                        queryCommand.Parameters.AddWithValue("@Address", Address);
                        queryCommand.Parameters.AddWithValue("@Phone", Phone);
                        //create and open DB Connection
                        Connection.Open();
                        // add in the SQL
                        queryCommand.ExecuteNonQuery();
                        Connection.Close();
                    }

                // update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                    //Create a object and open a connection to SQL Server
                    using (var objCommand = new SqlCommand("UPDATE Customer" +
                                                           " set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone " +
                                                           " where CustID = @CustID", Connection))
                    {
                        //use parameters to prevent SQL injections
                        objCommand.Parameters.AddWithValue("@FirstName", FirstName);
                        objCommand.Parameters.AddWithValue("@LastName", LastName);
                        objCommand.Parameters.AddWithValue("@Address", Address);
                        objCommand.Parameters.AddWithValue("@Phone", Phone);
                        objCommand.Parameters.AddWithValue("@CustID", CustID);
                        //create and open DB Connection
                        Connection.Open();
                        // add in the SQL
                        objCommand.ExecuteNonQuery();
                        Connection.Close();
                    }

                return AddOrUpdate + " is Successful";
            }
            catch (Exception e)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();
                return " has failed with " + e;
            }
        }

        public string DeleteCustomer(string CustID, string DeleteCust)
        {
            try
            {
                //Delete gets passed through the parameter
                if (DeleteCust == "Delete")
                {
                    //Create a object and open a connection to SQL Server
                    var queryCommand = new SqlCommand("DELETE FROM Customer" + " where CustID = @CustID", Connection);
                    //use parameters to prevent SQL injections
                    queryCommand.Parameters.AddWithValue("CustID", CustID);
                    //create and open DB Connection
                    Connection.Open();
                    queryCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return " Successfully Deleted";
            }
            catch (Exception e)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();
                return " Failed " + e;
            }
        }

        public string AddOrUpdateMovie(string MovieID, string Title, string Genre, string Year, string Rating,
            string Plot, string Copies, string AddOrUpdate)
        {
            try
            {
                var Rental_Cost = GetRentalCost(Year);

                //Add gets passed through the parameter
                if (AddOrUpdate == "Add")
                {
                    //Create a object and open a connection to SQL Server
                    // this puts the parameters into the code so that the data in the text boxes is added to the database
                    var queryCommand = new SqlCommand(
                        "INSERT INTO Movies (Title, Genre, Year, Rating, Plot, Copies, Rental_Cost) " +
                        "VALUES  (@Title, @Genre, @Year, @Rating, @Plot, @Copies, @Rental_Cost)", Connection);

                    //use parameters to prevent SQL injections
                    queryCommand.Parameters.AddWithValue("@Title", Title);
                    queryCommand.Parameters.AddWithValue("@Genre", Genre);
                    queryCommand.Parameters.AddWithValue("@Year", Year);
                    queryCommand.Parameters.AddWithValue("@Rating", Rating);
                    queryCommand.Parameters.AddWithValue("@Plot", Plot);
                    queryCommand.Parameters.AddWithValue("@Copies", Copies);
                    queryCommand.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                    //create and open DB Connection
                    Connection.Open();
                    queryCommand
                        .ExecuteNonQuery(); //use NonQuery as it doesn't return any data its only going up to the server
                    Connection.Close();
                }
                // Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    //Create a object and open a connection to SQL Server
                    // this puts the parameters into the code so that the data in the text boxes is added to thedatabase
                    var queryCommand =
                        new SqlCommand(
                            "UPDATE Movies" +
                            " set Title = @Title, Genre = @Genre, Year = @Year, Rating = @Rating, Plot = @Plot, Copies = @Copies, Rental_Cost = @Rental_Cost" +
                            " where MovieID = @MovieID", Connection);
                    //use parameters to prevent SQL injections
                    queryCommand.Parameters.AddWithValue("@Title", Title);
                    queryCommand.Parameters.AddWithValue("@Genre", Genre);
                    queryCommand.Parameters.AddWithValue("@Year", Year);
                    queryCommand.Parameters.AddWithValue("@Rating", Rating);
                    queryCommand.Parameters.AddWithValue("@Plot", Plot);
                    queryCommand.Parameters.AddWithValue("@Copies", Copies);
                    queryCommand.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                    queryCommand.Parameters.AddWithValue("@MovieID", MovieID);
                    //create and open DB Connection
                    Connection.Open();
                    queryCommand
                        .ExecuteNonQuery(); //use NonQuery as it doesn't return any data its only going up to the server
                    Connection.Close(); // close connection to DB
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
                    //Create a object and open a connection to SQL Server
                    // this puts the parameters into the code so that the data in the text boxes is added to thedatabase
                    using (var objCommand =
                        new SqlCommand("DELETE FROM Movies" + " where MovieID = @MovieID", Connection))
                    {
                        // create params to prevent SQL injections
                        objCommand.Parameters.AddWithValue("@MovieID", MovieID);
                        //create and open DB Connection
                        Connection.Open();
                        objCommand
                            .ExecuteNonQuery(); //use NonQuery as it doesn't return any data its only going up to the server
                        Connection.Close(); //close connection to DB
                    }

                return " Movie ID #" + MovieID + " Successfully Deleted";
            }
            catch (Exception e)
            {
                // need to get it to close a second time if it jumps the first connection.close
                Connection.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public string IssueMovie(string MovieID, string CustID, DateTime DateRented)
        {
            try
            {
                //Create a object and open a connection to SQL Server
                var query =
                    "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) VALUES (@MovieID, @CustID, @DateRented)";
                var queryCommand = new SqlCommand(query, Connection);
                // create params to prevent SQL injections
                queryCommand.Parameters.AddWithValue("@MovieID", MovieID);
                queryCommand.Parameters.AddWithValue("@CustID", CustID);
                queryCommand.Parameters.AddWithValue("@DateRented", DateRented);
                //create and open DB Connection
                Connection.Open();
                queryCommand
                    .ExecuteNonQuery(); //use NonQuery as it doesn't return any data its only going up to the server
                Connection.Close(); //close connection to the DB

                return " Movie Successfully Rented";
            }
            catch (Exception e)
            {
                // need to get it to close a second time if it jumps the first connection.close
                Connection.Close();
                return " failed " + e;
            }
        }

        public string ReturnMovie(string RMID, DateTime today)
        {
            try
            {
                Today = DateTime.Now;
                //Create a object and open a connection to SQL Server
                var query = "UPDATE RentedMovies" + " set DateReturned = @today" + " WHERE RMID = @RMID";
                var queryCommand = new SqlCommand(query, Connection);
                // create parameters to prevent SQL injections
                queryCommand.Parameters.AddWithValue("@RMID", RMID);
                queryCommand.Parameters.AddWithValue("@today", today);
                //create and open DB Connection
                Connection.Open();
                queryCommand
                    .ExecuteNonQuery(); //use NonQuery as it doesn't return any data its only going up to the server
                Connection.Close(); //close connection to DB

                return " Return is Successful";
            }
            catch (Exception e)
            {
                //need to get it to close a second time as it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();
                return "Return has Failed with " + e;
            }
        }

        public int GetRentalCost(string Year)
        {
            //Rental cost is $2 if the release year is more than 5 years ago
            //otherwise its $5
            int target = Convert.ToInt16(Year);
            int Rental_Cost;
            if (target > DateTime.Today.AddYears(-5).Year)
                Rental_Cost = 5;
            else
                Rental_Cost = 2;

            return Rental_Cost;
        }
    }
}