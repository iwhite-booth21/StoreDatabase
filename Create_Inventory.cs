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
    public partial class Create_Inventory : Form
    {
        public Create_Inventory()
        {
            InitializeComponent();
        }

        private void NewInventory_Confirm_BTN_Click(object sender, EventArgs e)
        {
            InventoryData ItemInfo = new InventoryData();
            ItemInfo.ItemType = ItemType_RSP.Text;
            ItemInfo.Department = Department_RSP.Text;
            ItemInfo.UPC = int.Parse(UPC_RSP.Text);
            ItemInfo.Price = double.Parse(Price_RSP.Text);

            // Attempt to insert the inventory item
           bool Inventory_result =  ItemInfo.InsertInventoryData();


            // If result is successful, Insert Item and shpw messagebox.
            if (Inventory_result == true)
            {
                string userSucceed = string.Format("Item Successful!  '{0}'", ItemInfo.ItemType);

                MessageBox.Show(userSucceed);


            }
            else if (Inventory_result == false) 
            {
                MessageBox.Show("There is a critical error occuring");    
            }

            else
            {
                MessageBox.Show("Inventory Item Creation Failed, try Again");
            }



        }
      
    private void NewInventoryCancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
