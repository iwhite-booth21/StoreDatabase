using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreDatabase
{
    public partial class SelectDepartment : Form
    {
        CreateDepartment createDept;
        DatabaseMgrSQLite dbMgr;
        DataTable deptTable = new DataTable();
        public SelectDepartment()
        {
            InitializeComponent();
            dbMgr = new DatabaseMgrSQLite();
        }

        private void CreateDptLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (createDept == null || createDept.IsDisposed)
            {
                createDept = new CreateDepartment();
            }
            createDept.Show();
        }

        private void userCancelInventoryBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void LoadDepartment()
        {
            // Clear the existing inventory list first
            checkedListBox1.Items.Clear();

            // Retrieve inventory items via loop
            string sqlStr = String.Format("SELECT DepartmentName from Department");

            int numRows = 0;    //Store the count of returned rows
            deptTable.Clear(); //Removes current values from table
            deptTable = dbMgr.getData(sqlStr, out numRows);


            // Populate the inventory list with retrieved items
            // N = numRows - 1
            // checkedListBox.Items.Add()

            if (numRows == 0)
            {
                MessageBox.Show("No Department Available");
            }
            else
            {
                for (int i = 0; i <= numRows - 1; i++)
                {

                    checkedListBox1.Items.Add(deptTable.Rows[i]["DepartmentName"].ToString());
                }
            }

        }

        private void SelectDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }
    }
}
