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
    public partial class ModifyInventory : Form
    {
        Create_Inventory CreateInv;
        DatabaseMgrSQLite dbMgr;
        DataTable InvTable = new DataTable();


        public ModifyInventory()
        {
            InitializeComponent();

            //Create database manager
            dbMgr = new DatabaseMgrSQLite();
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
                for (int i = 0; i <= numRows - 1; i++)
                {

                    checkedListBox1.Items.Add(InvTable.Rows[i]["ItemType"].ToString());
                }
            }

        }

        private void CreateInventoryItem_LNK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                if (CreateInv == null || CreateInv.IsDisposed)
                {
                    CreateInv = new Create_Inventory();
                }
                CreateInv.Show();
            }
        }

        private void ModifyInventory_Load(object sender, EventArgs e)
        {
            LoadInventoryItems();
        }
    }
}
