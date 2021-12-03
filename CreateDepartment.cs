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
    
    public partial class CreateDepartment : Form
    {
        ModifyDepartment modDept;
        DatabaseMgrSQLite dbMgr;
        DataTable deptTable = new DataTable();

        
        public CreateDepartment()
        {
            InitializeComponent();

            dbMgr = new DatabaseMgrSQLite();
        }

        // This method check whether a user is unique by using sql select statement.
        // Utilizes the UserID field which is comprised of username + password.
        public bool UniqueDepartment(){


            //======================================================================================
            //  This variable was originally created to generate a username password combination.
            //  Possible future for the variable may be possible.

            String DepartmentName = DNameRspTBOX.Text.ToString();
            String DepartmentManager = DManRspTBOX.Text.ToString();
            String StoreSection = StoreSectRspTBOX.ToString();
            int NumEmp = int.Parse(NumEmpRspTBOX.Text.ToString());


            string DepartmentSelSql = String.Format("SELECT * from Department WHERE " +
                    "DepartmentName = '{0}'", DepartmentName);

            //Setting up Database connection with the Class
            int numRows = 0;
            deptTable.Clear();
            deptTable = dbMgr.getData(DepartmentSelSql, out numRows);

            //  Checka The unique value from the InventoryID / Unique Identifier.
            //  If not unique, display a message stating account exists.
            if (numRows == 1)
            {
                MessageBox.Show("Finance Total Exists, Try Another.");     // Can be removed
                return false;
            }
            //  If User Unique, display a message stating account generation.
            else
            {
                MessageBox.Show("Generating new Department");  // Can be removed 
                return true;
            }




        }

        // This method creates a new record into database. User an INSERT statement.
        public bool InsertDepartment()
        {

            String DepartmentName = DNameRspTBOX.Text.ToString();
            String DepartmentManager = DManRspTBOX.Text.ToString();
            String StoreSection = StoreSectRspTBOX.Text.ToString();
            int NumEmp = int.Parse(NumEmpRspTBOX.Text.ToString());


            //Build SQL Insert Statement
            string InventoryInSql = String.Format("INSERT INTO Department(DepartmentManager,StoreSection,EmployeeNo,DepartmentName)VALUES" +
                    "('{0}','{1}',{2},'{3}')", DepartmentManager, StoreSection, NumEmp, DepartmentName);



            bool uniqueInventoryID = UniqueDepartment();



            if (DNameRspTBOX.Text.ToString().Equals("") || DManRspTBOX.Text.ToString().Equals("") ||
                StoreSectRspTBOX.Text.ToString().Equals("") || NumEmpRspTBOX.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please fill in information");

                return false;

            }

  
            else if (uniqueInventoryID == true)
            {
                int rowsInserted = 0;
                rowsInserted = dbMgr.putData(InventoryInSql);
                MessageBox.Show("Inserting Record into inventory database");
                return true;
            }
            else if (uniqueInventoryID == false)
            {
                MessageBox.Show("Deprtmet Exists, please create a new item");


                return false;

            }
    
            else
            {
                return false;
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (modDept == null || modDept.IsDisposed)
            {
                modDept = new ModifyDepartment();
            }
            modDept.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubDeptBTN_Click(object sender, EventArgs e)
        {
            InsertDepartment();
        }
    }
}
