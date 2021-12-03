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
    public partial class ViewCustomerServiceIssue : Form
    {
        DatabaseMgrSQLite dbMgr;
        DataTable RequestTable = new DataTable();
        ModifyCustomerServiceIssue modIssue;

        public ViewCustomerServiceIssue()
        {
            InitializeComponent();
        }

        private void modifyIssueLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (modIssue == null || modIssue.IsDisposed) 
            {
                modIssue = new ModifyCustomerServiceIssue();
            }
            modIssue.Show();
        }

        public void LoadModRequest()
        {

            // Set up a List checker.

            // Use SQL String to get data
            String LoadRequestSql = String.Format("SELECT ServiceResponse from CustomerService WHERE " +
                "ServiceId = '{0}'", GlobalData.ServiceId);

            // Make Call to DB Browser 
            int numRows = 0;
            RequestTable.Clear();
            RequestTable = dbMgr.getData(LoadRequestSql, out numRows);


            if (numRows == 1)
            {
                viewIssueTBOX.Text = RequestTable.Rows[0]["ServiceResponse"].ToString();
              
            }
        }

        private void ViewCustomerServiceIssue_Load(object sender, EventArgs e)
        {
            LoadModRequest();
        }
    }


}
