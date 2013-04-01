using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PatientInformationSystem;
using System.IO;
using System.Runtime.InteropServices;
using System.Management;

namespace PatientInformationSystem.Forms
{
    public partial class LogOn : Form
    {
        const string CPUID = "BFEBFBFF000006FD";

        public static Forms.MainForm newMainForm = new MainForm();
        public LogOn()
        {
            InitializeComponent();

        }


        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void loginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                bool USerRecordFound = false;
                App_Data.PisDataSetTableAdapters.UsersTableAdapter myUsersAd = new App_Data.PisDataSetTableAdapters.UsersTableAdapter();
                App_Data.PisDataSet.UsersDataTable myUsersTbl = new App_Data.PisDataSet.UsersDataTable();
                myUsersAd.FillLoginBy(myUsersTbl);

                foreach (DataRow myRow in myUsersTbl.Rows)
                {

                    if (myRow["UserName"].ToString().ToLower().Trim() == txtUserName.Text.ToLower().Trim() && myRow["Password"].ToString().Trim() == txtPassword.Text.Trim())
                    {
                        Classes.publicClass.UserId = Convert.ToInt32(myRow["UserID"]);
                        Classes.publicClass.UserType = Convert.ToInt32(myRow["UserType"].ToString());
                        Classes.publicClass.UserName = myRow["UserName"].ToString();

                        USerRecordFound = true;

                        new Forms.MainForm().Show();
                        this.Hide();
                        //this.Close();

                        break;
                    }


                }

                if (!USerRecordFound)
                {
                    MessageBox.Show("Invalid User Name/Password\nPlease Try Again");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to Load Database\n" + exc.Message);
            }

        }

        private void loginbutton_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox myBox = (PictureBox)sender;
            myBox.Top += 1;
            myBox.Left += 1;

        }

        private void loginbutton_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox myBox = (PictureBox)sender;
            myBox.Top -= 1;
            myBox.Left -= 1;
        }

        private void LogOn_Load(object sender, EventArgs e)
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            if (cpuInfo != CPUID)
            {
                
                MessageBox.Show("Unauthorized use of Patient Information System. This copy of software is unregistered and is being used illegally. To get your own copy of PIS, contact designplox or visit us at www.designplox.com");
                Application.Exit();
            }
          




        }
    }
}
        