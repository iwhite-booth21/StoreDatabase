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
    public partial class CreateCustomerServiceIssue : Form
    {
        DatabaseMgrSQLite dbMgr;
        DataTable RequestTable = new DataTable();
        ViewCustomerServiceIssue vIssue = new ViewCustomerServiceIssue();
        
        public CreateCustomerServiceIssue()
        {
            InitializeComponent();

            dbMgr = new DatabaseMgrSQLite();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public bool UniqueRequest()
        {


            //======================================================================================
            //  This variable was originally created to generate a username password combination.
            //  Possible future for the variable may be possible.

            String ServiceResponse = ServRequestTBOX.Text.ToString();
            


            string ServiceSelSql = String.Format("SELECT * from CustomerService WHERE " +
                    "ServiceResponse = '{0}'", ServiceResponse);

            //Setting up Database connection with the Class
            int numRows = 0;
            RequestTable.Clear();
            RequestTable = dbMgr.getData(ServiceSelSql, out numRows);

            //  Checka The unique value from the InventoryID / Unique Identifier.
            //  If not unique, display a message stating account exists.
            if (numRows == 1)
            {
                MessageBox.Show("Request Exists, Try Another.");     // Can be removed
                return false;
            }
            //  If User Unique, display a message stating account generation.
            else
            {
                MessageBox.Show("Generating new Request");  // Can be removed 
                return true;
            }
   

        }

        public bool InsertRequest()
        {

            String ServRequest = ServRequestTBOX.Text.ToString();
            


            //Build SQL Insert Statement
            string RequestInSql = String.Format("INSERT INTO CustomerService(ServiceResponse)VALUES" +
                    "('{0}')", ServRequest);



            bool uniqueInventoryID = UniqueRequest();



            if (ServRequestTBOX.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please fill in information");

                return false;

            }


            else if (uniqueInventoryID == true)
            {
                int rowsInserted = 0;
                rowsInserted = dbMgr.putData(RequestInSql);
                MessageBox.Show("Inserting Record into Customer Service database");
                return true;
            }
            else if (uniqueInventoryID == false)
            {
                MessageBox.Show("Request Exists, please create a new request");


                return false;

            }

            else
            {
                return false;
            }



        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            InsertRequest();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vCustServLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (vIssue == null || vIssue.IsDisposed)
            {
                vIssue = new ViewCustomerServiceIssue();
            }
            vIssue.Show();
        }
    }
}
