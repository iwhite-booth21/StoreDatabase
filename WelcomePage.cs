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
        CreateCustomerServiceIssue cusService;
        Cart userCart;
        Select_Inventory userInventory;
        ViewCustomerServiceIssue viewIssue;
        SelectDepartment selDept;
        StoreTotals storetot;
        ViewDepartment vDept;




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
            if (viewIssue == null || viewIssue.IsDisposed)
            {
                viewIssue = new ViewCustomerServiceIssue();
            }
            viewIssue.Show();
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
              
                MessageBox.Show("Employee User");

                if (userInventory == null || userInventory.IsDisposed)
                {
                    userInventory = new Select_Inventory();
                }
                userInventory.Show();
            
          
        }

        private void CreateIssueLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cusService == null || cusService.IsDisposed) 
            {
                cusService = new CreateCustomerServiceIssue();
            }
            cusService.Show();
        }

        private void userLogOutLLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void DepartmentLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selDept == null || selDept.IsDisposed)
            {
                selDept = new SelectDepartment();
            }
            selDept.Show();

        }

        private void TotalsLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (storetot == null || storetot.IsDisposed)
            {
                storetot = new StoreTotals();
            }
            storetot.Show();
        }

        private void vDeptLNK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (vDept == null || vDept.IsDisposed)
            {
                vDept = new ViewDepartment();
            }
            vDept.Show();
        }
    }
}
