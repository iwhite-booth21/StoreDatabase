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
        DataTable InvTable = new DataTable();
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
    }
}
