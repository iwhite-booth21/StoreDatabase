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
    public partial class WelcomePage : Form
    {
        ModifyAccountForm modAccount;
        CustomerService cusService;
        Cart userCart;
        Select_Inventory userInventory;

        public WelcomePage()
        {
            InitializeComponent();
        }

        private void userModAccLLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (modAccount == null || modAccount.IsDisposed)
            {
                modAccount = new ModifyAccountForm();
            }
            modAccount.Show();
        }

        private void CustomerServLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cusService == null || cusService.IsDisposed)
            {
                cusService = new CustomerService();
            }
            cusService.Show();
        }

        private void CartLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (userCart == null || userCart.IsDisposed)
            {
                userCart = new Cart();
            }
            userCart.Show();

        }

        private void InventoryLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (userInventory == null || userInventory.IsDisposed)
            {
                userInventory = new Select_Inventory();
            }
            userInventory.Show();
        }
    }
}
