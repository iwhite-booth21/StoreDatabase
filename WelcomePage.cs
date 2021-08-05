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

        private void userLogOutLLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
