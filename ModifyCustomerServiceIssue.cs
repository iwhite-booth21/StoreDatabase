﻿using System;
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
    public partial class ModifyCustomerServiceIssue : Form
    {
        DatabaseMgrSQLite dbMgr;
        DataTable InvTable = new DataTable();
        public ModifyCustomerServiceIssue()
        {
            InitializeComponent();
        }
    }
}
