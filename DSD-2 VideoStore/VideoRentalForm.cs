using System;
using System.Windows.Forms;

namespace DSD_2_VideoStore
{
    //TODO Add fees for the videos, if videos are older than 5 years (Release Date) then they cost $2 otherwise they cost $5
    //TODO  View best Customers and Top movies

    public partial class VideoRentalForm : Form
    {
        //create an instance of the Database Class
        private readonly Database myDatabase = new Database();

        public VideoRentalForm()
        {
            InitializeComponent();
            LoadData(); // Load the DGV
        }

        private void LoadData()
        {
            //load datatable columns
            DisplayDataGridViewCustomers();
            DisplayDataGridViewMovies();
            DisplayDataGridViewRentals();
            DisplayDataGridViewTopCustomer();
            DisplayDataGridViewBestMovie();
        }

        private void DisplayDataGridViewTopCustomer()
        {
            dgvTopCustomer.DataSource = null; //Clear out all old data
            dgvTopCustomer.DataSource = myDatabase.FillDGVTopCustomersWithTopCustomers(myDatabase.CustID.ToString())
                .DefaultView;
            //pass the datatable date to the DataGridView
            dgvTopCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void DisplayDataGridViewBestMovie()
        {
            dgvTopMovies.DataSource = null; //clear out old data.
            dgvTopMovies.DataSource = myDatabase.FillDGVTopMoviesWithMostRentedMovies(myDatabase.MovieID.ToString())
                .DefaultView;
            //pass the datatable data to the DataGridView
            dgvTopMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DisplayDataGridViewCustomers()
        {
            dgvCustomers.DataSource = null; //clear out old data.
            dgvCustomers.DataSource =
                    myDatabase.FillDGVCustomersWithCustomers().DefaultView; //pass the datatable data to the DataGridView
            dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void DisplayDataGridViewMovies()
        {
            dgvMovies.DataSource = null; // clear out old data.
            dgvMovies.DataSource =
                    myDatabase.FillDGVMoviesWithMovies().DefaultView; // pass the datatable data to the DataGridView

            dgvMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void DisplayDataGridViewRentals()
        {
            dgvRentals.DataSource = null; // clear out old data.
            dgvRentals.DataSource = myDatabase.FillDGVRentalsWithCustomerAndMoviesRented().DefaultView; // pass the datatable data to the DataGridView
            dgvRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void rbAllRented_CheckedChanged(object sender, EventArgs e)
        {
            // If radio button all rented is checked return movies not returned
            LoadData();
        }

        private void rbOutCurrently_CheckedChanged(object sender, EventArgs e)
        {
            // If radio button out currently is checked return movies not returned
            dgvRentals.DataSource = myDatabase.DisplayDGVRentalsOutRentals("%").DefaultView;
        }

        // sends data from datagridview to the textboxes
        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // the cell clicks for the values in the row that you click on
            try
            {
                myDatabase.CustID = (int)dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
                lblCustID.Text = myDatabase.CustID.ToString();
                txtFirstName.Text = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dgvCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // sends data from datagridview to the textboxes
        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // the cell clicks for the values in the row that you click on
            try
            {
                //NOTE I have changed the default table cell column positions to: Title =1, Genre =2, Rating =3, Year =4, Plot =5, Rental_Cost =6, Copies =7
                myDatabase.MovieID = (int)dgvMovies.Rows[e.RowIndex].Cells[0].Value;
                lblMovieID.Text = myDatabase.MovieID.ToString();
                txtTitle.Text = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGenre.Text = dgvMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtYear.Text = dgvMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtRating.Text = dgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPlot.Text = dgvMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCopies.Text = dgvMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtRentalPrice.Text = dgvMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                int thisYear = Convert.ToInt16(DateTime.Now.Date.Year);
                var year = Convert.ToInt32(txtYear.Text);
                var fee = myDatabase.FeeCalculation(year, thisYear).ToString();
                txtRentalPrice.Text = fee + @" .0000";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Sends data from data grid view to label
        private void dgvRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                myDatabase.RMID = (int)dgvRentals.Rows[e.RowIndex].Cells[0].Value;
                lblRMID.Text = myDatabase.RMID.ToString();
                lblDate.Text = dgvRentals.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblDateReturned.Text = dgvRentals.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Customers Add button
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != string.Empty &&
                txtLastName.Text != string.Empty && txtAddress.Text != string.Empty && txtPhone.Text != string.Empty)
            {
                MessageBox.Show(myDatabase.AddOrUpdateCustomer(lblCustID.Text, txtFirstName.Text,
                    txtLastName.Text, txtAddress.Text, txtPhone.Text, btnAddCustomer.Text));
                tabRentalSystem.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(@"Fill in Customer data!!");
            }

            LoadData();
        }

        // Customers update button
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.AddOrUpdateCustomer(lblCustID.Text, txtFirstName.Text,
                txtLastName.Text, txtAddress.Text, txtPhone.Text, btnUpdateCustomer.Text));
            tabRentalSystem.SelectedIndex = 0;
            LoadData();
        }

        // Customers delete button
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.DeleteCustomer(lblCustID.Text, btnDeleteCustomer.Text));
            tabRentalSystem.SelectedIndex = 0;
            LoadData();
        }

        // Movies add button
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.AddOrUpdateMovie(lblMovieID.Text, txtTitle.Text, txtGenre.Text,
                txtYear.Text, txtRating.Text, txtPlot.Text, txtCopies.Text, txtRentalPrice.Text,
                btnAddMovie.Text));
            tabRentalSystem.SelectedIndex = 1;
            LoadData();
        }

        // movies update button
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.AddOrUpdateMovie(lblMovieID.Text, txtTitle.Text, txtGenre.Text,
                txtYear.Text, txtRating.Text, txtPlot.Text, txtCopies.Text, txtRentalPrice.Text,
                btnUpdateMovie.Text));
            tabRentalSystem.SelectedIndex = 1;
            LoadData();
        }

        // movies delete button
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.DeleteMovies(lblMovieID.Text, btnDeleteCustomer.Text));
            tabRentalSystem.SelectedIndex = 1;
            LoadData();
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            if (lblCustID.Text != @"0" && lblMovieID.Text != @"0")

            {
                myDatabase.Today = DateTime.Now;
                MessageBox.Show(txtFirstName.Text + "" + txtLastName.Text + @" Date: " + myDatabase.Today + @" " +
                                myDatabase.IssueMovie(lblMovieID.Text, lblCustID.Text, myDatabase.Today));

                tabRentalSystem.SelectedIndex = 2;
                LoadData();
            }
            else
            {
                MessageBox.Show(@"Please select a customer and movie");
            }

            LoadData();
            //reset customer fields
            lblCustID.Text = @"0";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";

            //reset movie fields
            lblMovieID.Text = @"0";
            txtTitle.Text = "";
            txtGenre.Text = "";
            txtYear.Text = "";
            txtRating.Text = "";
            txtPlot.Text = "";
            txtCopies.Text = "";
            txtRentalPrice.Text = "";
        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            if (lblDateReturned.Text == string.Empty && lblRMID.Text != @"0")
                MessageBox.Show(@"Rental Id: " + lblRMID.Text + "" + myDatabase.ReturnMovie(lblRMID.Text));
            else
                MessageBox.Show(@"Fail");
            LoadData();
            lblRMID.Text = @"0";
        }

        private void dgvTopCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvTopMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}