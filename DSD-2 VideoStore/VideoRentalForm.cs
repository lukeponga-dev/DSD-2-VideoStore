using System;
using System.Windows.Forms;

namespace DSD_2_VideoStore
{
    //TODO 	Form features
    // 1.1	DataGridView or ListView(or both) DONE
    // 1.2	Data entry text boxes or list boxes, and labels DONE
    // 1.3	Buttons or Radio buttons or any other clickable event to manipulate data
    // 1.4	Adequate signage and titles to make it easy to understand.
    //TODO 	Form Operations
    // 2.1	Insert a new record.Update existing records, Delete records(CRUD operations)
    // 2.2	Show all videos
    // 2.3	Show just the videos that are out at present.
    // 2.4	Add fees for the videos, if videos are older than 5 years (Release Date) then they cost $2 otherwise they cost $5
    // 2.5	Use a Database class to hold your SQL calls
    // 2.6	Issue, Charge and Return Movies
    // 2.7	List who borrows the most videos and List what are the most popular videos
    // 2.8	Create Two Unit Tests, one to test the Connection to the DB and the other of your choice.
    // 2.9	Sanitize all your Database Changes to prevent SQL Injection
    // 2.10	Use at least one Procedure
    // 2.11	Use at least one View to return data.
    // 2,12	Host the Project on GitHub and send me the link
    //TODO 	Database Operations
    // 3.1	Tables and relationships Created and filled with data

    public partial class VideoRentalForm : Form
    {
        private readonly Database myDatabase = new Database();

        public VideoRentalForm()
        {
            InitializeComponent();

            LoadData();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var CustID = 0;
            //these are the cell clicks for the values in the row that you click on

            CustID = (int)dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
            txtFirstName.Text = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhone.Text = dgvCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (e.RowIndex >= 0) txtCustID.Text = CustID.ToString();
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // displays movie information in textboxes when a cell is clicked
            myDatabase.MovieID = Convert.ToInt32(dgvMovies.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtMovieID.Text = myDatabase.MovieID.ToString();
            txtRating.Text = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTitle.Text = dgvMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtYear.Text = dgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCopies.Text = dgvMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPlot.Text = dgvMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtGenre.Text = dgvMovies.Rows[e.RowIndex].Cells[7].Value.ToString();

            myDatabase.MovieReleaseYear = dgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = myDatabase.RentalCost().ToString();
            //txtRentalCost.Text = dgvMovies.Rows[e.RowIndex].Cells[4].Value.ToString();

            //           txtRentalsMovieTitle.Text = dgvMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void DisplayDataGridViewCustomers()
        {
            //clear out the old data
            dgvCustomers.DataSource = null;
            try
            {
                dgvCustomers.DataSource = myDatabase.FillDGVCustomersWithCustomers();
                //pass the datatable data to the DataGridView
                dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewMovies()
        {
            dgvMovies.DataSource = null;
            try
            {
                dgvMovies.DataSource = myDatabase.FillDGVMoviesWithMovies();
                //pass the datatable data to the DataGridView
                dgvMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            DisplayDataGridViewCustomers();
            DisplayDataGridViewMovies();
        }
    }
}