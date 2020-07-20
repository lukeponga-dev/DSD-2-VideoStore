using System;
using System.Windows.Forms;

namespace DSD_2_VideoStore
{
    public partial class Form1 : Form
    {
        private Database myDatabase = new Database();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DisplayDataGridViewCustomers();
            DisplayDataGridViewMovies();
            DisplayDataGridViewRentals();
        }

        private void DisplayDataGridViewCustomers()
        {
            //clear out old data.
            dgvCustomers.DataSource = null;
            try
            {
                dgvCustomers.DataSource = myDatabase.FillDGVCustomersWithCustomers();
                //pass the datatable data to the DataGridView
                dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewMovies()
        {
            //clear out old data.
            dgvMovies.DataSource = null;
            try
            {
                dgvMovies.DataSource = myDatabase.FillDGVMoviesWithMovies();
                //pass the datatable data to the DataGridView
                dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewRentals()
        {
            dvgRentals.DataSource = null;
            try
            {
                dvgRentals.DataSource = myDatabase.FillDGVRentalsWithCustomerAndMoviesRented();
                dvgRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void DisplayDataGridViewMoviesNOtReturned()
        {
            DGVNotReturned.DataSource = null;

            try
            {
                DGVNotReturned.DataSource = myDatabase.FillDGVNotReturnedwithMovieReturned();
                DGVNotReturned.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */

        /*private void DisplayDataGridViewTopCustomerView()
        {
            //DGVMoviesNotReturned.DataSource = null;
            try
            {
                DGVTopCustomers.DataSource = myDatabase.FillDGVTopCustomerswithTopCustomerView();
                DGVTopCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        /*private void DisplayDataGridViewTopMovieView()
        {
            DGVTopMovies.DataSource = null;
            try
            {
                DGVTopMovies.DataSource = myDatabase.FillDGVTopMovieswithTopMovieView();
                DGVTopMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        // sends data from datagridview to the textboxes
        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // the cell clicks for the values in the row that you click on
            try
            {
                myDatabase.CustID = (int)dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
                txtCustID.Text = myDatabase.CustID.ToString();
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
        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // the cell clicks for the values in the row that you click on
            try
            {
                myDatabase.MovieID = (int)dgvMovies.Rows[e.RowIndex].Cells[0].Value;
                txtMovieID.Text = myDatabase.MovieID.ToString();
                txtTitle.Text = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGenre.Text = dgvMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtYear.Text = dgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRating.Text = dgvMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPlot.Text = dgvMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCopies.Text = dgvMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtRentalPrice.Text = dgvMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Customers Add button
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.AddOrUpdateCustomer(txtCustID.Text, txtFirstName.Text, txtLastName.Text,
                txtAddress.Text, txtPhone.Text, btnAddCustomer.Text));

            tabControl1.SelectedIndex = 0;
            DisplayDataGridViewCustomers();
        }

        // Customers update button
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            myDatabase.AddOrUpdateCustomer(txtCustID.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text,
                txtPhone.Text, btnUpdateCustomer.Text);

            tabControl1.SelectedIndex = 0;
            DisplayDataGridViewCustomers();
        }

        // Customers delete button
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.DeleteCustomer(txtCustID.Text, btnDeleteCustomer.Text));
            tabControl1.SelectedIndex = 0;
            DisplayDataGridViewCustomers();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.AddOrUpdateMovie(txtMovieID.Text, txtTitle.Text, txtGenre.Text, txtYear.Text, txtRating.Text, txtPlot.Text, txtCopies.Text, txtRentalPrice.Text, btnAddMovie.Text));
            tabControl1.SelectedIndex = 1;
            DisplayDataGridViewMovies();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.DeleteMovies(txtMovieID.Text, btnDeleteCustomer.Text));
            tabControl1.SelectedIndex = 1;
            DisplayDataGridViewMovies();
        }
    }
}