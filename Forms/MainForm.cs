
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PatientInformationSystem.Classes;

namespace PatientInformationSystem.Forms
{
    public partial class MainForm : Form
    {

        //Declare static public form Patients
        public static MainForm pubPatients;
        


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            comboIDs.Items.Clear();
            lblWelCome.Text = "Welcome " + publicClass.UserName;
            //populateLsitView();
        }


        void setPatientID()
        {
            Classes.publicClass.PatientID = Convert.ToInt32(comboIDs.Items[listView1.FocusedItem.Index].ToString());
        }

        void setPublicClassData()
        {

                    setPatientID();
                    Classes.publicClass.PatientName = listView1.Items[listView1.FocusedItem.Index].Text;
                    Classes.publicClass.age = Convert.ToInt32(listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text);
                    Classes.publicClass.DOV = listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text;
                    Classes.publicClass.MobileNo = listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text;
                    Classes.publicClass.LandLineNo = listView1.Items[listView1.FocusedItem.Index].SubItems[4].Text;
                    Classes.publicClass.DoctorName = listView1.Items[listView1.FocusedItem.Index].SubItems[5].Text;
                    Classes.publicClass.Address = listView1.Items[listView1.FocusedItem.Index].SubItems[6].Text;
                    Classes.publicClass.Complaint = listView1.Items[listView1.FocusedItem.Index].SubItems[7].Text;
                    Classes.publicClass.ClinicalFinding = listView1.Items[listView1.FocusedItem.Index].SubItems[8].Text;
        }

        /*void populateLsitView()
        {
            comboIDs.Items.Clear();
            try
            {
                listView1.Items.Clear();
                PatientInformationSystem.App_Data.PisDataSetTableAdapters.PatientsTableAdapter patientsDA = new App_Data.PisDataSetTableAdapters.PatientsTableAdapter();
                PatientInformationSystem.App_Data.PisDataSet.PatientsDataTable PatientDt = new App_Data.PisDataSet.PatientsDataTable();
                PatientDt = patientsDA.GetDataOfPatientsBy();
                Classes.ListViewClass.WriteListView(PatientDt, listView1, comboIDs);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Database Query Problem\n" + exc.Message);
            }
        }*/



        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox myBox = (PictureBox)sender;
            myBox.Top += 1;
            myBox.Left += 1;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox myBox = (PictureBox)sender;
            myBox.Top -= 1;
            myBox.Left -= 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modify()
        {
            publicClass.IsModification = true;
            setPublicClassData();
            new Forms.FormModify().ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
           modify();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                setPatientID();
                modify();

            }
            else
                MessageBox.Show("Select a record to modify.");
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //populateLsitView();
            listView1.Items.Clear();
            comboIDs.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count!=1)
            {
                MessageBox.Show("Select a record to delete.");
            }
            else if (MessageBox.Show("Really delete?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                setPatientID();
                PatientInformationSystem.App_Data.PisDataSetTableAdapters.PatientsTableAdapter patientsDA = new App_Data.PisDataSetTableAdapters.PatientsTableAdapter();
                PatientInformationSystem.App_Data.PisDataSetTableAdapters.HistoryTableAdapter HsitoryDA = new App_Data.PisDataSetTableAdapters.HistoryTableAdapter();
                App_Data.PisDataSetTableAdapters.ImagesTableAdapter ImagesDa = new App_Data.PisDataSetTableAdapters.ImagesTableAdapter();
                patientsDA.DeletePatientQuery(publicClass.PatientID);
                ImagesDa.DeleteImagesQuery(publicClass.PatientID);
                HsitoryDA.DeleteHistoryQuery(publicClass.PatientID);
                MessageBox.Show("Record Deleted Successfully!");
                listView1.Items.Clear();
            }

    
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            publicClass.IsModification = false;
            new Forms.FormModify().ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new Forms.LogOn().Show();
            FindForm().Hide();
            FindForm().Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new Forms.About().ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new Forms.UserCP().ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            App_Data.PisDataSetTableAdapters.PatientsTableAdapter myAd = new App_Data.PisDataSetTableAdapters.PatientsTableAdapter();
            App_Data.PisDataSet.PatientsDataTable myTbl = new App_Data.PisDataSet.PatientsDataTable();

            if (radioByName.Checked)
            {
                myAd.FillSearchPatientNameBy(myTbl, txtSearch.Text.Trim());
            }

            else if (radioDoctor.Checked)
            {
                myAd.FillSearchByDoctorBy(myTbl, txtSearch.Text);
            }

            else if (radioMobile.Checked)
            {
                myAd.FillSearchMobileNoBy(myTbl, txtSearch.Text);
            }

            else if (radioLand.Checked)
            {
                myAd.FillSearchLandLineNoBy(myTbl, txtSearch.Text);
            }

            else if (radioAge.Checked)
            {
                myAd.FillSearchPatientsAgeBy(myTbl, txtSearch.Text);
            }

            else if(radioDate.Checked)
            {
                try
                {
                    myAd.FillDateBy(myTbl, Convert.ToDateTime(Convert.ToDateTime(txtSearch.Text).ToShortDateString()));
                }
                catch
                {
                    MessageBox.Show("Please input valid Date of MM/DD/YYYY Format");
                }
            }

            Classes.ListViewClass.WriteListView(myTbl, listView1, comboIDs);
            listView1.Visible = true;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                setPatientID();
                new DetailsForm().Show();

            }
            else
                MessageBox.Show("Select a record to show details.");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchAdvanced_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                setPatientID();
                new DetailsForm().Show();

            }
            else
                MessageBox.Show("Select a record to show details.");
        }



        }

    

        }


      


        
    

