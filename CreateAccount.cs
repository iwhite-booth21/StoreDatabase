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
    public partial class CreateAccount : Form
    {

       
        WelcomePage wpage;


        public CreateAccount()
        {

            InitializeComponent();
        }

       

        private void newUserCancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newUserConfirm_BTN_Click(object sender, EventArgs e)
        {
            //  Read and store information for the account
            AccData personInfo = new AccData();
            personInfo.user_username = newUsernameRsp_TBX.Text;
            personInfo.user_password = newUserPWDRsp_TBX.Text;
            personInfo.user_email = newUserEmailRsp_TBX.Text;
            personInfo.user_Pnumber = newUserPNumRsp_TBX.Text;
            personInfo.fName = newUserFNameRsp_TBX.Text;
            personInfo.lName = newUserLNameRsp_TBX.Text;
            personInfo.accType = accTypeTBX.Text;
            personInfo.uniqueIdentifier = personInfo.user_username + personInfo.user_password;     // Create Hybrid Field

            //  Attempt data insert into database
            bool result = personInfo.InsertAccData();

            // If result is successful, open the welcome page. Else display a message to the user
            if (result == true)
            {
                string userSucceed = string.Format("Thank you for signing up '{0}'", personInfo.user_username);

                if (wpage == null || wpage.IsDisposed)
                {
                    wpage = new WelcomePage();

                }
                wpage.Show();
                this.Hide();
                MessageBox.Show(userSucceed);


            }
            else
            {
                MessageBox.Show("Account Creation Failed, try Again");
            }

            //This is NOT essential to run program
            //Utilizing Switch Case to handle the Two User Types.
            //Displays a message stating the type selected.
            switch (accTypeTBX.Text)
            {
                case "E":
                    MessageBox.Show("You selected Employee");
                    break;

                case "C":
                    MessageBox.Show("You selected Customer");
                    break;

                default:
                    MessageBox.Show("Invalid User Type");
                    break;
            }
        }
    }
}
