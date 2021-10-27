
namespace StoreDatabase
{
    partial class ViewCustomerServiceIssue
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
            this.viewIssueTBOX = new System.Windows.Forms.TextBox();
            this.viewIssueLBL = new System.Windows.Forms.Label();
            this.modifyIssueLBL = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // viewIssueTBOX
            // 
            this.viewIssueTBOX.Enabled = false;
            this.viewIssueTBOX.Location = new System.Drawing.Point(133, 69);
            this.viewIssueTBOX.Multiline = true;
            this.viewIssueTBOX.Name = "viewIssueTBOX";
            this.viewIssueTBOX.Size = new System.Drawing.Size(497, 287);
            this.viewIssueTBOX.TabIndex = 0;
            // 
            // viewIssueLBL
            // 
            this.viewIssueLBL.AutoSize = true;
            this.viewIssueLBL.Location = new System.Drawing.Point(110, 21);
            this.viewIssueLBL.Name = "viewIssueLBL";
            this.viewIssueLBL.Size = new System.Drawing.Size(554, 20);
            this.viewIssueLBL.TabIndex = 1;
            this.viewIssueLBL.Text = "Here is a collection of all of your service issue, you can modify these if you li" +
    "ke:";
            // 
            // modifyIssueLBL
            // 
            this.modifyIssueLBL.AutoSize = true;
            this.modifyIssueLBL.Location = new System.Drawing.Point(262, 394);
            this.modifyIssueLBL.Name = "modifyIssueLBL";
            this.modifyIssueLBL.Size = new System.Drawing.Size(201, 20);
            this.modifyIssueLBL.TabIndex = 2;
            this.modifyIssueLBL.TabStop = true;
            this.modifyIssueLBL.Text = "Want to Modify your Issue?";
            this.modifyIssueLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.modifyIssueLBL_LinkClicked);
            // 
            // ViewCustomerServiceIssue
            // 
            this.ClientSize = new System.Drawing.Size(798, 447);
            this.Controls.Add(this.modifyIssueLBL);
            this.Controls.Add(this.viewIssueLBL);
            this.Controls.Add(this.viewIssueTBOX);
            this.Name = "ViewCustomerServiceIssue";
            this.Text = "ViewIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox viewIssueTBOX;
        private System.Windows.Forms.Label viewIssueLBL;
        private System.Windows.Forms.LinkLabel modifyIssueLBL;
    }
}