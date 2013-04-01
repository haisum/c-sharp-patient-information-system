using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using PatientInformationSystem.Forms;

namespace PatientInformationSystem.Classes
{
    class ListViewClass
    {
        public static void WriteListView(DataTable objDT, ListView vlistView, ComboBox IDs)
        {
            IDs.Items.Clear();
            string[] str = new string[objDT.Columns.Count];

            //adding Datarows as listview Grids

            foreach (DataRow objRR in objDT.Rows)
            {

                for (int col = 0; col <= objDT.Columns.Count - 1; col++)
                {
                    if (col == 0)
                    {
                        IDs.Items.Add(objRR[col].ToString());
                        continue;
                    }
                    if (col == 3 && IDs.Name == "comboIDs")
                    {
                        str[col - 1] = Convert.ToDateTime(objRR[col].ToString()).ToShortDateString();
                        continue;
                    }
                    str[col - 1] = objRR[col].ToString();
                }
                ListViewItem ii;
                ii = new ListViewItem(str);
                vlistView.Items.Add(ii);

            }
        }


        }
    }

