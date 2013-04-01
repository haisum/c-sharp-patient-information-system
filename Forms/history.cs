using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientInformationSystem.Forms
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            App_Data.PisDataSetTableAdapters.HistoryTableAdapter HDa = new App_Data.PisDataSetTableAdapters.HistoryTableAdapter();
            App_Data.PisDataSet.HistoryDataTable myHsttable = new App_Data.PisDataSet.HistoryDataTable();
            
            HDa.FillHistoryBy(myHsttable, Classes.publicClass.PatientID);
            WriteListView(myHsttable);
        }

         private void WriteListView(DataTable objDT)
        {
             
            string[] str = new string[objDT.Columns.Count];

            //adding Datarows as listview Grids

            foreach (DataRow objRR in objDT.Rows)
            {

                for (int col = 0; col <= objDT.Columns.Count - 1; col++)
                {
                    if (col == 0)
                    {
                        comboBox1.Items.Add(objRR[0].ToString());
                        continue;
                    }

                    if (col == 1)
                    {
                        str[col - 1] = Convert.ToDateTime(objRR[col].ToString()).ToShortDateString();
                        continue;
                    }
                    str[col - 1] = objRR[col].ToString();
                }
                ListViewItem ii;
                ii = new ListViewItem(str);
                listView1.Items.Add(ii);

            }
        }

         private void button1_Click(object sender, EventArgs e)
         {
             try
             {
                 App_Data.PisDataSetTableAdapters.HistoryTableAdapter HDa = new App_Data.PisDataSetTableAdapters.HistoryTableAdapter();
                 App_Data.PisDataSet.HistoryDataTable myHsttable = new App_Data.PisDataSet.HistoryDataTable();
                 HDa.InsertHistoryQuery(Convert.ToDateTime(Convert.ToDateTime(txtDate.Text).ToShortDateString()), txtDescription.Text, Convert.ToInt32(txtCharges.Text), Convert.ToInt32(txtPaid.Text), Convert.ToInt32(txtBalance.Text), Classes.publicClass.PatientID);
                 HDa.FillHistoryBy(myHsttable, Classes.publicClass.PatientID);
                 listView1.Items.Clear();
                 comboBox1.Items.Clear();
                 WriteListView(myHsttable);
                 
             }
             catch (Exception exc)
             {
                 MessageBox.Show("Verify Input " + exc.Message);
             }

         }

         private void btnDelete_Click(object sender, EventArgs e)
         {
             if (listView1.SelectedItems.Count == 1)
             {
                 try
                 {
                     App_Data.PisDataSetTableAdapters.HistoryTableAdapter myHstAd = new App_Data.PisDataSetTableAdapters.HistoryTableAdapter();
                     myHstAd.DeleteByIdQuery(Convert.ToInt32(comboBox1.Items[listView1.FocusedItem.Index].ToString()));
                     App_Data.PisDataSet.HistoryDataTable myHstTbl = new App_Data.PisDataSet.HistoryDataTable();
                     myHstAd.FillHistoryBy(myHstTbl, Classes.publicClass.PatientID);
                     comboBox1.Items.Clear();
                     listView1.Items.Clear();
                     WriteListView(myHstTbl);
                     MessageBox.Show("Record Deleted Successfully!");
                 }
                 catch (Exception exc)
                 {
                     MessageBox.Show(exc.Message);
                 }
             }
             else
             {
                 MessageBox.Show("Make sure you have selected history item to be deleted");
             }
         }


        }
    }

