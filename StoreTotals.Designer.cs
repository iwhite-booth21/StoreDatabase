namespace StoreDatabase
{
    partial class StoreTotals
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
            this.AccTotLBL = new System.Windows.Forms.Label();
            this.EndBalLBL = new System.Windows.Forms.Label();
            this.AccRspTBOX = new System.Windows.Forms.TextBox();
            this.EndBalRspTBOX = new System.Windows.Forms.TextBox();
            this.AuditLBL = new System.Windows.Forms.LinkLabel();
            this.LeaveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccTotLBL
            // 
            this.AccTotLBL.AutoSize = true;
            this.AccTotLBL.Location = new System.Drawing.Point(48, 27);
            this.AccTotLBL.Name = "AccTotLBL";
            this.AccTotLBL.Size = new System.Drawing.Size(140, 20);
            this.AccTotLBL.TabIndex = 0;
            this.AccTotLBL.Text = "Accounting Totals:";
            // 
            // EndBalLBL
            // 
            this.EndBalLBL.AutoSize = true;
            this.EndBalLBL.Location = new System.Drawing.Point(48, 77);
            this.EndBalLBL.Name = "EndBalLBL";
            this.EndBalLBL.Size = new System.Drawing.Size(133, 20);
            this.EndBalLBL.TabIndex = 1;
            this.EndBalLBL.Text = "Ending Balances:";
            // 
            // AccRspTBOX
            // 
            this.AccRspTBOX.Location = new System.Drawing.Point(245, 27);
            this.AccRspTBOX.Name = "AccRspTBOX";
            this.AccRspTBOX.Size = new System.Drawing.Size(190, 26);
            this.AccRspTBOX.TabIndex = 2;
            // 
            // EndBalRspTBOX
            // 
            this.EndBalRspTBOX.Location = new System.Drawing.Point(245, 77);
            this.EndBalRspTBOX.Name = "EndBalRspTBOX";
            this.EndBalRspTBOX.Size = new System.Drawing.Size(190, 26);
            this.EndBalRspTBOX.TabIndex = 3;
            // 
            // AuditLBL
            // 
            this.AuditLBL.AutoSize = true;
            this.AuditLBL.LinkColor = System.Drawing.Color.Red;
            this.AuditLBL.Location = new System.Drawing.Point(134, 139);
            this.AuditLBL.Name = "AuditLBL";
            this.AuditLBL.Size = new System.Drawing.Size(195, 20);
            this.AuditLBL.TabIndex = 4;
            this.AuditLBL.TabStop = true;
            this.AuditLBL.Text = "Audit Balances and Total?";
            this.AuditLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuditLBL_LinkClicked);
            // 
            // LeaveBTN
            // 
            this.LeaveBTN.Location = new System.Drawing.Point(156, 219);
            this.LeaveBTN.Name = "LeaveBTN";
            this.LeaveBTN.Size = new System.Drawing.Size(173, 35);
            this.LeaveBTN.TabIndex = 5;
            this.LeaveBTN.Text = "Leave Page";
            this.LeaveBTN.UseVisualStyleBackColor = true;
            this.LeaveBTN.Click += new System.EventHandler(this.LeaveBTN_Click);
            // 
            // StoreTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 277);
            this.Controls.Add(this.LeaveBTN);
            this.Controls.Add(this.AuditLBL);
            this.Controls.Add(this.EndBalRspTBOX);
            this.Controls.Add(this.AccRspTBOX);
            this.Controls.Add(this.EndBalLBL);
            this.Controls.Add(this.AccTotLBL);
            this.Name = "StoreTotals";
            this.Text = "StoreTotals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccTotLBL;
        private System.Windows.Forms.Label EndBalLBL;
        private System.Windows.Forms.TextBox AccRspTBOX;
        private System.Windows.Forms.TextBox EndBalRspTBOX;
        private System.Windows.Forms.LinkLabel AuditLBL;
        private System.Windows.Forms.Button LeaveBTN;
    }
}