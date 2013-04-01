using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PatientInformationSystem.Classes;

namespace PatientInformationSystem.Forms
{
    public partial class FormModify : Form
    {

        public FormModify()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            App_Data.PisDataSetTableAdapters.PatientsTableAdapter myPatAd = new App_Data.PisDataSetTableAdapters.PatientsTableAdapter();
            App_Data.PisDataSet.PatientsDataTable myPatTable = new App_Data.PisDataSet.PatientsDataTable();

            App_Data.PisDataSetTableAdapters.ImagesTableAdapter myImgAd = new App_Data.PisDataSetTableAdapters.ImagesTableAdapter();
            App_Data.PisDataSet.ImagesDataTable myImgtbl = new App_Data.PisDataSet.ImagesDataTable();



            if (publicClass.IsModification)
            {
                try
                {
                    if (txtImageLocation.Text != "" && cmbImageIndex.SelectedIndex != -1)
                    {
                        myImgAd.UpdateImageLocationQuery(txtImageLocation.Text, Convert.ToInt32(cmbImageID.Items[cmbImageIndex.SelectedIndex]));
                    }
                    myPatAd.UpdatePatientQuery(txtpatientName.Text,
                                        txtAge.Text,
                                        Convert.ToDateTime(Convert.ToDateTime(txtDate.Text).ToShortDateString()),
                                        txtMobileNo.Text,
                                        txtLandLine.Text,
                                        txtDoctorName.Text,
                                        txtAddress.Text,
                                        txtComplaint.Text,
                                        txtFindings.Text,
                                        publicClass.PatientID);
                    MessageBox.Show("Updated Successfully");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Update Error! " + exc.Message);
                }
            }
            else
            {
                try
                {

                    txtImageLocation.Width = 193;
                    myImgAd.InsertImageQuery(txtImageLocation.Text, publicClass.PatientID);
                    myPatAd.InsertQuery(txtpatientName.Text,
                                        Convert.ToInt32(txtAge.Text).ToString(),
                                        Convert.ToDateTime(Convert.ToDateTime(txtDate.Text).ToShortDateString()),
                                        txtMobileNo.Text,
                                        txtLandLine.Text,
                                        txtDoctorName.Text,
                                        txtAddress.Text,
                                        txtComplaint.Text,
                                        txtFindings.Text);
                    MessageBox.Show("Record Added!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Add Error!! " + exc.Message);
                }
            }
        }

        private void FormModify_Load(object sender, EventArgs e)
        {

            if (Classes.publicClass.IsModification)
            {
                FillFormData();
            }
            else
            {
                cmbImageIndex.Visible = false;
                txtImageLocation.Visible = false;
                btnbrowseImage.Visible = false;
                lblCurrentImages.Visible = false;
                btnAddModify.Visible = false;
                button1.Visible = false;
            }
        }

