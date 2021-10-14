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
            this.userLogOutLLBL.Location = new System.Drawing.Point(64, 351);
            this.userLogOutLLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLogOutLLBL.Name = "userLogOutLLBL";
            this.userLogOutLLBL.Size = new System.Drawing.Size(120, 36);
            this.userLogOutLLBL.TabIndex = 2;
            this.userLogOutLLBL.TabStop = true;
            this.userLogOutLLBL.Text = "Log Out";
            // 
            // CustomerServLBL
            // 
            this.CustomerServLBL.AutoSize = true;
            this.CustomerServLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerServLBL.Location = new System.Drawing.Point(64, 184);
            this.CustomerServLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerServLBL.Name = "CustomerServLBL";
            this.CustomerServLBL.Size = new System.Drawing.Size(238, 36);
            this.CustomerServLBL.TabIndex = 3;
            this.CustomerServLBL.TabStop = true;
            this.CustomerServLBL.Text = "Customer Service";
            this.CustomerServLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CustomerServLBL_LinkClicked);
            // 
            // CartLBL
            // 
            this.CartLBL.AutoSize = true;
            this.CartLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartLBL.Location = new System.Drawing.Point(64, 242);
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
            this.InventoryLBL.Location = new System.Drawing.Point(64, 296);
            this.InventoryLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InventoryLBL.Name = "InventoryLBL";
            this.InventoryLBL.Size = new System.Drawing.Size(136, 36);
            this.InventoryLBL.TabIndex = 5;
            this.InventoryLBL.TabStop = true;
            this.InventoryLBL.Text = "Inventory";
            this.InventoryLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InventoryLBL_LinkClicked);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 416);
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
    }
}