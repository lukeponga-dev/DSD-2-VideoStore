using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DSD_2_VideoStore
{
    public class Database
    {
        private readonly SqlCommand Command = new SqlCommand();

        //Create a Connection, Command, and an Adapter
        private readonly SqlConnection Connection = new SqlConnection(); // connect to db

        private SqlDataAdapter da = new SqlDataAdapter(); // hold the results

        // constructor sets the default upon loading the class
        public Database()
        {
            //Data Source=DESKTOP-BOJJVGV\SQLDB;Initial Catalog=VideoRental;Integrated Security=True;
            //change the connection string to your db
            var connectionString =
                @"Data Source=DESKTOP-BOJJVGV\SQLDB;Initial Catalog=VideoRental;Integrated Security=True;";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }

        public int CustID { get; set; }
        public int MovieID { get; set; }
        public int RMID { get; set; }
        public DateTime Today { get; set; }

        //Takes all data from Customers
        public DataTable FillDGVCustomersWithCustomers()
        {
            //create data-table
            var dt = new DataTable();
            try
            {
                using (da = new SqlDataAdapter("select * from Customer", Connection))
                {
                    //connect into DB and get the SQL
                    Connection.Open(); //open a connection to the B
                    da.Fill(dt); //fill the data-table from the SQL
                    Connection.Close(); //close the connection
                }
            }
            catch (Exception ex)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteReader fails.
                Connection.Close();
                MessageBox.Show(ex.Message);
            }

            return dt; //pass the datatable data to the DataGridView
        }

        //Takes all data from Movies
        public DataTable FillDGVMoviesWithMovies()
        {
            //create data-table
            var dt = new DataTable();
            try
            {
                using (da = new SqlDataAdapter("select * from Movies", Connection))
                {
                    //connect into DB and get the SQL
                    Connection.Open(); //open a connection to the B
                    da.Fill(dt); //fill the data-table from the SQL
                    Connection.Close(); //close the connection
                }
            }
            catch (Exception ex)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteReader fails.
                Connection.Close();
                MessageBox.Show(ex.Message);
            }
            return dt; //pass the data-table data to the DataGridView
        }

        //Takes all data from Rented Movies
        public DataTable FillDGVRentalsWithCustomerAndMoviesRented()
        {
            //create data-table
            var dt = new DataTable();
            try
            {
                using (da = new SqlDataAdapter("select * from RentedMovies Order by RMID", Connection))
                {
                    //connect into DB and get the SQL
                    Connection.Open(); //open a connection to the B
                    da.Fill(dt); //fill the data-table from the SQL
                    Connection.Close(); //close the connection
                }
            }
            catch (Exception ex)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteReader fails.
                Connection.Close();
                MessageBox.Show(ex.Message);
            }
            return dt; //pass the data-table data to the DataGridView
        }

        public DataTable DisplayDGVRentalsOutRentals(string Rentals)
        {
            var dt = new DataTable();
            try
            {
                using (var objCommand = new SqlCommand("select RMID, MovieIDFK, CustIDFK, DateRented, DateReturned from CustomersAndMoviesRented where DateReturned is null", Connection))
                {
                    objCommand.Parameters.AddWithValue("@RMID", Rentals);
                    //connect to DB and get SQL
                    Connection.Open();
                    var reader = objCommand.ExecuteReader();
                    if (reader.HasRows) dt.Load(reader);
                    reader.Close();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteReader fails.
                Connection.Close();
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        //Fill TopCustomers with TopCustomers View method
        public DataTable FillDGVTopCustomersWithTopCustomers(string TotalRented)
        {
            var dt = new DataTable();
            try
            {
                using (var objCommand = new SqlCommand("SELECT CustID, [First Name], [Last Name], [Total Rented] FROM TopCustomers ORDER BY [Total Rented] DESC", Connection))
                {
                    objCommand.Parameters.AddWithValue("@CustID", TotalRented);
                    Connection.Open();
                    var reader = objCommand.ExecuteReader();
                    if (reader.HasRows) dt.Load(reader);
                    reader.Close();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteReader fails.
                Connection.Close();
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable FillDGVTopMoviesWithMostRentedMovies(string TotalTimesRented) //get best selling movies method
        {
            // string Query = "SELECT MovieID, Title, ISNULL((SELECT COUNT (RMID) FROM RentedMovies
            // WHERE MovieIDFK = MovieID), 0) AS TimesRented FROM Movies ORDER BY TimesRented DESC";
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand objCommand =
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
            }
            catch (Exception ex)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteReader fails.
                Connection.Close();
                MessageBox.Show(ex.Message);
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
                    //Create a object and open a connection to SQL Server
                    var query =
                        "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES (@FirstName, @LastName, @Address, @Phone)";

                    using (var objCommand = new SqlCommand(query, Connection))
                    {
                        //use parameters to prevent SQL injections
                        objCommand.Parameters.AddWithValue("@FirstName", FirstName);
                        objCommand.Parameters.AddWithValue("@LastName", LastName);
                        objCommand.Parameters.AddWithValue("@Address", Address);
                        objCommand.Parameters.AddWithValue("@Phone", Phone);
                        //create and open DB Connection
                        Connection.Open();
                        // add in the SQL
                        objCommand.ExecuteNonQuery();
                        Connection.Close();
                    }
                }

                // update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    //Create a object and open a connection to SQL Server
                    var query =
                        "UPDATE Customer set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone  where CustID = @CustID";
                    using (var objCommand = new SqlCommand(query, Connection))
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
                    var query = "DELETE FROM Customer where CustID = @CustID";
                    var objCommand = new SqlCommand(query, Connection);
                    //use parameters to prevent SQL injections
                    objCommand.Parameters.AddWithValue("CustID", CustID);
                    //create and open DB Connection
                    Connection.Open();
                    objCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return "Customer ID #" + CustID + " Successfully Deleted";
            }
            catch (Exception e)
            {
                //need to get it to close a second time it jumps the first connection.close if ExecuteNonQuery fails.
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
                    //Create a object and open a connection to SQL Server
                    // this puts the parameters into the code so that the data in the text boxes is added to thedatabase
                    var query = "INSERT INTO Movies (Title, Genre, Year, Rating, Plot, Copies, Rental_Cost) " +
                                "VALUES  (@Title, @Genre, @Year, @Rating, @Plot, @Copies, @Rental_Cost)";
                    var objCommand = new SqlCommand(query, Connection);
                    //use parameters to prevent SQL injections
                    objCommand.Parameters.AddWithValue("@Title", Title);
                    objCommand.Parameters.AddWithValue("@Genre", Genre);
                    objCommand.Parameters.AddWithValue("@Year", Year);
                    objCommand.Parameters.AddWithValue("@Rating", Rating);
                    objCommand.Parameters.AddWithValue("@Plot", Plot);
                    objCommand.Parameters.AddWithValue("@Copies", Copies);
                    objCommand.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                    //create and open DB Connection
                    Connection.Open();
                    objCommand
                        .ExecuteNonQuery(); //use NonQuery as it doesn't return any data its only going up to the server
                    Connection.Close();
                }
                // Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    //Create a object and open a connection to SQL Server
                    // this puts the parameters into the code so that the data in the text boxes is added to thedatabase
                    var query =
                        "UPDATE Movies set Title = @Title, Genre = @Genre, Year = @Year, Rating = @Rating, Plot = @Plot, Copies = @Copies, Rental_Cost = @Rental_Cost where MovieID = @MovieID";
                    var objCommand = new SqlCommand(query, Connection);
                    //use parameters to prevent SQL injections
                    objCommand.Parameters.AddWithValue("@Title", Title);
                    objCommand.Parameters.AddWithValue("@Genre", Genre);
                    objCommand.Parameters.AddWithValue("@Year", Year);
                    objCommand.Parameters.AddWithValue("@Rating", Rating);
                    objCommand.Parameters.AddWithValue("@Plot", Plot);
                    objCommand.Parameters.AddWithValue("@Copies", Copies);
                    objCommand.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                    objCommand.Parameters.AddWithValue("@MovieID", MovieID);
                    //create and open DB Connection
                    Connection.Open();
                    objCommand
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
                {
                    //Create a object and open a connection to SQL Server
                    // this puts the parameters into the code so that the data in the text boxes is added to thedatabase
                    using (SqlCommand objCommand = new SqlCommand("DELETE FROM Movies where MovieID = @MovieID", Connection))
                    {
                        // create params to prevent SQL injections
                        objCommand.Parameters.AddWithValue("@MovieID", MovieID);
                        //create and open DB Connection
                        Connection.Open();
                        objCommand.ExecuteNonQuery(); //use NonQuery as it doesn't return any data its only going up to the server
                        Connection.Close(); //close connection to DB
                    }
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
                var objCommand = new SqlCommand(query, Connection);
                // create params to prevent SQL injections
                objCommand.Parameters.AddWithValue("@MovieID", MovieID);
                objCommand.Parameters.AddWithValue("@CustID", CustID);
                objCommand.Parameters.AddWithValue("@DateRented", DateRented);
                //create and open DB Connection
                Connection.Open();
                objCommand
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

        public string ReturnMovie(string ID)
        {
            try
            {
                Today = DateTime.Now;
                //Create a object and open a connection to SQL Server
                var query = "UPDATE RentedMovies set DateReturned = @Today WHERE RMID = @ID";
                var objCommand = new SqlCommand(query, Connection);
                // create parameters to prevent SQL injections
                objCommand.Parameters.AddWithValue("Today", Today);
                objCommand.Parameters.AddWithValue("ID", ID);
                //create and open DB Connection
                Connection.Open();
                objCommand
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

        //Calculate fee based on age of movie
        public int FeeCalculation(int year, int thisYear)
        {
            var difference = thisYear - year;

            if (difference > 5)
                return 2;
            else if (difference < 5)
            {
                return 5;
            }

            return difference;
        }
    }
}