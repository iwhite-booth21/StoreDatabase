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

    public partial class AuditTotals : Form
    {
        DatabaseMgrSQLite dbMgr;
        DataTable financeTable = new DataTable();
        public AuditTotals()
        {
            InitializeComponent();
            dbMgr = new DatabaseMgrSQLite();
        }

        public void LoadModFinance()
        {

            // Set up a List checker.

            // Use SQL String to get data
            String LoadFinanceSql = String.Format("SELECT * from Finance WHERE " +
                "FinanceId = '{0}'", GlobalData.FinanceId);

            // Make Call to DB Browser 
            int numRows = 0;
            financeTable.Clear();
            financeTable = dbMgr.getData(LoadFinanceSql, out numRows);


            if (numRows == 1)
            {
                AccRspTBOX.Text = financeTable.Rows[0]["AccountingTotals"].ToString();
                EndBalRspTBOX.Text = financeTable.Rows[0]["EndingBalances"].ToString();

            }
        }

        private void AuditTotals_Load(object sender, EventArgs e)
        {
            LoadModFinance();
        }
    }
}
