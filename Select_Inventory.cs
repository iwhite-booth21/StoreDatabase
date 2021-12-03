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
    public partial class Select_Inventory : Form
    {
        ModifyInventory modInv = new ModifyInventory();
        DatabaseMgrSQLite dbMgr;
        DataTable InvTable = new DataTable();

        public Select_Inventory()
        {
            InitializeComponent();

            //Create database manager
            dbMgr = new DatabaseMgrSQLite();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // Load the inventory list
            LoadInventoryItems();

        }

        public void LoadInventoryItems() 
        {
            // Clear the existing inventory list first
            checkedListBox1.Items.Clear();

            // Retrieve inventory items via loop
            string sqlStr = String.Format("SELECT ItemType from Inventory ");

            int numRows = 0;    //Store the count of returned rows
            InvTable.Clear(); //Removes current values from table
            InvTable = dbMgr.getData(sqlStr, out numRows);


            // Populate the inventory list with retrieved items
            // N = numRows - 1
            // checkedListBox.Items.Add()

            if (numRows == 0)
            {
                MessageBox.Show("No Inventory Available");
            }
            else 
            {
                for(int i = 0; i <= numRows - 1; i++)
                {

                   checkedListBox1.Items.Add(InvTable.Rows[i]["ItemType"].ToString());
                }
            }
            
        }

        private void Modify_Inventory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (modInv == null || modInv.IsDisposed)
            {
                modInv = new ModifyInventory();
            }
            modInv.Show();
            this.Close();
        }

        private void userCancelInventoryBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userInventorySubmitBTN_Click(object sender, EventArgs e)
        {
            // Set up a SQL insert for a cross refence table between Inventory and Cart

            
            
            
            // Set up a message that confirms the outcome of the SQL Statement
        }
    }
}
