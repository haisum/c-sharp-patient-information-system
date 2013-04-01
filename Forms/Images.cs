using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientInformationSystem.Forms
{
    public partial class Images : Form
    {
        string[] myStrImageLocation;
        string[] myStrImageID;
        int index = 0;
        public Images()
        {
            InitializeComponent();
        }

        private void Images_Load(object sender, EventArgs e)
        {
            try
            {
                App_Data.PisDataSet.ImagesDataTable myTbl = new App_Data.PisDataSet.ImagesDataTable();
                App_Data.PisDataSetTableAdapters.ImagesTableAdapter myAd = new App_Data.PisDataSetTableAdapters.ImagesTableAdapter();

                myAd.FillImagesbyPatientBy(myTbl, Classes.publicClass.PatientID);
                // MessageBox.Show(myTbl.Rows.Count.ToString());
                string[] MyStrImageLocation = new string[myTbl.Rows.Count];
                string[] MyStrImageID = new string[myTbl.Rows.Count];

                foreach (DataRow dr in myTbl.Rows)
                {
                    MyStrImageID[index] = dr["ImageID"].ToString();
                    MyStrImageLocation[index] = dr["ImageLocation"].ToString();
                    index++;
                    //MessageBox.Show(dr["ImageID"].ToString());
                    //MessageBox.Show(dr["ImageLocation"].ToString());
                }
                myStrImageID = MyStrImageID;
                myStrImageLocation = MyStrImageLocation;
                index = 0;
                pictureBox1.ImageLocation = myStrImageLocation[index];
                btnPrevious.Enabled = false;
                if (myStrImageID.Length == 1)
                    btnNext.Enabled = false; 
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message + "\nPossibly No Images to Load ADD Images Please");
                this.Close();
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (!btnNext.Enabled)
                    btnNext.Enabled = true;
                pictureBox1.ImageLocation = myStrImageLocation[--index];
                if (index == 0)
                    btnPrevious.Enabled = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (!btnPrevious.Enabled)
                    btnPrevious.Enabled = true;
                pictureBox1.ImageLocation = myStrImageLocation[++index];
                if (index == myStrImageLocation.Length - 1)
                {
                    btnNext.Enabled = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
