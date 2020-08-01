using System;

namespace DSD_2_VideoStore
{
    partial class VideoRentalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabRentalSystem = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.Movies = new System.Windows.Forms.TabPage();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.Rentals = new System.Windows.Forms.TabPage();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.TopCust_Movies = new System.Windows.Forms.TabPage();
            this.dgvTopMovies = new System.Windows.Forms.DataGridView();
            this.dgvTopCustomer = new System.Windows.Forms.DataGridView();
            this.lblRMID = new System.Windows.Forms.Label();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMovie = new System.Windows.Forms.GroupBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.lblRentalPrice = new System.Windows.Forms.Label();
            this.lblIDTitle = new System.Windows.Forms.Label();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.rbAllRented = new System.Windows.Forms.RadioButton();
            this.rbOutCurrently = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabRentalSystem.SuspendLayout();
            this.Customers.SuspendLayout();
            this.Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.Rentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.TopCust_Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomer)).BeginInit();
            this.gbMovie.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 6);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(813, 336);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // tabRentalSystem
            // 
            this.tabRentalSystem.Controls.Add(this.Customers);
            this.tabRentalSystem.Controls.Add(this.Movies);
            this.tabRentalSystem.Controls.Add(this.Rentals);
            this.tabRentalSystem.Controls.Add(this.TopCust_Movies);
            this.tabRentalSystem.Location = new System.Drawing.Point(367, 57);
            this.tabRentalSystem.Name = "tabRentalSystem";
            this.tabRentalSystem.SelectedIndex = 0;
            this.tabRentalSystem.Size = new System.Drawing.Size(833, 374);
            this.tabRentalSystem.TabIndex = 1;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.dgvCustomers);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(825, 348);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.dgvMovies);
            this.Movies.Location = new System.Drawing.Point(4, 22);
            this.Movies.Name = "Movies";
            this.Movies.Padding = new System.Windows.Forms.Padding(3);
            this.Movies.Size = new System.Drawing.Size(825, 348);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = true;
            // 
            // dgvMovies
            // 
            this.dgvMovies.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(7, 6);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(812, 336);
            this.dgvMovies.TabIndex = 1;
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            // 
            // Rentals
            // 
            this.Rentals.Controls.Add(this.dgvRentals);
            this.Rentals.Location = new System.Drawing.Point(4, 22);
            this.Rentals.Name = "Rentals";
            this.Rentals.Size = new System.Drawing.Size(825, 348);
            this.Rentals.TabIndex = 2;
            this.Rentals.Text = "Rentals";
            this.Rentals.UseVisualStyleBackColor = true;
            // 
            // dgvRentals
            // 
            this.dgvRentals.BackgroundColor = System.Drawing.Color.White;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(6, 6);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.Size = new System.Drawing.Size(816, 339);
            this.dgvRentals.TabIndex = 2;
            this.dgvRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentals_CellContentClick);
            // 
            // TopCust_Movies
            // 
            this.TopCust_Movies.Controls.Add(this.label14);
            this.TopCust_Movies.Controls.Add(this.label12);
            this.TopCust_Movies.Controls.Add(this.dgvTopMovies);
            this.TopCust_Movies.Controls.Add(this.dgvTopCustomer);
            this.TopCust_Movies.Location = new System.Drawing.Point(4, 22);
            this.TopCust_Movies.Name = "TopCust_Movies";
            this.TopCust_Movies.Size = new System.Drawing.Size(825, 348);
            this.TopCust_Movies.TabIndex = 3;
            this.TopCust_Movies.Text = "TopCustomer/BestMovies";
            this.TopCust_Movies.UseVisualStyleBackColor = true;
            // 
            // dgvTopMovies
            // 
            this.dgvTopMovies.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopMovies.Location = new System.Drawing.Point(407, 43);
            this.dgvTopMovies.Name = "dgvTopMovies";
            this.dgvTopMovies.Size = new System.Drawing.Size(401, 284);
            this.dgvTopMovies.TabIndex = 2;
            // 
            // dgvTopCustomer
            // 
            this.dgvTopCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopCustomer.Location = new System.Drawing.Point(16, 42);
            this.dgvTopCustomer.Name = "dgvTopCustomer";
            this.dgvTopCustomer.Size = new System.Drawing.Size(355, 285);
            this.dgvTopCustomer.TabIndex = 1;
            // 
            // lblRMID
            // 
            this.lblRMID.AutoSize = true;
            this.lblRMID.BackColor = System.Drawing.Color.Transparent;
            this.lblRMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRMID.Location = new System.Drawing.Point(155, 27);
            this.lblRMID.Name = "lblRMID";
            this.lblRMID.Size = new System.Drawing.Size(17, 17);
            this.lblRMID.TabIndex = 36;
            this.lblRMID.Text = "0";
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReturnMovie.Location = new System.Drawing.Point(97, 55);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(75, 53);
            this.btnReturnMovie.TabIndex = 36;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIssueMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Red;
            this.btnIssueMovie.Location = new System.Drawing.Point(10, 55);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(81, 53);
            this.btnIssueMovie.TabIndex = 36;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(31, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(114, 21);
            this.txtFirstName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(31, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(114, 21);
            this.txtLastName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(31, 142);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 21);
            this.txtAddress.TabIndex = 23;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(31, 183);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(129, 21);
            this.txtPhone.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Last Name:";
            // 
            // gbMovie
            // 
            this.gbMovie.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gbMovie.Controls.Add(this.lblMovieID);
            this.gbMovie.Controls.Add(this.label6);
            this.gbMovie.Controls.Add(this.txtCopies);
            this.gbMovie.Controls.Add(this.lblRentalPrice);
            this.gbMovie.Controls.Add(this.lblIDTitle);
            this.gbMovie.Controls.Add(this.txtRentalPrice);
            this.gbMovie.Controls.Add(this.btnDeleteMovie);
            this.gbMovie.Controls.Add(this.label11);
            this.gbMovie.Controls.Add(this.btnUpdateMovie);
            this.gbMovie.Controls.Add(this.txtRating);
            this.gbMovie.Controls.Add(this.label9);
            this.gbMovie.Controls.Add(this.lblGenre);
            this.gbMovie.Controls.Add(this.lblPlot);
            this.gbMovie.Controls.Add(this.btnAddMovie);
            this.gbMovie.Controls.Add(this.lblTitle);
            this.gbMovie.Controls.Add(this.txtYear);
            this.gbMovie.Controls.Add(this.txtTitle);
            this.gbMovie.Controls.Add(this.txtGenre);
            this.gbMovie.Controls.Add(this.txtPlot);
            this.gbMovie.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovie.ForeColor = System.Drawing.Color.Black;
            this.gbMovie.Location = new System.Drawing.Point(12, 308);
            this.gbMovie.Name = "gbMovie";
            this.gbMovie.Size = new System.Drawing.Size(338, 351);
            this.gbMovie.TabIndex = 33;
            this.gbMovie.TabStop = false;
            this.gbMovie.Text = "Movie Details";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.BackColor = System.Drawing.Color.Transparent;
            this.lblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMovieID.Location = new System.Drawing.Point(82, 27);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(17, 17);
            this.lblMovieID.TabIndex = 35;
            this.lblMovieID.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(141, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Copies Rented:";
            // 
            // txtCopies
            // 
            this.txtCopies.BackColor = System.Drawing.Color.White;
            this.txtCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopies.ForeColor = System.Drawing.Color.Black;
            this.txtCopies.Location = new System.Drawing.Point(252, 54);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(53, 21);
            this.txtCopies.TabIndex = 33;
            // 
            // lblRentalPrice
            // 
            this.lblRentalPrice.AutoSize = true;
            this.lblRentalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRentalPrice.Location = new System.Drawing.Point(149, 27);
            this.lblRentalPrice.Name = "lblRentalPrice";
            this.lblRentalPrice.Size = new System.Drawing.Size(97, 17);
            this.lblRentalPrice.TabIndex = 32;
            this.lblRentalPrice.Text = "Rental Price $";
            // 
            // lblIDTitle
            // 
            this.lblIDTitle.AutoSize = true;
            this.lblIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIDTitle.Location = new System.Drawing.Point(6, 27);
            this.lblIDTitle.Name = "lblIDTitle";
            this.lblIDTitle.Size = new System.Drawing.Size(75, 17);
            this.lblIDTitle.TabIndex = 31;
            this.lblIDTitle.Text = "Movie ID:";
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.BackColor = System.Drawing.Color.White;
            this.txtRentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPrice.Location = new System.Drawing.Point(252, 24);
            this.txtRentalPrice.Multiline = true;
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.ReadOnly = true;
            this.txtRentalPrice.Size = new System.Drawing.Size(53, 24);
            this.txtRentalPrice.TabIndex = 29;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(188, 233);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(139, 35);
            this.btnDeleteMovie.TabIndex = 27;
            this.btnDeleteMovie.Text = "Delete";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Rating (PG, R, M. etc):";
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(188, 192);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(139, 35);
            this.btnUpdateMovie.TabIndex = 25;
            this.btnUpdateMovie.Text = "Update";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.Color.White;
            this.txtRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRating.ForeColor = System.Drawing.Color.Black;
            this.txtRating.Location = new System.Drawing.Point(27, 173);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(139, 21);
            this.txtRating.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Year:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGenre.Location = new System.Drawing.Point(6, 101);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(52, 17);
            this.lblGenre.TabIndex = 19;
            this.lblGenre.Text = "Genre:";
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.BackColor = System.Drawing.Color.Transparent;
            this.lblPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlot.Location = new System.Drawing.Point(11, 246);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(36, 17);
            this.lblPlot.TabIndex = 18;
            this.lblPlot.Text = "Plot:";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(188, 151);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(139, 36);
            this.btnAddMovie.TabIndex = 16;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(6, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Title:";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.Location = new System.Drawing.Point(27, 217);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(90, 21);
            this.txtYear.TabIndex = 24;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(27, 74);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(178, 24);
            this.txtTitle.TabIndex = 21;
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.White;
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.ForeColor = System.Drawing.Color.Black;
            this.txtGenre.Location = new System.Drawing.Point(21, 123);
            this.txtGenre.Multiline = true;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(184, 22);
            this.txtGenre.TabIndex = 23;
            // 
            // txtPlot
            // 
            this.txtPlot.BackColor = System.Drawing.Color.White;
            this.txtPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlot.ForeColor = System.Drawing.Color.Black;
            this.txtPlot.Location = new System.Drawing.Point(14, 270);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPlot.Size = new System.Drawing.Size(225, 68);
            this.txtPlot.TabIndex = 22;
            // 
            // gbCustomer
            // 
            this.gbCustomer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gbCustomer.Controls.Add(this.lblCustID);
            this.gbCustomer.Controls.Add(this.label8);
            this.gbCustomer.Controls.Add(this.btnDeleteCustomer);
            this.gbCustomer.Controls.Add(this.btnUpdateCustomer);
            this.gbCustomer.Controls.Add(this.btnAddCustomer);
            this.gbCustomer.Controls.Add(this.txtLastName);
            this.gbCustomer.Controls.Add(this.label1);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Controls.Add(this.txtAddress);
            this.gbCustomer.Controls.Add(this.label4);
            this.gbCustomer.Controls.Add(this.txtFirstName);
            this.gbCustomer.Controls.Add(this.txtPhone);
            this.gbCustomer.Controls.Add(this.label2);
            this.gbCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.ForeColor = System.Drawing.Color.Black;
            this.gbCustomer.Location = new System.Drawing.Point(12, 79);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(339, 223);
            this.gbCustomer.TabIndex = 34;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Details";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCustID.Location = new System.Drawing.Point(82, 23);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(17, 17);
            this.lblCustID.TabIndex = 37;
            this.lblCustID.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(11, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Cust ID:";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(188, 169);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(126, 35);
            this.btnDeleteCustomer.TabIndex = 35;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(188, 128);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(126, 35);
            this.btnUpdateCustomer.TabIndex = 34;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(188, 87);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(126, 35);
            this.btnAddCustomer.TabIndex = 33;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblFormTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 51);
            this.panel1.TabIndex = 35;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(33, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(344, 32);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Video / Movie rental system ";
            // 
            // rbAllRented
            // 
            this.rbAllRented.AutoSize = true;
            this.rbAllRented.Checked = true;
            this.rbAllRented.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllRented.Location = new System.Drawing.Point(198, 54);
            this.rbAllRented.Name = "rbAllRented";
            this.rbAllRented.Size = new System.Drawing.Size(79, 17);
            this.rbAllRented.TabIndex = 0;
            this.rbAllRented.TabStop = true;
            this.rbAllRented.Text = "All Rented";
            this.rbAllRented.UseVisualStyleBackColor = true;
            this.rbAllRented.CheckedChanged += new System.EventHandler(this.rbAllRented_CheckedChanged);
            // 
            // rbOutCurrently
            // 
            this.rbOutCurrently.AutoSize = true;
            this.rbOutCurrently.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutCurrently.Location = new System.Drawing.Point(199, 78);
            this.rbOutCurrently.Name = "rbOutCurrently";
            this.rbOutCurrently.Size = new System.Drawing.Size(95, 17);
            this.rbOutCurrently.TabIndex = 1;
            this.rbOutCurrently.Text = "Out Currently";
            this.rbOutCurrently.UseVisualStyleBackColor = true;
            this.rbOutCurrently.CheckedChanged += new System.EventHandler(this.rbOutCurrently_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblDateReturned);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblRMID);
            this.groupBox2.Controls.Add(this.rbAllRented);
            this.groupBox2.Controls.Add(this.rbOutCurrently);
            this.groupBox2.Controls.Add(this.btnReturnMovie);
            this.groupBox2.Controls.Add(this.btnIssueMovie);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(367, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 159);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rented Movies";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 14);
            this.label10.TabIndex = 38;
            this.label10.Text = "Date Rented:";
            this.label10.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(119, 111);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 14);
            this.lblDate.TabIndex = 37;
            this.lblDate.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 14);
            this.label7.TabIndex = 37;
            this.label7.Text = "Date Returned:";
            this.label7.Visible = false;
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.BackColor = System.Drawing.Color.Transparent;
            this.lblDateReturned.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateReturned.Location = new System.Drawing.Point(119, 127);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(0, 14);
            this.lblDateReturned.TabIndex = 36;
            this.lblDateReturned.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(17, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Rented Movie ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(196, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "Filter Movies:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(138, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Top Customers:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(577, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Top Movies:";
            // 
            // VideoRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1212, 677);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.gbMovie);
            this.Controls.Add(this.tabRentalSystem);
            this.Name = "VideoRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoRentalForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabRentalSystem.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.Movies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.Rentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.TopCust_Movies.ResumeLayout(false);
            this.TopCust_Movies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomer)).EndInit();
            this.gbMovie.ResumeLayout(false);
            this.gbMovie.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TabControl tabRentalSystem;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.TabPage Movies;
        private System.Windows.Forms.TabPage Rentals;
        private System.Windows.Forms.TabPage TopCust_Movies;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.Label lblRentalPrice;
        private System.Windows.Forms.Label lblIDTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.RadioButton rbAllRented;
        private System.Windows.Forms.RadioButton rbOutCurrently;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRMID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvTopMovies;
        private System.Windows.Forms.DataGridView dgvTopCustomer;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}