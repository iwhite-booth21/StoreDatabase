
namespace StoreDatabase
{
    partial class ModifyInventory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Submit_Changes_BTN = new System.Windows.Forms.Button();
            this.Inventory_Mod_Cancel_BTN = new System.Windows.Forms.Button();
            this.Emp_Mod_Inv_LBL = new System.Windows.Forms.Label();
            this.CreateInventoryItem_LNK = new System.Windows.Forms.LinkLabel();
            this.ModifyItemLBL = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store_Inventory_Item";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Sample Item One",
            "Sample Item Two",
            "Sample Item Three"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(222, 188);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Submit_Changes_BTN
            // 
            this.Submit_Changes_BTN.Location = new System.Drawing.Point(26, 454);
            this.Submit_Changes_BTN.Name = "Submit_Changes_BTN";
            this.Submit_Changes_BTN.Size = new System.Drawing.Size(149, 60);
            this.Submit_Changes_BTN.TabIndex = 0;
            this.Submit_Changes_BTN.Text = "Submit Changes";
            this.Submit_Changes_BTN.UseVisualStyleBackColor = true;
            this.Submit_Changes_BTN.Click += new System.EventHandler(this.Submit_Changes_BTN_Click);
            // 
            // Inventory_Mod_Cancel_BTN
            // 
            this.Inventory_Mod_Cancel_BTN.Location = new System.Drawing.Point(244, 454);
            this.Inventory_Mod_Cancel_BTN.Name = "Inventory_Mod_Cancel_BTN";
            this.Inventory_Mod_Cancel_BTN.Size = new System.Drawing.Size(129, 60);
            this.Inventory_Mod_Cancel_BTN.TabIndex = 1;
            this.Inventory_Mod_Cancel_BTN.Text = "Cancel";
            this.Inventory_Mod_Cancel_BTN.UseVisualStyleBackColor = true;
            this.Inventory_Mod_Cancel_BTN.Click += new System.EventHandler(this.Inventory_Mod_Cancel_BTN_Click);
            // 
            // Emp_Mod_Inv_LBL
            // 
            this.Emp_Mod_Inv_LBL.AutoSize = true;
            this.Emp_Mod_Inv_LBL.Location = new System.Drawing.Point(19, 35);
            this.Emp_Mod_Inv_LBL.Name = "Emp_Mod_Inv_LBL";
            this.Emp_Mod_Inv_LBL.Size = new System.Drawing.Size(237, 20);
            this.Emp_Mod_Inv_LBL.TabIndex = 2;
            this.Emp_Mod_Inv_LBL.Text = "Please Make Inventory Changes";
            // 
            // CreateInventoryItem_LNK
            // 
            this.CreateInventoryItem_LNK.AutoSize = true;
            this.CreateInventoryItem_LNK.Location = new System.Drawing.Point(104, 544);
            this.CreateInventoryItem_LNK.Name = "CreateInventoryItem_LNK";
            this.CreateInventoryItem_LNK.Size = new System.Drawing.Size(206, 20);
            this.CreateInventoryItem_LNK.TabIndex = 3;
            this.CreateInventoryItem_LNK.TabStop = true;
            this.CreateInventoryItem_LNK.Text = "Create a new inventory Item";
            this.CreateInventoryItem_LNK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateInventoryItem_LNK_LinkClicked);
            // 
            // ModifyItemLBL
            // 
            this.ModifyItemLBL.AutoSize = true;
            this.ModifyItemLBL.LinkColor = System.Drawing.Color.Red;
            this.ModifyItemLBL.Location = new System.Drawing.Point(133, 404);
            this.ModifyItemLBL.Name = "ModifyItemLBL";
            this.ModifyItemLBL.Size = new System.Drawing.Size(158, 20);
            this.ModifyItemLBL.TabIndex = 5;
            this.ModifyItemLBL.TabStop = true;
            this.ModifyItemLBL.Text = "Modify Selected Item";
            this.ModifyItemLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ModifyItemLBL_LinkClicked);
            // 
            // ModifyInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 628);
            this.Controls.Add(this.ModifyItemLBL);
            this.Controls.Add(this.CreateInventoryItem_LNK);
            this.Controls.Add(this.Emp_Mod_Inv_LBL);
            this.Controls.Add(this.Inventory_Mod_Cancel_BTN);
            this.Controls.Add(this.Submit_Changes_BTN);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifyInventory";
            this.Text = "ModifyInventory";
            this.Load += new System.EventHandler(this.ModifyInventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Submit_Changes_BTN;
        private System.Windows.Forms.Button Inventory_Mod_Cancel_BTN;
        private System.Windows.Forms.Label Emp_Mod_Inv_LBL;
        private System.Windows.Forms.LinkLabel CreateInventoryItem_LNK;
        private System.Windows.Forms.LinkLabel ModifyItemLBL;
    }
}