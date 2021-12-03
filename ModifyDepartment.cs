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
    public partial class ModifyDepartment : Form
    {
        DatabaseMgrSQLite dbMgr;
        DataTable depteTabl = new DataTable();

        public ModifyDepartment()
        {
            InitializeComponent();

            dbMgr = new DatabaseMgrSQLite();
        }


        public void LoadModDepartment()
        {

            // Set up a List checker.

            // Use SQL String to get data
            String LoadDeptSql = String.Format("SELECT * from Department WHERE " +
                "DepartmentId = '{0}'", GlobalData.DepartmentId);

            // Make Call to DB Browser 
            int numRows = 0;
            depteTabl.Clear();
            depteTabl = dbMgr.getData(LoadDeptSql, out numRows);


            if (numRows == 1)
            {
                DnameRspTBOX.Text = depteTabl.Rows[0]["DepartmentName"].ToString();
                DmanRspTBOX.Text =  depteTabl.Rows[0]["DepartmentManager"].ToString();
                StoreSectRspTBOX.Text = depteTabl.Rows[0]["StoreSection"].ToString();
                NumEmpRspTBOX.Text = depteTabl.Rows[0]["EmployeeNo"].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowsInserted = 0;
            int x = 1;
            // Default bool set
            bool itemStatus = true;

            if (itemStatus == true && x.Equals(1))
            {
                string DeptUpdSql = String.Format("UPDATE Department SET " +
                    "DepartmentManager = '{0}', StoreSection = '{1}', EmployeeNo = '{2}', DepartmentName = '{3}' " +
                    "WHERE Departmentid = '{4}'", DmanRspTBOX.Text,StoreSectRspTBOX.Text,NumEmpRspTBOX.Text, DnameRspTBOX.Text, GlobalData.DepartmentId);

                rowsInserted = dbMgr.putData(DeptUpdSql);

                MessageBox.Show("Modify Successful");

            }
        }
    }

}
