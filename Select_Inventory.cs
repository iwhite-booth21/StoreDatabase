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
        public Select_Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void Modify_Inventory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (modInv == null || modInv.IsDisposed)
            {
                modInv = new ModifyInventory();
            }
            modInv.Show();
        }

        private void userCancelInventoryBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
