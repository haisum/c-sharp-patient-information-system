using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientInformationSystem.Forms
{
    public partial class UserCP : Form
    {
        App_Data.PisDataSet.UsersDataTable myUserTbl = new App_Data.PisDataSet.UsersDataTable();

        public UserCP()
        {
            InitializeComponent();
        }

        private void UserCP_Load(object sender, EventArgs e)
        {
            App_Data.PisDataSetTableAdapters.UsersTableAdapter myUsersAd = new App_Data.PisDataSetTableAdapters.UsersTableAdapter();
            lblWelcome.Text = Classes.publicClass.UserName;

            if (Classes.publicClass.UserType == 1)//if its moderator instead of 2 which is normal user
            {
                groupBox1.Enabled = true;
                myUsersAd.FillLoginBy(myUserTbl);
                WriteListViewforUsers(myUserTbl);
            }
        }

        private void WriteListViewforUsers(DataTable objDT)
        {
            string[] str = new string[objDT.Columns.Count];
            string UserType = "";

            //adding Datarows as listview Grids

            foreach (DataRow objRR in objDT.Rows)
            {

                cmbUserIDs.Items.Add((-1 * Convert.ToInt32(objRR["userID"])).ToString());
                str[0] = objRR["UserName"].ToString();
                if (Convert.ToInt32(objRR["UserType"]) == 1)
                {
                    UserType = "Moderator";
                }
                else
                {
                    UserType = "Normal";
                }
                str[1] = UserType;
                ListViewItem ii;
                ii = new ListViewItem(str);
                listView1.Items.Add(ii);

            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Make Sure You Have Selected Record To Delete");
            }
            else if (MessageBox.Show("Really delete?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                PatientInformationSystem.App_Data.PisDataSetTableAdapters.UsersTableAdapter UsersDA = new App_Data.PisDataSetTableAdapters.UsersTableAdapter();
                UsersDA.DeleteUserQuery(Convert.ToInt32(cmbUserIDs.Items[listView1.FocusedItem.Index]));
                MessageBox.Show("Record Deleted Successfully!");
                listView1.Items.Clear();
                myUserTbl.Clear();
                cmbUserIDs.Items.Clear();
                UsersDA.FillLoginBy(myUserTbl);
                WriteListViewforUsers(myUserTbl);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        { 
            try
            {
                App_Data.PisDataSetTableAdapters.UsersTableAdapter myuserAd = new App_Data.PisDataSetTableAdapters.UsersTableAdapter();
                myuserAd.UpdatePasswordQuery(txtNewPassword.Text, -1 * Classes.publicClass.UserId);
                MessageBox.Show("Password Updated Successfully");
            }
            catch
            {
                MessageBox.Show("Have U inserted Password? Error in Query");
            }
        }

        private void btnAddnewUser_Click(object sender, EventArgs e)
        {
            try
            {
                byte UTyype = 2;
                App_Data.PisDataSetTableAdapters.UsersTableAdapter myuserAd = new App_Data.PisDataSetTableAdapters.UsersTableAdapter();

                if (comboBox1.SelectedItem.ToString() == "Moderator")
                    UTyype = 1;

                myuserAd.InsertUserQuery(txtuserName.Text, txtPassword.Text, UTyype);
                MessageBox.Show("User Added Successfully");
                listView1.Items.Clear();
                myUserTbl.Clear();
                cmbUserIDs.Items.Clear();
                myUserTbl.Clear();
                myuserAd.FillLoginBy(myUserTbl);
                WriteListViewforUsers(myUserTbl);
            }
            catch
            {
                MessageBox.Show("Please Verify Data!! make Sure you haven't added not available username, have given password, and have selected a type");
            }
        }
    }
}
