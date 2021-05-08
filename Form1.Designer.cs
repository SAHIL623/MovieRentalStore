namespace MovieRentalStore
{
    partial class Form1
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnCustomerCreate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnMovieUpdate = new System.Windows.Forms.Button();
            this.btnMovieDelete = new System.Windows.Forms.Button();
            this.btnMovieCreate = new System.Windows.Forms.Button();
            this.lblMovieRentalCost = new System.Windows.Forms.Label();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.txtMovieRentalCost = new System.Windows.Forms.TextBox();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblMovieRating = new System.Windows.Forms.Label();
            this.txtMovieRating = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieGenre = new System.Windows.Forms.Label();
            this.lblMoviePlot = new System.Windows.Forms.Label();
            this.lblMovieCopies = new System.Windows.Forms.Label();
            this.txtMovieGenre = new System.Windows.Forms.TextBox();
            this.txtMoviePlot = new System.Windows.Forms.TextBox();
            this.txtMovieCopies = new System.Windows.Forms.TextBox();
            this.lblMovieDate = new System.Windows.Forms.Label();
            this.txtMovieDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRMID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.gbxMovie = new System.Windows.Forms.GroupBox();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.rbnRentedOut = new System.Windows.Forms.RadioButton();
            this.rbnAvailable = new System.Windows.Forms.RadioButton();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.gbxRentedMovies = new System.Windows.Forms.GroupBox();
            this.btnMoviesTab = new System.Windows.Forms.Button();
            this.btnCustomersTab = new System.Windows.Forms.Button();
            this.btnRentedMoviesTab = new System.Windows.Forms.Button();
            this.btnMostPopularTab = new System.Windows.Forms.Button();
            this.btnBestCustomersTab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.gbxCustomer.SuspendLayout();
            this.gbxMovie.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            this.gbxRentedMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(16, 37);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.Size = new System.Drawing.Size(1368, 422);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(87, 39);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(83, 20);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(228, 39);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(224, 20);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(369, 39);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(511, 39);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(365, 20);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(507, 20);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 17);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone:";
            // 
            // btnCustomerCreate
            // 
            this.btnCustomerCreate.Location = new System.Drawing.Point(652, 39);
            this.btnCustomerCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomerCreate.Name = "btnCustomerCreate";
            this.btnCustomerCreate.Size = new System.Drawing.Size(143, 25);
            this.btnCustomerCreate.TabIndex = 8;
            this.btnCustomerCreate.Text = "Add Customer";
            this.btnCustomerCreate.UseVisualStyleBackColor = true;
            this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(953, 38);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(143, 25);
            this.btnCustomerDelete.TabIndex = 10;
            this.btnCustomerDelete.Text = "Delete Customer";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Location = new System.Drawing.Point(803, 38);
            this.btnCustomerUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(143, 25);
            this.btnCustomerUpdate.TabIndex = 9;
            this.btnCustomerUpdate.Text = "Update Customer";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnMovieUpdate
            // 
            this.btnMovieUpdate.Location = new System.Drawing.Point(803, 100);
            this.btnMovieUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMovieUpdate.Name = "btnMovieUpdate";
            this.btnMovieUpdate.Size = new System.Drawing.Size(143, 25);
            this.btnMovieUpdate.TabIndex = 26;
            this.btnMovieUpdate.Text = "Update Movie";
            this.btnMovieUpdate.UseVisualStyleBackColor = true;
            this.btnMovieUpdate.Click += new System.EventHandler(this.btnMovieUpdate_Click);
            // 
            // btnMovieDelete
            // 
            this.btnMovieDelete.Location = new System.Drawing.Point(953, 100);
            this.btnMovieDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMovieDelete.Name = "btnMovieDelete";
            this.btnMovieDelete.Size = new System.Drawing.Size(143, 25);
            this.btnMovieDelete.TabIndex = 27;
            this.btnMovieDelete.Text = "Delete Movie";
            this.btnMovieDelete.UseVisualStyleBackColor = true;
            this.btnMovieDelete.Click += new System.EventHandler(this.btnMovieDelete_Click);
            // 
            // btnMovieCreate
            // 
            this.btnMovieCreate.Location = new System.Drawing.Point(652, 100);
            this.btnMovieCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMovieCreate.Name = "btnMovieCreate";
            this.btnMovieCreate.Size = new System.Drawing.Size(143, 25);
            this.btnMovieCreate.TabIndex = 25;
            this.btnMovieCreate.Text = "Add Movie";
            this.btnMovieCreate.UseVisualStyleBackColor = true;
            this.btnMovieCreate.Click += new System.EventHandler(this.btnMovieCreate_Click);
            // 
            // lblMovieRentalCost
            // 
            this.lblMovieRentalCost.AutoSize = true;
            this.lblMovieRentalCost.Location = new System.Drawing.Point(507, 20);
            this.lblMovieRentalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieRentalCost.Name = "lblMovieRentalCost";
            this.lblMovieRentalCost.Size = new System.Drawing.Size(85, 17);
            this.lblMovieRentalCost.TabIndex = 28;
            this.lblMovieRentalCost.Text = "Rental Cost:";
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Location = new System.Drawing.Point(365, 20);
            this.lblMovieYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(42, 17);
            this.lblMovieYear.TabIndex = 27;
            this.lblMovieYear.Text = "Year:";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(224, 20);
            this.lblMovieTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(39, 17);
            this.lblMovieTitle.TabIndex = 26;
            this.lblMovieTitle.Text = "Title:";
            // 
            // txtMovieRentalCost
            // 
            this.txtMovieRentalCost.Location = new System.Drawing.Point(511, 39);
            this.txtMovieRentalCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieRentalCost.Name = "txtMovieRentalCost";
            this.txtMovieRentalCost.Size = new System.Drawing.Size(132, 22);
            this.txtMovieRentalCost.TabIndex = 20;
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(369, 39);
            this.txtMovieYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(132, 22);
            this.txtMovieYear.TabIndex = 19;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(228, 39);
            this.txtMovieTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(132, 22);
            this.txtMovieTitle.TabIndex = 18;
            // 
            // lblMovieRating
            // 
            this.lblMovieRating.AutoSize = true;
            this.lblMovieRating.Location = new System.Drawing.Point(83, 20);
            this.lblMovieRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieRating.Name = "lblMovieRating";
            this.lblMovieRating.Size = new System.Drawing.Size(53, 17);
            this.lblMovieRating.TabIndex = 25;
            this.lblMovieRating.Text = "Rating:";
            // 
            // txtMovieRating
            // 
            this.txtMovieRating.Location = new System.Drawing.Point(87, 39);
            this.txtMovieRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieRating.Name = "txtMovieRating";
            this.txtMovieRating.Size = new System.Drawing.Size(132, 22);
            this.txtMovieRating.TabIndex = 17;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(8, 20);
            this.lblMovieID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(62, 17);
            this.lblMovieID.TabIndex = 28;
            this.lblMovieID.Text = "MovieID:";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Enabled = false;
            this.txtMovieID.Location = new System.Drawing.Point(12, 39);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(57, 22);
            this.txtMovieID.TabIndex = 50;
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Location = new System.Drawing.Point(365, 81);
            this.lblMovieGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(52, 17);
            this.lblMovieGenre.TabIndex = 34;
            this.lblMovieGenre.Text = "Genre:";
            // 
            // lblMoviePlot
            // 
            this.lblMoviePlot.AutoSize = true;
            this.lblMoviePlot.Location = new System.Drawing.Point(224, 81);
            this.lblMoviePlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoviePlot.Name = "lblMoviePlot";
            this.lblMoviePlot.Size = new System.Drawing.Size(36, 17);
            this.lblMoviePlot.TabIndex = 33;
            this.lblMoviePlot.Text = "Plot:";
            // 
            // lblMovieCopies
            // 
            this.lblMovieCopies.AutoSize = true;
            this.lblMovieCopies.Location = new System.Drawing.Point(83, 81);
            this.lblMovieCopies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieCopies.Name = "lblMovieCopies";
            this.lblMovieCopies.Size = new System.Drawing.Size(55, 17);
            this.lblMovieCopies.TabIndex = 32;
            this.lblMovieCopies.Text = "Copies:";
            // 
            // txtMovieGenre
            // 
            this.txtMovieGenre.Location = new System.Drawing.Point(369, 101);
            this.txtMovieGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieGenre.Name = "txtMovieGenre";
            this.txtMovieGenre.Size = new System.Drawing.Size(132, 22);
            this.txtMovieGenre.TabIndex = 23;
            // 
            // txtMoviePlot
            // 
            this.txtMoviePlot.Location = new System.Drawing.Point(228, 101);
            this.txtMoviePlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoviePlot.Name = "txtMoviePlot";
            this.txtMoviePlot.Size = new System.Drawing.Size(132, 22);
            this.txtMoviePlot.TabIndex = 22;
            // 
            // txtMovieCopies
            // 
            this.txtMovieCopies.Location = new System.Drawing.Point(87, 101);
            this.txtMovieCopies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieCopies.Name = "txtMovieCopies";
            this.txtMovieCopies.Size = new System.Drawing.Size(132, 22);
            this.txtMovieCopies.TabIndex = 21;
            // 
            // lblMovieDate
            // 
            this.lblMovieDate.AutoSize = true;
            this.lblMovieDate.Location = new System.Drawing.Point(507, 81);
            this.lblMovieDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieDate.Name = "lblMovieDate";
            this.lblMovieDate.Size = new System.Drawing.Size(42, 17);
            this.lblMovieDate.TabIndex = 36;
            this.lblMovieDate.Text = "Date:";
            // 
            // txtMovieDate
            // 
            this.txtMovieDate.Location = new System.Drawing.Point(511, 101);
            this.txtMovieDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieDate.Name = "txtMovieDate";
            this.txtMovieDate.Size = new System.Drawing.Size(132, 22);
            this.txtMovieDate.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "RMID";
            // 
            // txtRMID
            // 
            this.txtRMID.Enabled = false;
            this.txtRMID.Location = new System.Drawing.Point(16, 39);
            this.txtRMID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRMID.Name = "txtRMID";
            this.txtRMID.Size = new System.Drawing.Size(53, 22);
            this.txtRMID.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "CustID:";
            // 
            // txtCustID
            // 
            this.txtCustID.Enabled = false;
            this.txtCustID.Location = new System.Drawing.Point(12, 39);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(57, 22);
            this.txtCustID.TabIndex = 51;
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.label15);
            this.gbxCustomer.Controls.Add(this.txtFirstName);
            this.gbxCustomer.Controls.Add(this.txtCustID);
            this.gbxCustomer.Controls.Add(this.lblFirstName);
            this.gbxCustomer.Controls.Add(this.txtLastName);
            this.gbxCustomer.Controls.Add(this.lblLastName);
            this.gbxCustomer.Controls.Add(this.txtAddress);
            this.gbxCustomer.Controls.Add(this.txtPhone);
            this.gbxCustomer.Controls.Add(this.lblAddress);
            this.gbxCustomer.Controls.Add(this.lblPhone);
            this.gbxCustomer.Controls.Add(this.btnCustomerCreate);
            this.gbxCustomer.Controls.Add(this.btnCustomerDelete);
            this.gbxCustomer.Controls.Add(this.btnCustomerUpdate);
            this.gbxCustomer.Location = new System.Drawing.Point(8, 469);
            this.gbxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCustomer.Size = new System.Drawing.Size(1205, 90);
            this.gbxCustomer.TabIndex = 52;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "CUSTOMER";
            // 
            // gbxMovie
            // 
            this.gbxMovie.Controls.Add(this.gbxFilter);
            this.gbxMovie.Controls.Add(this.btnReturnMovie);
            this.gbxMovie.Controls.Add(this.btnIssueMovie);
            this.gbxMovie.Controls.Add(this.lblMovieID);
            this.gbxMovie.Controls.Add(this.txtMovieID);
            this.gbxMovie.Controls.Add(this.txtMovieRating);
            this.gbxMovie.Controls.Add(this.lblMovieRating);
            this.gbxMovie.Controls.Add(this.txtMovieTitle);
            this.gbxMovie.Controls.Add(this.txtMovieYear);
            this.gbxMovie.Controls.Add(this.txtMovieRentalCost);
            this.gbxMovie.Controls.Add(this.lblMovieTitle);
            this.gbxMovie.Controls.Add(this.lblMovieYear);
            this.gbxMovie.Controls.Add(this.lblMovieRentalCost);
            this.gbxMovie.Controls.Add(this.btnMovieCreate);
            this.gbxMovie.Controls.Add(this.btnMovieDelete);
            this.gbxMovie.Controls.Add(this.btnMovieUpdate);
            this.gbxMovie.Controls.Add(this.txtMovieCopies);
            this.gbxMovie.Controls.Add(this.txtMoviePlot);
            this.gbxMovie.Controls.Add(this.lblMovieDate);
            this.gbxMovie.Controls.Add(this.txtMovieGenre);
            this.gbxMovie.Controls.Add(this.txtMovieDate);
            this.gbxMovie.Controls.Add(this.lblMovieCopies);
            this.gbxMovie.Controls.Add(this.lblMovieGenre);
            this.gbxMovie.Controls.Add(this.lblMoviePlot);
            this.gbxMovie.Location = new System.Drawing.Point(8, 564);
            this.gbxMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxMovie.Name = "gbxMovie";
            this.gbxMovie.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxMovie.Size = new System.Drawing.Size(1376, 160);
            this.gbxMovie.TabIndex = 53;
            this.gbxMovie.TabStop = false;
            this.gbxMovie.Text = "MOVIES";
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.rbnRentedOut);
            this.gbxFilter.Controls.Add(this.rbnAvailable);
            this.gbxFilter.Location = new System.Drawing.Point(1104, 65);
            this.gbxFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFilter.Size = new System.Drawing.Size(257, 60);
            this.gbxFilter.TabIndex = 53;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter Movies";
            // 
            // rbnRentedOut
            // 
            this.rbnRentedOut.AutoSize = true;
            this.rbnRentedOut.Location = new System.Drawing.Point(143, 25);
            this.rbnRentedOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnRentedOut.Name = "rbnRentedOut";
            this.rbnRentedOut.Size = new System.Drawing.Size(102, 21);
            this.rbnRentedOut.TabIndex = 1;
            this.rbnRentedOut.TabStop = true;
            this.rbnRentedOut.Text = "Rented Out";
            this.rbnRentedOut.UseVisualStyleBackColor = true;
            this.rbnRentedOut.CheckedChanged += new System.EventHandler(this.rbnRentedOut_CheckedChanged);
            // 
            // rbnAvailable
            // 
            this.rbnAvailable.AutoSize = true;
            this.rbnAvailable.Location = new System.Drawing.Point(9, 25);
            this.rbnAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnAvailable.Name = "rbnAvailable";
            this.rbnAvailable.Size = new System.Drawing.Size(117, 21);
            this.rbnAvailable.TabIndex = 0;
            this.rbnAvailable.TabStop = true;
            this.rbnAvailable.Text = "Available Now";
            this.rbnAvailable.UseVisualStyleBackColor = true;
            this.rbnAvailable.CheckedChanged += new System.EventHandler(this.rbnAvailable_CheckedChanged);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.Color.Green;
            this.btnReturnMovie.Location = new System.Drawing.Point(803, 20);
            this.btnReturnMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(143, 60);
            this.btnReturnMovie.TabIndex = 52;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnIssueMovie.Location = new System.Drawing.Point(652, 20);
            this.btnIssueMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(143, 60);
            this.btnIssueMovie.TabIndex = 51;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // gbxRentedMovies
            // 
            this.gbxRentedMovies.Controls.Add(this.label14);
            this.gbxRentedMovies.Controls.Add(this.txtRMID);
            this.gbxRentedMovies.Enabled = false;
            this.gbxRentedMovies.Location = new System.Drawing.Point(1221, 471);
            this.gbxRentedMovies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxRentedMovies.Name = "gbxRentedMovies";
            this.gbxRentedMovies.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxRentedMovies.Size = new System.Drawing.Size(163, 87);
            this.gbxRentedMovies.TabIndex = 54;
            this.gbxRentedMovies.TabStop = false;
            this.gbxRentedMovies.Text = "RENTED MOVIES";
            // 
            // btnMoviesTab
            // 
            this.btnMoviesTab.Location = new System.Drawing.Point(15, 6);
            this.btnMoviesTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoviesTab.Name = "btnMoviesTab";
            this.btnMoviesTab.Size = new System.Drawing.Size(133, 31);
            this.btnMoviesTab.TabIndex = 55;
            this.btnMoviesTab.Text = "Movies";
            this.btnMoviesTab.UseVisualStyleBackColor = true;
            this.btnMoviesTab.Click += new System.EventHandler(this.btnMoviesTab_Click);
            // 
            // btnCustomersTab
            // 
            this.btnCustomersTab.Location = new System.Drawing.Point(145, 6);
            this.btnCustomersTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomersTab.Name = "btnCustomersTab";
            this.btnCustomersTab.Size = new System.Drawing.Size(133, 31);
            this.btnCustomersTab.TabIndex = 56;
            this.btnCustomersTab.Text = "Customers";
            this.btnCustomersTab.UseVisualStyleBackColor = true;
            this.btnCustomersTab.Click += new System.EventHandler(this.btnCustomersTab_Click);
            // 
            // btnRentedMoviesTab
            // 
            this.btnRentedMoviesTab.Location = new System.Drawing.Point(276, 6);
            this.btnRentedMoviesTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRentedMoviesTab.Name = "btnRentedMoviesTab";
            this.btnRentedMoviesTab.Size = new System.Drawing.Size(133, 31);
            this.btnRentedMoviesTab.TabIndex = 57;
            this.btnRentedMoviesTab.Text = "Rented Movies";
            this.btnRentedMoviesTab.UseVisualStyleBackColor = true;
            this.btnRentedMoviesTab.Click += new System.EventHandler(this.btnRentedMoviesTab_Click);
            // 
            // btnMostPopularTab
            // 
            this.btnMostPopularTab.Location = new System.Drawing.Point(407, 6);
            this.btnMostPopularTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostPopularTab.Name = "btnMostPopularTab";
            this.btnMostPopularTab.Size = new System.Drawing.Size(133, 31);
            this.btnMostPopularTab.TabIndex = 58;
            this.btnMostPopularTab.Text = "Most Popular";
            this.btnMostPopularTab.UseVisualStyleBackColor = true;
            this.btnMostPopularTab.Click += new System.EventHandler(this.btnMostPopularTab_Click);
            // 
            // btnBestCustomersTab
            // 
            this.btnBestCustomersTab.Location = new System.Drawing.Point(537, 6);
            this.btnBestCustomersTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBestCustomersTab.Name = "btnBestCustomersTab";
            this.btnBestCustomersTab.Size = new System.Drawing.Size(133, 31);
            this.btnBestCustomersTab.TabIndex = 59;
            this.btnBestCustomersTab.Text = "Best Customers";
            this.btnBestCustomersTab.UseVisualStyleBackColor = true;
            this.btnBestCustomersTab.Click += new System.EventHandler(this.btnBestCustomersTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1404, 908);
            this.Controls.Add(this.btnBestCustomersTab);
            this.Controls.Add(this.btnMostPopularTab);
            this.Controls.Add(this.btnRentedMoviesTab);
            this.Controls.Add(this.btnCustomersTab);
            this.Controls.Add(this.btnMoviesTab);
            this.Controls.Add(this.gbxRentedMovies);
            this.Controls.Add(this.gbxMovie);
            this.Controls.Add(this.gbxCustomer);
            this.Controls.Add(this.dgvMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            this.gbxMovie.ResumeLayout(false);
            this.gbxMovie.PerformLayout();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.gbxRentedMovies.ResumeLayout(false);
            this.gbxRentedMovies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnCustomerCreate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.Button btnMovieDelete;
        private System.Windows.Forms.Button btnMovieCreate;
        private System.Windows.Forms.Label lblMovieRentalCost;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtMovieRentalCost;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label lblMovieRating;
        private System.Windows.Forms.TextBox txtMovieRating;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblMoviePlot;
        private System.Windows.Forms.Label lblMovieCopies;
        private System.Windows.Forms.TextBox txtMovieGenre;
        private System.Windows.Forms.TextBox txtMoviePlot;
        private System.Windows.Forms.TextBox txtMovieCopies;
        private System.Windows.Forms.Label lblMovieDate;
        private System.Windows.Forms.TextBox txtMovieDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRMID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.GroupBox gbxMovie;
        private System.Windows.Forms.GroupBox gbxRentedMovies;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.RadioButton rbnRentedOut;
        private System.Windows.Forms.RadioButton rbnAvailable;
        private System.Windows.Forms.Button btnMoviesTab;
        private System.Windows.Forms.Button btnCustomersTab;
        private System.Windows.Forms.Button btnRentedMoviesTab;
        private System.Windows.Forms.Button btnMostPopularTab;
        private System.Windows.Forms.Button btnBestCustomersTab;
    }
}

