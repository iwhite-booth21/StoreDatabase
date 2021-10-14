
namespace StoreDatabase
{
    partial class Select_Inventory
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
            this.userInventorySubmitBTN = new System.Windows.Forms.Button();
            this.userCancelInventoryBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Modify_Inventory = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInventorySubmitBTN
            // 
            this.userInventorySubmitBTN.Location = new System.Drawing.Point(12, 362);
            this.userInventorySubmitBTN.Name = "userInventorySubmitBTN";
            this.userInventorySubmitBTN.Size = new System.Drawing.Size(143, 45);
            this.userInventorySubmitBTN.TabIndex = 0;
            this.userInventorySubmitBTN.Text = "Submit";
            this.userInventorySubmitBTN.UseVisualStyleBackColor = true;
            // 
            // userCancelInventoryBTN
            // 
            this.userCancelInventoryBTN.Location = new System.Drawing.Point(394, 362);
            this.userCancelInventoryBTN.Name = "userCancelInventoryBTN";
            this.userCancelInventoryBTN.Size = new System.Drawing.Size(143, 45);
            this.userCancelInventoryBTN.TabIndex = 1;
            this.userCancelInventoryBTN.Text = "Cancel";
            this.userCancelInventoryBTN.UseVisualStyleBackColor = true;
            this.userCancelInventoryBTN.Click += new System.EventHandler(this.userCancelInventoryBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 287);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store_Item_Selection";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Sample Item One",
            "Sample Item Two",
            "Sample Item Three",
            "Sample Item Four"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 25);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(276, 211);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Modify_Inventory
            // 
            this.Modify_Inventory.AutoSize = true;
            this.Modify_Inventory.Location = new System.Drawing.Point(217, 387);
            this.Modify_Inventory.Name = "Modify_Inventory";
            this.Modify_Inventory.Size = new System.Drawing.Size(109, 20);
            this.Modify_Inventory.TabIndex = 3;
            this.Modify_Inventory.TabStop = true;
            this.Modify_Inventory.Text = "Change Items";
            this.Modify_Inventory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Modify_Inventory_LinkClicked);
            // 
            // Select_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.Modify_Inventory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userCancelInventoryBTN);
            this.Controls.Add(this.userInventorySubmitBTN);
            this.Name = "Select_Inventory";
            this.Text = "Select Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userInventorySubmitBTN;
        private System.Windows.Forms.Button userCancelInventoryBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.LinkLabel Modify_Inventory;
    }
}