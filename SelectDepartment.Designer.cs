namespace StoreDatabase
{
    partial class SelectDepartment
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
            this.CancelBTN = new System.Windows.Forms.Button();
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.CreateDptLBL = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(62, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 287);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Selection";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Department One",
            "Department Two",
            "Department Three",
            "Department Four"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 25);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(276, 211);
            this.checkedListBox1.TabIndex = 0;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(311, 406);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(143, 45);
            this.CancelBTN.TabIndex = 5;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.userCancelInventoryBTN_Click);
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.Location = new System.Drawing.Point(33, 406);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(143, 45);
            this.SubmitBTN.TabIndex = 4;
            this.SubmitBTN.Text = "Submit";
            this.SubmitBTN.UseVisualStyleBackColor = true;
            // 
            // CreateDptLBL
            // 
            this.CreateDptLBL.AutoSize = true;
            this.CreateDptLBL.Location = new System.Drawing.Point(150, 360);
            this.CreateDptLBL.Name = "CreateDptLBL";
            this.CreateDptLBL.Size = new System.Drawing.Size(146, 20);
            this.CreateDptLBL.TabIndex = 7;
            this.CreateDptLBL.TabStop = true;
            this.CreateDptLBL.Text = "Create Department";
            this.CreateDptLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateDptLBL_LinkClicked);
            // 
            // SelectDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 489);
            this.Controls.Add(this.CreateDptLBL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SubmitBTN);
            this.Name = "SelectDepartment";
            this.Text = "SelectDepartment";
            this.Load += new System.EventHandler(this.SelectDepartment_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button SubmitBTN;
        private System.Windows.Forms.LinkLabel CreateDptLBL;
    }
}