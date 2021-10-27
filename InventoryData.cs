using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace StoreDatabase
{
    class InventoryData
    {
        //  Add variables for connecting to database
        DatabaseMgrSQLite dbMgr = new DatabaseMgrSQLite();
        DataTable InventoryTable = new DataTable();

        //Data variables for storing values from the form
        public string ItemType;
        public string Department;
        public int UPC;
        public double Price;

        // Class Constructor
        public InventoryData()
        {

      

        }

        // This method check whether a user is unique by using sql select statement.
        // Utilizes the UserID field which is comprised of username + password.
        public bool UniqueInventoryItem()
        {


            //======================================================================================
            //  This variable was originally created to generate a username password combination.
            //  Possible future for the variable may be possible.

            string InventorySelSql = String.Format("SELECT * from Inventory WHERE " +
                    "InventoryId = {0}", GlobalData.InventoryId);

            //Setting up Database connection with the Class
            int numRows = 0;
            InventoryTable.Clear();
            InventoryTable = dbMgr.getData(InventorySelSql, out numRows);

            //  Checka The unique value from the InventoryID / Unique Identifier.
            //  If not unique, display a message stating account exists.
            if (numRows == 1)
            {
                MessageBox.Show("Item Exists, Try Another Item.");     // Can be removed
                return false;
            }
            //  If User Unique, display a message stating account generation.
            else
            {
                MessageBox.Show("Generating new item");  // Can be removed 
                return true;
            }




        }




        // This method creates a new record into database. User an INSERT statement.
        public bool InsertInventoryData()
        {
         

            //Build SQL Insert Statement
            string InventoryInSql = String.Format("INSERT INTO Inventory(ItemType,Department,UPC,Price,InventoryId)VALUES" +
                    "('{0}','{1}',{2},{3},'{4}')", ItemType, Department, UPC, Price, GlobalData.InventoryId);


            // Step 1: Check if all required fields have a value. If any values are not present, return false.
            // Use a string to insert the data, however first you need a insert statement
            // Utilize a select statement to generate the user/pass combination



            // Step 2: Check if username/password combination is unique.
            // The first step of this category is to create a select statement that grabs the user and password values.
            // Secondly, create a value to hold this unique account identifier.

            bool uniqueInventoryID = UniqueInventoryItem();


            //======================================================================================
            //  Checks if the values are empty. If so displays a message to fill in the information.
            //  Checks variable valaues directly. 
            if (ItemType.Equals("") || Department.Equals("") ||
                UPC.Equals("") || Price.Equals(""))
            {
                MessageBox.Show("Please fill in information");

                return false;

            }

            //  Check uniqueID return value to determine if user is unique.
            //  Inserts data into database if unique.
            else if (uniqueInventoryID == true)
            {
                int rowsInserted = 0;
                rowsInserted = dbMgr.putData(InventoryInSql);
                MessageBox.Show("Inserting Record into inventory database");
                return true;
            }
            else if (uniqueInventoryID == false)
            {
                MessageBox.Show("Item Exists, please create a new item");
                return false;

            }
            // To complete the program for insertaccdata, this addition bool return was needed.
            // No message box is necessary
            else
            {
                return false;
            }



        }





        public bool checkItem()
        {

            string InventoryCheckSql = String.Format("SELECT * from Account WHERE " +
               "InventoryId = '{0}'", GlobalData.InventoryId);

            //Setting up Database connection with the Class
            int numRows = 0;
            InventoryTable.Clear();
            InventoryTable = dbMgr.getData(InventoryCheckSql, out numRows);


            //  Checka The unique value from the UserID / Unique Identifier.
            //  If not unique, display a message stating account exists.
            if (numRows == 1)
            {
                string modInventoryId = InventoryTable.Rows[0]["InventoryId"].ToString();
                if (!GlobalData.accId.Equals(modInventoryId))
                {
                    MessageBox.Show("Item exist with that information, select specific item information. ");
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
        public bool ModInventory()
        {
            bool testedItem = checkItem();


            int rowsInserted = 0;
            int x = 1;
            // If the validation for update is true
            if (testedItem == true && x.Equals(1))
            {
                //Build SQL Update Statement
                string InventoryUpdateSQL = String.Format("UPDATE Inventory SET " +
                    "ItemType = '{0}',Department ='{1}' ,UPC ={2},Price={3}," +
                    "WHERE InvenrtoryId = '{0}'", ItemType, Department, UPC,
                    Price, GlobalData.InventoryId);


                //Test UPDATE SQL STATEMENT
                MessageBox.Show(InventoryUpdateSQL);
                MessageBox.Show("Your Item is  " + ItemType + " @ InventoryId of : " + GlobalData.InventoryId);


                rowsInserted = dbMgr.putData(InventoryUpdateSQL);
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
        // This Area is under construction, current setup will not work for multiple inventory items

        public void loadItemtData()
        {




            //Utilize SQL STATEMENT to select all data for current user
            string loadInventory = String.Format("SELECT * from Account WHERE " + "InventoryId = '{0}'", GlobalData.InventoryId);


            // Make call to DB Browser and check results 
            int numRows = 0;
            InventoryTable.Clear();
            InventoryTable = dbMgr.getData(loadInventory, out numRows);

            // If user exist display the user details
            if (numRows == 1)
            {
                //Assign DataTable / AccTable values to class variables
                ItemType = InventoryTable.Rows[0]["ItemType"].ToString();
                Department = InventoryTable.Rows[0]["Department"].ToString();
                UPC = int.Parse(InventoryTable.Rows[0]["UPC"].ToString());
                Price = double.Parse(InventoryTable.Rows[0]["Price"].ToString());

               
                //============================================================================
                
               
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
