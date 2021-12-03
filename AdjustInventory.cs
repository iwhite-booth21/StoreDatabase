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
    public partial class AdjustInventory : Form
    {
        DatabaseMgrSQLite dbMgr;
        DataTable InvTable = new DataTable();

        public AdjustInventory()
        {
            InitializeComponent();

            // Create Database Manager
            dbMgr = new DatabaseMgrSQLite();
        }

        private void AdjustInventory_Load(object sender, EventArgs e)
        {
            LoadModItem();
        }

        public void LoadModItem()
        {
           
            // Set up a List checker.


            // Use SQL String to get data
            String LoadItemSql = String.Format("SELECT * from Inventory WHERE " +
                "InventoryId = '{0}'", GlobalData.InventoryId);

            // Make Call to DB Browser 
            int numRows = 0;
            InvTable.Clear();
            InvTable = dbMgr.getData(LoadItemSql, out numRows);


            if (numRows == 1)
            {
                Mod_Department_RSP.Text = InvTable.Rows[0]["Department"].ToString();
                Mod_ItemType_RSP.Text = InvTable.Rows[0]["ItemType"].ToString();
                Mod_UPC_RSP.Text = InvTable.Rows[0]["UPC"].ToString();
                Mod_Price_RSP.Text = InvTable.Rows[0]["Price"].ToString();

            }
        }

        private void Mod_Inventory_Confirm_BTN_Click(object sender, EventArgs e)
        {
            int rowsInserted = 0;
            int x = 1;
            // Default bool set
            bool itemStatus = true;

            if (itemStatus == true && x.Equals(1))
            {
                string ItemUpdSql = String.Format("UPDATE Inventory SET " +
                    "ItemType = '{0}', Department = '{1}', UPC = {2}, Price = {3} " +
                    "WHERE InventoryId = '{4}'", Mod_ItemType_RSP.Text, Mod_Department_RSP.Text, Mod_UPC_RSP.Text, Mod_Price_RSP.Text, GlobalData.InventoryId);

                rowsInserted = dbMgr.putData(ItemUpdSql);

                MessageBox.Show("Modify Successful");

            }
        }

        


    }
}
