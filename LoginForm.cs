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
    public partial class LoginForm : Form
    {
        WelcomePage wpage;
        CreateAccount createAcc;
        DatabaseMgrSQLite dbMgr;
        DataTable loginTable = new DataTable();

        public LoginForm()
        {
            InitializeComponent();

            //Create database manager
            dbMgr = new DatabaseMgrSQLite();
        }

        private void cafLinkLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Check if form exists, if not create instance of form
            if (createAcc == null || createAcc.IsDisposed)
            {
                createAcc = new CreateAccount();
            }

            // Show the Form
            createAcc.Show();
            this.Hide();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            //Step 1: Read user Entry for Password and Username
            string user = userResponseTBX.Text;
            string pass = passwordResponseTBX.Text;

            //Step 2: Create Sql String
            // Combination exists in the database

            string sqlStr = String.Format("SELECT * from Account WHERE " + 
                                          "userName = '{0}' AND password = '{1}'", user, pass);


           //===================================================================================
           // SQL Select string TEST
           //   string sqlStr = "Select * from Account Where " +
           //             "userName =  '" + user + "' And " +
           //              "password = '" + pass + "'";
           //
           //   MessageBox.Show(sqlStr);
           //===================================================================================


            //Step 3: Make call to database and check results
            int numRows = 0;    //Store the count of returned rows
            loginTable.Clear(); //Removes current values from table
            loginTable = dbMgr.getData(sqlStr, out numRows);




            // Step 4: If user exist display Welcome Screen
            // Else display error for invalid credentials
            if (numRows == 1)
            {
                //Display a welcome message
                string myuser = loginTable.Rows[0]["userName"].ToString();
                MessageBox.Show("Welcome ", myuser);

                // Save accId
                GlobalData.accId = loginTable.Rows[0]["acc_id"].ToString();

                //Open Home/Nav Page
                if (wpage == null || wpage.IsDisposed) 
                {
                    wpage = new WelcomePage();  // Create new Instance
                }
                // Set menu up based on user type
                //  TODO - Add to global data class
                GlobalData.accType = loginTable.Rows[0]["accType"].ToString();
                wpage.Show();

            }
            else 
            { 
                MessageBox.Show("Invalid Credentials");
                
            }



        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
