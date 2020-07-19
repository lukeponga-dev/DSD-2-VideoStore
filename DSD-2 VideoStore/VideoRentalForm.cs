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
        public VideoRentalForm()
        {
            InitializeComponent();
            LoadData("");
            
        }



        private void LoadData(string Keyword)
        {
            // TODO
        }

        private void VideoRentalForm_Load(object sender, EventArgs e)
        {
            dgvCustomers.CellClick += dgvCustomers_SelectionChanged;

        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            // TODO
        }
    }
}