namespace PatientInformationSystem.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmPatietName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPatientAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPatientAdmitDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPatientMobileNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPatientLandLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPatinetDoctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPatientAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPatientComplaint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmClinicalFindings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblWelCome = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddPatient = new System.Windows.Forms.PictureBox();
            this.btnModify = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnSearchAdvanced = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.comboIDs = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioByName = new System.Windows.Forms.RadioButton();
            this.radioDoctor = new System.Windows.Forms.RadioButton();
            this.radioDate = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioMobile = new System.Windows.Forms.RadioButton();
            this.radioAge = new System.Windows.Forms.RadioButton();
            this.radioLand = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(165, 17);
            this.StatusLabel1.Text = "Patient Information System";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(85, 17);
            this.StatusLabel2.Text = "Copyrights dP";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPatietName,
            this.clmPatientAge,
            this.clmPatientAdmitDate,
            this.clmPatientMobileNo,
            this.clmPatientLandLine,
            this.clmPatinetDoctor,
            this.clmPatientAddress,
            this.clmPatientComplaint,
            this.clmClinicalFindings});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(14, 350);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1052, 352);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // clmPatietName
            // 
            this.clmPatietName.Text = "Name";
            this.clmPatietName.Width = 138;
            // 
            // clmPatientAge
            // 
            this.clmPatientAge.Text = "Age";
            this.clmPatientAge.Width = 42;
            // 
            // clmPatientAdmitDate
            // 
            this.clmPatientAdmitDate.Text = "Admitted On:";
            this.clmPatientAdmitDate.Width = 105;
            // 
            // clmPatientMobileNo
            // 
            this.clmPatientMobileNo.Text = "Mobile No.";
            this.clmPatientMobileNo.Width = 118;
            // 
            // clmPatientLandLine
            // 
            this.clmPatientLandLine.Text = "Land Line No.";
            this.clmPatientLandLine.Width = 131;
            // 
            // clmPatinetDoctor
            // 
            this.clmPatinetDoctor.Text = "Doctor Name";
            this.clmPatinetDoctor.Width = 138;
            // 
            // clmPatientAddress
            // 
            this.clmPatientAddress.Text = "Address";
            this.clmPatientAddress.Width = 113;
            // 
            // clmPatientComplaint
            // 
            this.clmPatientComplaint.Text = "Complaint";
            this.clmPatientComplaint.Width = 113;
            // 
            // clmClinicalFindings
            // 
            this.clmClinicalFindings.Text = "Clinical Findings";
            this.clmClinicalFindings.Width = 136;
            // 
            // lblWelCome
            // 
            this.lblWelCome.AutoSize = true;
            this.lblWelCome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelCome.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelCome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelCome.Location = new System.Drawing.Point(432, 85);
            this.lblWelCome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelCome.Name = "lblWelCome";
            this.lblWelCome.Size = new System.Drawing.Size(112, 25);
            this.lblWelCome.TabIndex = 14;
            this.lblWelCome.Text = "Welcome";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(22, 278);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(837, 26);
            this.txtSearch.TabIndex = 17;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPatient.Image = global::PatientInformationSystem.Properties.Resources._126008_matte_white_square_icon_symbols_shapes_puzzle_horizontal;
            this.btnAddPatient.Location = new System.Drawing.Point(33, 128);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(100, 90);
            this.btnAddPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAddPatient.TabIndex = 23;
            this.btnAddPatient.TabStop = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            this.btnAddPatient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnAddPatient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.Image = global::PatientInformationSystem.Properties.Resources._125987_matte_white_square_icon_symbols_shapes_cube;
            this.btnModify.Location = new System.Drawing.Point(261, 128);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(100, 90);
            this.btnModify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnModify.TabIndex = 24;
            this.btnModify.TabStop = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            this.btnModify.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnModify.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = global::PatientInformationSystem.Properties.Resources._126001_matte_white_square_icon_symbols_shapes_minimize;
            this.btnDelete.Location = new System.Drawing.Point(375, 128);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 90);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDelete.TabIndex = 25;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btnSearchAdvanced
            // 
            this.btnSearchAdvanced.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchAdvanced.Image = global::PatientInformationSystem.Properties.Resources._126048_matte_white_square_icon_symbols_shapes_spiral;
            this.btnSearchAdvanced.Location = new System.Drawing.Point(147, 128);
            this.btnSearchAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchAdvanced.Name = "btnSearchAdvanced";
            this.btnSearchAdvanced.Size = new System.Drawing.Size(100, 90);
            this.btnSearchAdvanced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSearchAdvanced.TabIndex = 26;
            this.btnSearchAdvanced.TabStop = false;
            this.btnSearchAdvanced.Click += new System.EventHandler(this.btnSearchAdvanced_Click);
            this.btnSearchAdvanced.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnSearchAdvanced.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Image = global::PatientInformationSystem.Properties.Resources._125984_matte_white_square_icon_symbols_shapes_comment_bubble2;
            this.btnAbout.Location = new System.Drawing.Point(831, 128);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 90);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAbout.TabIndex = 27;
            this.btnAbout.TabStop = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = global::PatientInformationSystem.Properties.Resources._126039_matte_white_square_icon_symbols_shapes_spinner1;
            this.btnRefresh.Location = new System.Drawing.Point(489, 128);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 90);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnRefresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::PatientInformationSystem.Properties.Resources.yitle;
            this.pictureBox7.Location = new System.Drawing.Point(292, 43);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(492, 39);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::PatientInformationSystem.Properties.Resources.addpat;
            this.pictureBox8.Location = new System.Drawing.Point(22, 223);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(121, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::PatientInformationSystem.Properties.Resources.detaaa;
            this.pictureBox9.Location = new System.Drawing.Point(162, 223);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(78, 35);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::PatientInformationSystem.Properties.Resources.mod;
            this.pictureBox10.Location = new System.Drawing.Point(273, 223);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(78, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 32;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::PatientInformationSystem.Properties.Resources.del;
            this.pictureBox11.Location = new System.Drawing.Point(389, 223);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(75, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 33;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::PatientInformationSystem.Properties.Resources._ref;
            this.pictureBox12.Location = new System.Drawing.Point(498, 223);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(86, 33);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 34;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::PatientInformationSystem.Properties.Resources.ab;
            this.pictureBox13.Location = new System.Drawing.Point(848, 223);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(71, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 35;
            this.pictureBox13.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::PatientInformationSystem.Properties.Resources._126005_matte_white_square_icon_symbols_shapes_power_button1;
            this.btnExit.Location = new System.Drawing.Point(945, 128);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 90);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 36;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Image = global::PatientInformationSystem.Properties.Resources._126050_matte_white_square_icon_symbols_shapes_square_download;
            this.btnLogOut.Location = new System.Drawing.Point(717, 128);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 90);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnLogOut.TabIndex = 37;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnLogOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.Image = global::PatientInformationSystem.Properties.Resources._125980_matte_white_squassre_icon_symbols_shapes_checkmark_solid_circle;
            this.btnSignUp.Location = new System.Drawing.Point(603, 128);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 90);
            this.btnSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSignUp.TabIndex = 38;
            this.btnSignUp.TabStop = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnSignUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = global::PatientInformationSystem.Properties.Resources.sin;
            this.pictureBox17.Location = new System.Drawing.Point(614, 223);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(80, 35);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox17.TabIndex = 39;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Image = global::PatientInformationSystem.Properties.Resources.logd;
            this.pictureBox18.Location = new System.Drawing.Point(730, 223);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(80, 35);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox18.TabIndex = 40;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.Image = global::PatientInformationSystem.Properties.Resources.ex;
            this.pictureBox19.Location = new System.Drawing.Point(972, 223);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(50, 32);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox19.TabIndex = 41;
            this.pictureBox19.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::PatientInformationSystem.Properties.Resources.sear;
            this.btnSearch.Location = new System.Drawing.Point(896, 274);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 40);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSearch.TabIndex = 42;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.btnSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.Image = global::PatientInformationSystem.Properties.Resources.searshad;
            this.pictureBox21.Location = new System.Drawing.Point(866, 244);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(200, 100);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox21.TabIndex = 43;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox21_Click);
            // 
            // comboIDs
            // 
            this.comboIDs.FormattingEnabled = true;
            this.comboIDs.Location = new System.Drawing.Point(977, 43);
            this.comboIDs.Name = "comboIDs";
            this.comboIDs.Size = new System.Drawing.Size(23, 23);
            this.comboIDs.TabIndex = 46;
            this.comboIDs.Text = "hidden Combo";
            this.comboIDs.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-15, -15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 19);
            this.radioButton1.TabIndex = 47;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.BackColor = System.Drawing.Color.Transparent;
            this.radioByName.Checked = true;
            this.radioByName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioByName.ForeColor = System.Drawing.Color.White;
            this.radioByName.Location = new System.Drawing.Point(62, 310);
            this.radioByName.Name = "radioByName";
            this.radioByName.Size = new System.Drawing.Size(94, 22);
            this.radioByName.TabIndex = 48;
            this.radioByName.TabStop = true;
            this.radioByName.Text = "By Name";
            this.radioByName.UseVisualStyleBackColor = false;
            // 
            // radioDoctor
            // 
            this.radioDoctor.AutoSize = true;
            this.radioDoctor.BackColor = System.Drawing.Color.Transparent;
            this.radioDoctor.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDoctor.ForeColor = System.Drawing.Color.White;
            this.radioDoctor.Location = new System.Drawing.Point(162, 310);
            this.radioDoctor.Name = "radioDoctor";
            this.radioDoctor.Size = new System.Drawing.Size(101, 22);
            this.radioDoctor.TabIndex = 49;
            this.radioDoctor.Text = "By Doctor";
            this.radioDoctor.UseVisualStyleBackColor = false;
            // 
            // radioDate
            // 
            this.radioDate.AutoSize = true;
            this.radioDate.BackColor = System.Drawing.Color.Transparent;
            this.radioDate.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDate.ForeColor = System.Drawing.Color.White;
            this.radioDate.Location = new System.Drawing.Point(563, 310);
            this.radioDate.Name = "radioDate";
            this.radioDate.Size = new System.Drawing.Size(160, 22);
            this.radioDate.TabIndex = 50;
            this.radioDate.Text = "By Date Admitted";
            this.radioDate.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PatientInformationSystem.Properties.Resources.aaaaaaa;
            this.pictureBox1.Location = new System.Drawing.Point(915, 705);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // radioMobile
            // 
            this.radioMobile.AutoSize = true;
            this.radioMobile.BackColor = System.Drawing.Color.Transparent;
            this.radioMobile.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMobile.ForeColor = System.Drawing.Color.White;
            this.radioMobile.Location = new System.Drawing.Point(269, 310);
            this.radioMobile.Name = "radioMobile";
            this.radioMobile.Size = new System.Drawing.Size(134, 22);
            this.radioMobile.TabIndex = 52;
            this.radioMobile.Text = "By Mobile No.";
            this.radioMobile.UseVisualStyleBackColor = false;
            // 
            // radioAge
            // 
            this.radioAge.AutoSize = true;
            this.radioAge.BackColor = System.Drawing.Color.Transparent;
            this.radioAge.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAge.ForeColor = System.Drawing.Color.White;
            this.radioAge.Location = new System.Drawing.Point(729, 310);
            this.radioAge.Name = "radioAge";
            this.radioAge.Size = new System.Drawing.Size(80, 22);
            this.radioAge.TabIndex = 53;
            this.radioAge.Text = "By Age";
            this.radioAge.UseVisualStyleBackColor = false;
            // 
            // radioLand
            // 
            this.radioLand.AutoSize = true;
            this.radioLand.BackColor = System.Drawing.Color.Transparent;
            this.radioLand.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLand.ForeColor = System.Drawing.Color.White;
            this.radioLand.Location = new System.Drawing.Point(409, 310);
            this.radioLand.Name = "radioLand";
            this.radioLand.Size = new System.Drawing.Size(148, 22);
            this.radioLand.TabIndex = 54;
            this.radioLand.Text = "By Landline No.";
            this.radioLand.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PatientInformationSystem.Properties.Resources.Untitled_1;
            this.ClientSize = new System.Drawing.Size(1078, 733);
            this.ControlBox = false;
            this.Controls.Add(this.radioLand);
            this.Controls.Add(this.radioAge);
            this.Controls.Add(this.radioMobile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioDate);
            this.Controls.Add(this.radioDoctor);
            this.Controls.Add(this.radioByName);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboIDs);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSearchAdvanced);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblWelCome);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox21);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Information System | Design Plox";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmPatietName;
        private System.Windows.Forms.ColumnHeader clmPatientAge;
        private System.Windows.Forms.ColumnHeader clmPatientAdmitDate;
        private System.Windows.Forms.ColumnHeader clmPatientMobileNo;
        private System.Windows.Forms.ColumnHeader clmPatientLandLine;
        private System.Windows.Forms.ColumnHeader clmPatinetDoctor;
        private System.Windows.Forms.Label lblWelCome;
        private System.Windows.Forms.ColumnHeader clmPatientAddress;
        private System.Windows.Forms.ColumnHeader clmPatientComplaint;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnAddPatient;
        private System.Windows.Forms.PictureBox btnModify;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnSearchAdvanced;
        private System.Windows.Forms.PictureBox btnAbout;
        private System.Windows.Forms.PictureBox btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnLogOut;
        private System.Windows.Forms.PictureBox btnSignUp;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.ComboBox comboIDs;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioByName;
        private System.Windows.Forms.RadioButton radioDoctor;
        private System.Windows.Forms.RadioButton radioDate;
        private System.Windows.Forms.ColumnHeader clmClinicalFindings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioMobile;
        private System.Windows.Forms.RadioButton radioAge;
        private System.Windows.Forms.RadioButton radioLand;
    }
}