namespace StoreDatabase
{
    partial class WelcomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.greetUserLBL = new System.Windows.Forms.Label();
            this.userModAccLLBL = new System.Windows.Forms.LinkLabel();
            this.userLogOutLLBL = new System.Windows.Forms.LinkLabel();
            this.CustomerServLBL = new System.Windows.Forms.LinkLabel();
            this.CartLBL = new System.Windows.Forms.LinkLabel();
            this.InventoryLBL = new System.Windows.Forms.LinkLabel();
            this.CreateIssueLBL = new System.Windows.Forms.LinkLabel();
            this.DepartmentLBL = new System.Windows.Forms.LinkLabel();
            this.TotalsLBL = new System.Windows.Forms.LinkLabel();
            this.vDeptLNK = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // greetUserLBL
            // 
            this.greetUserLBL.AutoSize = true;
            this.greetUserLBL.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetUserLBL.Location = new System.Drawing.Point(62, 54);
            this.greetUserLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greetUserLBL.Name = "greetUserLBL";
            this.greetUserLBL.Size = new System.Drawing.Size(764, 47);
            this.greetUserLBL.TabIndex = 0;
            this.greetUserLBL.Text = "Welcome User, What would you like to do?";
            // 
            // userModAccLLBL
            // 
            this.userModAccLLBL.AutoSize = true;
            this.userModAccLLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userModAccLLBL.Location = new System.Drawing.Point(64, 119);
            this.userModAccLLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userModAccLLBL.Name = "userModAccLLBL";
            this.userModAccLLBL.Size = new System.Drawing.Size(220, 36);
            this.userModAccLLBL.TabIndex = 1;
            this.userModAccLLBL.TabStop = true;
            this.userModAccLLBL.Text = "Modify Account";
            this.userModAccLLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userModAccLLBL_LinkClicked);
            // 
            // userLogOutLLBL
            // 
            this.userLogOutLLBL.AutoSize = true;
            this.userLogOutLLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogOutLLBL.Location = new System.Drawing.Point(64, 596);
            this.userLogOutLLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLogOutLLBL.Name = "userLogOutLLBL";
            this.userLogOutLLBL.Size = new System.Drawing.Size(120, 36);
            this.userLogOutLLBL.TabIndex = 2;
            this.userLogOutLLBL.TabStop = true;
            this.userLogOutLLBL.Text = "Log Out";
            this.userLogOutLLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userLogOutLLBL_LinkClicked);
            // 
            // CustomerServLBL
            // 
            this.CustomerServLBL.AutoSize = true;
            this.CustomerServLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerServLBL.Location = new System.Drawing.Point(64, 184);
            this.CustomerServLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerServLBL.Name = "CustomerServLBL";
            this.CustomerServLBL.Size = new System.Drawing.Size(383, 36);
            this.CustomerServLBL.TabIndex = 3;
            this.CustomerServLBL.TabStop = true;
            this.CustomerServLBL.Text = "View Customer Service Issue";
            this.CustomerServLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CustomerServLBL_LinkClicked);
            // 
            // CartLBL
            // 
            this.CartLBL.AutoSize = true;
            this.CartLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartLBL.Location = new System.Drawing.Point(64, 301);
            this.CartLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CartLBL.Name = "CartLBL";
            this.CartLBL.Size = new System.Drawing.Size(70, 36);
            this.CartLBL.TabIndex = 4;
            this.CartLBL.TabStop = true;
            this.CartLBL.Text = "Cart";
            this.CartLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CartLBL_LinkClicked);
            // 
            // InventoryLBL
            // 
            this.InventoryLBL.AutoSize = true;
            this.InventoryLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLBL.Location = new System.Drawing.Point(64, 355);
            this.InventoryLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InventoryLBL.Name = "InventoryLBL";
            this.InventoryLBL.Size = new System.Drawing.Size(136, 36);
            this.InventoryLBL.TabIndex = 5;
            this.InventoryLBL.TabStop = true;
            this.InventoryLBL.Text = "Inventory";
            this.InventoryLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InventoryLBL_LinkClicked);
            // 
            // CreateIssueLBL
            // 
            this.CreateIssueLBL.AutoSize = true;
            this.CreateIssueLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateIssueLBL.Location = new System.Drawing.Point(64, 236);
            this.CreateIssueLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateIssueLBL.Name = "CreateIssueLBL";
            this.CreateIssueLBL.Size = new System.Drawing.Size(399, 36);
            this.CreateIssueLBL.TabIndex = 6;
            this.CreateIssueLBL.TabStop = true;
            this.CreateIssueLBL.Text = "Create Customer Service Issue";
            this.CreateIssueLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateIssueLBL_LinkClicked);
            // 
            // DepartmentLBL
            // 
            this.DepartmentLBL.AutoSize = true;
            this.DepartmentLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLBL.Location = new System.Drawing.Point(64, 422);
            this.DepartmentLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentLBL.Name = "DepartmentLBL";
            this.DepartmentLBL.Size = new System.Drawing.Size(163, 36);
            this.DepartmentLBL.TabIndex = 7;
            this.DepartmentLBL.TabStop = true;
            this.DepartmentLBL.Text = "Department";
            this.DepartmentLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DepartmentLBL_LinkClicked);
            // 
            // TotalsLBL
            // 
            this.TotalsLBL.AutoSize = true;
            this.TotalsLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalsLBL.Location = new System.Drawing.Point(64, 541);
            this.TotalsLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalsLBL.Name = "TotalsLBL";
            this.TotalsLBL.Size = new System.Drawing.Size(241, 36);
            this.TotalsLBL.TabIndex = 8;
            this.TotalsLBL.TabStop = true;
            this.TotalsLBL.Text = "View Store Totals";
            this.TotalsLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TotalsLBL_LinkClicked);
            // 
            // vDeptLNK
            // 
            this.vDeptLNK.AutoSize = true;
            this.vDeptLNK.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vDeptLNK.Location = new System.Drawing.Point(64, 479);
            this.vDeptLNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vDeptLNK.Name = "vDeptLNK";
            this.vDeptLNK.Size = new System.Drawing.Size(325, 36);
            this.vDeptLNK.TabIndex = 9;
            this.vDeptLNK.TabStop = true;
            this.vDeptLNK.Text = "View Store Departments";
            this.vDeptLNK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.vDeptLNK_LinkClicked);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 688);
            this.Controls.Add(this.vDeptLNK);
            this.Controls.Add(this.TotalsLBL);
            this.Controls.Add(this.DepartmentLBL);
            this.Controls.Add(this.CreateIssueLBL);
            this.Controls.Add(this.InventoryLBL);
            this.Controls.Add(this.CartLBL);
            this.Controls.Add(this.CustomerServLBL);
            this.Controls.Add(this.userLogOutLLBL);
            this.Controls.Add(this.userModAccLLBL);
            this.Controls.Add(this.greetUserLBL);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetUserLBL;
        private System.Windows.Forms.LinkLabel userModAccLLBL;
        private System.Windows.Forms.LinkLabel userLogOutLLBL;
        private System.Windows.Forms.LinkLabel CustomerServLBL;
        private System.Windows.Forms.LinkLabel CartLBL;
        private System.Windows.Forms.LinkLabel InventoryLBL;
        private System.Windows.Forms.LinkLabel CreateIssueLBL;
        private System.Windows.Forms.LinkLabel DepartmentLBL;
        private System.Windows.Forms.LinkLabel TotalsLBL;
        private System.Windows.Forms.LinkLabel vDeptLNK;
    }
}