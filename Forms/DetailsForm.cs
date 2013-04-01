using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientInformationSystem.Forms
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }


        private void DetailsForm_Load(object sender, EventArgs e)
        {
            App_Data.PisDataSetTableAdapters.PatientsTableAdapter myPatientDa = new App_Data.PisDataSetTableAdapters.PatientsTableAdapter();
            App_Data.PisDataSet.PatientsDataTable myTbl = new App_Data.PisDataSet.PatientsDataTable();
            try
            {
                myPatientDa.FillPatientByIDBy(myTbl, Classes.publicClass.PatientID);
                lblNname.Text = myTbl.Rows[0]["PatientName"].ToString();
                lblAge.Text = myTbl.Rows[0]["PatientAge"].ToString();
                lblLandLineNo.Text = myTbl.Rows[0]["PatientLandLineNo"].ToString();
                lblMobileNo.Text = myTbl.Rows[0]["PatientMobileNo"].ToString();
                lblPatientAddress.Text = myTbl.Rows[0]["PatientAddress"].ToString();
                lblDoctorName.Text = myTbl.Rows[0]["PatientDoctor"].ToString();
                lblDov.Text = Text = Convert.ToDateTime(myTbl.Rows[0]["PatientDOA"].ToString()).ToShortDateString();

                txtClinicFindings.Text = myTbl.Rows[0]["PatientClinicalFindings"].ToString();
                txtComplaint.Text = myTbl.Rows[0]["PatientComplaint"].ToString();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error!! " + exc.Message );
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Forms.Images().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Forms.history().ShowDialog();
        }
    }
}
