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

    public partial class StoreTotals : Form
    {
        DatabaseMgrSQLite dbMgr;
        DataTable financialTable = new DataTable();
        AuditTotals audTotals = new AuditTotals();

        public StoreTotals()
        {
            InitializeComponent();
        }

        private void LeaveBTN_Click(object sender, EventArgs e)
        {
            InsertFinance();
            this.Close();
        }

        public bool UniqueFinance()
        {


            
            int AccountingTotals = int.Parse(AccRspTBOX.Text.ToString());

            string FinanceSelSql = String.Format("SELECT * from Finance WHERE " +
                    "AccountingTotals = '{0}'", AccountingTotals);

            //Setting up Database connection with the Class
            int numRows = 0;
            financialTable.Clear();
            financialTable = dbMgr.getData(FinanceSelSql, out numRows);

            //  Checka The unique value from the InventoryID / Unique Identifier.
            //  If not unique, display a message stating account exists.
            if (numRows == 1)
            {
                MessageBox.Show("Department Exists, Try Another.");     // Can be removed
                return false;
            }
            //  If User Unique, display a message stating account generation.
            else
            {
                MessageBox.Show("Generating new Department");  // Can be removed 
                return true;
            }




        }

        public bool InsertFinance()
        {

           
            int AccountingTotals = int.Parse(AccRspTBOX.Text.ToString());
            int EndingBalances = int.Parse(EndBalRspTBOX.Text.ToString());


            //Build SQL Insert Statement
            string FinanceInSql = String.Format("INSERT INTO Finance(AccountingTotals,EndingBalances)VALUES" +
                    "('{0}','{1}')", AccountingTotals, EndingBalances);



            bool uniqueFinanceID = UniqueFinance();



            if (AccRspTBOX.Text.ToString().Equals("") || EndBalRspTBOX.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please fill in information");

                return false;

            }


            else if (uniqueFinanceID == true)
            {
                int rowsInserted = 0;
                rowsInserted = dbMgr.putData(FinanceInSql);
                MessageBox.Show("Totals are correct");
                return true;
            }
            else if (uniqueFinanceID == false)
            {
                MessageBox.Show("Finance Exists, please ensure records are correct");


                return false;

            }

            else
            {
                return false;
            }



        }

        private void AuditLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (audTotals == null || audTotals.IsDisposed)
            {
                audTotals = new AuditTotals();
            }
            audTotals.Show();
        }
    }
}
