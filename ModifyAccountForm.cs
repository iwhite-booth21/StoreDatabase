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
    public partial class ModifyAccountForm : Form
    {
        AccData personInfo = new AccData();
        DatabaseMgrSQLite dbMgr = new DatabaseMgrSQLite();
        DataTable modTable = new DataTable();





        public ModifyAccountForm()
        {
            InitializeComponent();
        }

        private void newUserCancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserUpdBTN_Click(object sender, EventArgs e)
        {

            //  Read and modify information for the account
            personInfo.user_username = newUsernameRsp_TBX.Text;
            personInfo.user_password = newUserPWDRsp_TBX.Text;
            personInfo.user_email = newUserEmailRsp_TBX.Text;
            personInfo.user_Pnumber = newUserPNumRsp_TBX.Text;
            personInfo.fName = newUserFNameRsp_TBX.Text;
            personInfo.lName = newUserLNameRsp_TBX.Text;
            personInfo.accType = accTypeTBX.Text;
            personInfo.uniqueIdentifier = personInfo.user_username + personInfo.user_password;

           //  MessageBox.Show(personInfo.user_username);
           bool testvariable1, testvariable2;
           testvariable1 = true;
           testvariable2 = false;
                      
           // personInfo.ModAcc();



           
            if (testvariable1!=testvariable2)
            {
                //Build SQL Update Statement
                string accUpdSql = String.Format("UPDATE Account SET " +
                    "userName = '{0}', password ='{1}' , email='{2}', phoneNum='{3}', " +
                    "firstName = '{4}', lastName = '{5}', accType = '{6}', userID = '{7}' " +
                    "WHERE acc_id = '{8}'", 
                    personInfo.user_username, personInfo.user_password, personInfo.user_email, personInfo.user_Pnumber,
                    personInfo.fName, personInfo.lName, personInfo.accType, personInfo.uniqueIdentifier, GlobalData.accId);


                //Test UPDATE SQL STATEMENT
                MessageBox.Show(accUpdSql);

                int numRowsModified = 0;
                numRowsModified = dbMgr.putData(accUpdSql);
                MessageBox.Show("Modifying Record into database");
             }
            




        }

        private void ModifyAccountForm_Load(object sender, EventArgs e)
        {
          
            personInfo.loadUserAccountData();
            newUsernameRsp_TBX.Text = personInfo.user_username;
            newUserPWDRsp_TBX.Text = personInfo.user_password;
            newUserEmailRsp_TBX.Text = personInfo.user_email;
            newUserPNumRsp_TBX.Text = personInfo.user_Pnumber;
            newUserFNameRsp_TBX.Text = personInfo.fName;
            newUserLNameRsp_TBX.Text = personInfo.lName;
            accTypeTBX.Text = personInfo.accType;
        }
    }
}
