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
    public partial class ViewDepartment : Form
    {
        DatabaseMgrSQLite dbMgr;
        DataTable deptTable = new DataTable();

        public ViewDepartment()
        {
            InitializeComponent();

            dbMgr = new DatabaseMgrSQLite();
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

        private void ViewDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            string myindex = index.ToString();
            MessageBox.Show(myindex);


        }
    }
}