        void FillFormData()
        {
            App_Data.PisDataSet.ImagesDataTable myImageTbl = new App_Data.PisDataSet.ImagesDataTable();
            App_Data.PisDataSetTableAdapters.ImagesTableAdapter myAd = new App_Data.PisDataSetTableAdapters.ImagesTableAdapter();
            myAd.FillImagesbyPatientBy(myImageTbl, Classes.publicClass.PatientID);

            txtAge.Text = Classes.publicClass.age.ToString();
            txtLandLine.Text = Classes.publicClass.LandLineNo;
            txtMobileNo.Text = Classes.publicClass.MobileNo;

            txtpatientName.Text = Classes.publicClass.PatientName;
            txtAddress.Text = Classes.publicClass.Address;
            txtDoctorName.Text = Classes.publicClass.DoctorName;
            txtAge.Text = Classes.publicClass.age.ToString();
            txtFindings.Text = Classes.publicClass.ClinicalFinding;
            txtComplaint.Text = Classes.publicClass.Complaint;

            txtDate.Text = Convert.ToDateTime(Classes.publicClass.DOV).ToShortDateString();

            for (int index = 0; index < myImageTbl.Rows.Count; index++)
            {

                cmbImageIndex.Items.Add((index + 1).ToString());
                cmbImageID.Items.Add(myImageTbl.Rows[index]["ImageID"].ToString());
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbImageIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //App_Data.PisDataSet.ImagesDataTable myImgTbl = new App_Data.PisDataSet.ImagesDataTable();
            App_Data.PisDataSet.ImagesDataTable myImgTbl = new App_Data.PisDataSet.ImagesDataTable();
            App_Data.PisDataSetTableAdapters.ImagesTableAdapter myImgAd = new App_Data.PisDataSetTableAdapters.ImagesTableAdapter();
            myImgAd.FillImageByIDBy(myImgTbl, Convert.ToInt32(cmbImageID.Items[cmbImageIndex.SelectedIndex]));
            //MessageBox.Show(/*myImgTbl.Rows[0]["ImageLocation"].ToString() + " " + */cmbImageID.Items[cmbImageIndex.SelectedIndex].ToString() + myImgTbl.Rows.Count.ToString());
            txtImageLocation.Text = myImgTbl.Rows[0]["ImageLocation"].ToString();
        }

        private void btnbrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog DialogImageSelect = new OpenFileDialog();
            DialogImageSelect.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (DialogImageSelect.ShowDialog() == DialogResult.OK)
            {
                txtImageLocation.Text = DialogImageSelect.FileName;

            }
        }


        private void txtImageLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (txtImageLocation.Text == "")
                {
                    MessageBox.Show("Image Location Can't Be Null");
                    return;
                }
                else if (txtImageLocation.Text != "")
                {
                    App_Data.PisDataSetTableAdapters.ImagesTableAdapter myAd = new App_Data.PisDataSetTableAdapters.ImagesTableAdapter();
                    App_Data.PisDataSet.ImagesDataTable myTbl = new App_Data.PisDataSet.ImagesDataTable();

                    myAd.InsertImageQuery(txtImageLocation.Text, publicClass.PatientID);
                    myAd.FillImagesbyPatientBy(myTbl, Classes.publicClass.PatientID);
                    cmbImageID.Items.Clear();
                    cmbImageIndex.Items.Clear();
                    for (int index = 0; index < myTbl.Rows.Count; index++)
                    {
                        cmbImageIndex.Items.Add((index + 1).ToString());
                        cmbImageID.Items.Add(myTbl.Rows[index]["ImageID"].ToString());
                    }

                  txtImageLocation.Text = "";
                  cmbImageIndex.SelectedIndex = -1;
                  cmbImageIndex.Text = "";
                    MessageBox.Show("New Image Loaded!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cmbImageIndex.SelectedIndex != -1)
            {

                App_Data.PisDataSetTableAdapters.ImagesTableAdapter myAd = new App_Data.PisDataSetTableAdapters.ImagesTableAdapter();
                myAd.DeleteImageByImageIDQuery(Convert.ToInt32(cmbImageID.Items[cmbImageIndex.SelectedIndex]));

                App_Data.PisDataSet.ImagesDataTable myTbl = new App_Data.PisDataSet.ImagesDataTable();
                myAd.FillImagesbyPatientBy(myTbl, Classes.publicClass.PatientID);

                cmbImageID.Items.Clear();
                cmbImageIndex.Items.Clear();
                for (int index = 0; index < myTbl.Rows.Count; index++)
                {
                    cmbImageIndex.Items.Add((index + 1).ToString());
                    cmbImageID.Items.Add(myTbl.Rows[index]["ImageID"].ToString());
                }
                txtImageLocation.Text = "";
                cmbImageIndex.SelectedIndex = -1;
                cmbImageIndex.Text = "";
                MessageBox.Show("Image Deleted");

            }

            else
            {
                MessageBox.Show("Select An Image Index to delete it");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Forms.history().ShowDialog();
        }
    }
}
