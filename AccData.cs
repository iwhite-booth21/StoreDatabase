using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace StoreDatabase
{
    class AccData
    {
        //  Add variables for connecting to database
        DatabaseMgrSQLite dbMgr = new DatabaseMgrSQLite();
        DataTable acctTable = new DataTable();

        //Data variables for storing values from the form
        public string user_username;
        public string user_password;
        public string user_email;
        public string user_Pnumber;
        public string fName;
        public string lName;
        public string accType;
        public string uniqueIdentifier;

        // Class Constructor
        public AccData()
        {
            

       
        }

        // This method check whether a user is unique by using sql select statement.
        // Utilizes the UserID field which is comprised of username + password.
        public bool UniqueUser() 
        {


            //======================================================================================
            //  This variable was originally created to generate a username password combination.
            //  Possible future for the variable may be possible.

            string accSelSql = String.Format("SELECT * from Account WHERE " +
                    "userID = '{0}'", uniqueIdentifier);

            //Setting up Database connection with the Class
            int numRows = 0;
            acctTable.Clear();
            acctTable = dbMgr.getData(accSelSql, out numRows);

            //  Checka The unique value from the UserID / Unique Identifier.
            //  If not unique, display a message stating account exists.
            if (numRows == 1)
            {
                MessageBox.Show("User Exists, login.");     // Can be removed
                return false;
            }
            //  If User Unique, display a message stating account generation.
            else 
            {
                MessageBox.Show("Generating new account");  // Can be removed 
                return true;
            }




        }




        // This method creates a new record into database. User an INSERT statement.
        public bool InsertAccData()
         {

            //Build SQL Insert Statement
            string accInSql = String.Format("INSERT INTO Account(userName,password,email,phoneNum,firstName,lastName,accType, userID)VALUES" +
                    "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", user_username, user_password,user_email,user_Pnumber, fName, lName,accType,uniqueIdentifier);


            // Step 1: Check if all required fields have a value. If any values are not present, return false.
            // Use a string to insert the data, however first you need a insert statement
            // Utilize a select statement to generate the user/pass combination



            // Step 2: Check if username/password combination is unique.
            // The first step of this category is to create a select statement that grabs the user and password values.
            // Secondly, create a value to hold this unique account identifier.

            bool uniqueID = UniqueUser();
        

            //======================================================================================
            //  Checks if the values are empty. If so displays a message to fill in the information.
            //  Checks variable valaues directly. 
            if (user_username.Equals("") || user_password.Equals("") ||
                fName.Equals("") || lName.Equals(""))
            {
                MessageBox.Show("Please fill in information");

                return false;

            }

            //  Check uniqueID return value to determine if user is unique.
            //  Inserts data into database if unique.
            else if (uniqueID == true)
            {
                int rowsInserted = 0;
                rowsInserted = dbMgr.putData(accInSql);
                MessageBox.Show("Inserting Record into database");
                return true;
            }
            else if (uniqueID == false)
            {
                MessageBox.Show("User Exists, please login normally");
                return false;

            }
            // To complete the program for insertaccdata, this addition bool return was needed.
            // No message box is necessary
            else 
            {
                return false;
            }
               

            
         }





        public bool checkUser() 
        {

            string userCheckSql = String.Format("SELECT * from Account WHERE " +
               "userName = '{0}'", user_username);

            //Setting up Database connection with the Class
            int numRows = 0;
            acctTable.Clear();
            acctTable = dbMgr.getData(userCheckSql, out numRows);


            //  Checka The unique value from the UserID / Unique Identifier.
            //  If not unique, display a message stating account exists.
            if (numRows == 1)
            {
                string modAccId = acctTable.Rows[0]["acc_id"].ToString();
                if (!GlobalData.accId.Equals(modAccId))
                {
                    MessageBox.Show("User exist with that username, select another username. ");
                    return false;
                }
            }
            else   
            {
                return true;
            }

            return false;

        }
      

        // This method handles all of the modification to database. Uses an UPDATE statement.
        public bool ModAcc() 
        {
            bool testedUser = checkUser();
            

            int rowsInserted = 0;
            int x = 1;
            // If the validation for update is true
            if (testedUser == true && x.Equals(1))
            {
                //Build SQL Update Statement
                string accUpdSql = String.Format("UPDATE Account SET " +
                    "userName = '{0}',password ='{1}' ,email='{2}',phoneNum='{3}'," +
                    "firstName = '{4}',lastName = '{5}',accType = '{6}', userID = '{7}'" +
                    "WHERE acc_id = '{8}'", user_username, user_password, user_email, 
                    user_Pnumber, fName, lName, accType, uniqueIdentifier, GlobalData.accId);


                //Test UPDATE SQL STATEMENT
                MessageBox.Show(accUpdSql);
                MessageBox.Show("Your username is  " + user_username + " @ accid of : " + GlobalData.accId);


                rowsInserted = dbMgr.putData(accUpdSql);
                MessageBox.Show("Inserting Record into database");
                MessageBox.Show("Update Succeeded.");
                return true;
            }


            else 
            {
                //MessageBox.Show("Account Update Failed");
                return false;
            }
                           

        }
        
        // Loads Current user account data based off accid
        public void loadUserAccountData() 
        {

           


            //Utilize SQL STATEMENT to select all data for current user
            string loadedUser = String.Format("SELECT * from Account WHERE " + "acc_id = '{0}'", GlobalData.accId);
        

            // Make call to DB Browser and check results 
            int numRows = 0;
            acctTable.Clear();
            acctTable = dbMgr.getData(loadedUser, out numRows);

            // If user exist display the user details
            if (numRows == 1)
            {
                //Assign DataTable / AccTable values to class variables
                user_username = acctTable.Rows[0]["userName"].ToString();
                user_password = acctTable.Rows[0]["password"].ToString();
                user_email = acctTable.Rows[0]["email"].ToString();
                user_Pnumber = acctTable.Rows[0]["phoneNum"].ToString();
                fName = acctTable.Rows[0]["firstName"].ToString();
                lName = acctTable.Rows[0]["lastName"].ToString();
                accType = acctTable.Rows[0]["accType"].ToString();

                //============================================================================
                // The following data was tested and verified, user information was retrieved 
                // TEST for retrieved data 
                /*MessageBox.Show(user_username + " " + user_password);
                MessageBox.Show(user_email + " " + user_Pnumber);
                MessageBox.Show(fName + " " + lName);
                MessageBox.Show(accType);
                */
                //
               
            }
            else 
            {
                MessageBox.Show("The Number of Rows integer located in the loadUserAccountData method of the AccData class has failed" +
                    " Rows are not Equal to One");
               
            }
        }
 
        
            
        
    }
}
