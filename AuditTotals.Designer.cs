namespace StoreDatabase
{
    partial class AuditTotals
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
            this.ConfirmBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccTotLBL
            // 
            this.AccTotLBL.AutoSize = true;
            this.AccTotLBL.Location = new System.Drawing.Point(79, 38);
            this.AccTotLBL.Name = "AccTotLBL";
            this.AccTotLBL.Size = new System.Drawing.Size(140, 20);
            this.AccTotLBL.TabIndex = 6;
            this.AccTotLBL.Text = "Accounting Totals:";
            // 
            // EndBalLBL
            // 
            this.EndBalLBL.AutoSize = true;
            this.EndBalLBL.Location = new System.Drawing.Point(79, 88);
            this.EndBalLBL.Name = "EndBalLBL";
            this.EndBalLBL.Size = new System.Drawing.Size(133, 20);
            this.EndBalLBL.TabIndex = 7;
            this.EndBalLBL.Text = "Ending Balances:";
            // 
            // AccRspTBOX
            // 
            this.AccRspTBOX.Location = new System.Drawing.Point(276, 38);
            this.AccRspTBOX.Name = "AccRspTBOX";
            this.AccRspTBOX.Size = new System.Drawing.Size(190, 26);
            this.AccRspTBOX.TabIndex = 8;
            // 
            // EndBalRspTBOX
            // 
            this.EndBalRspTBOX.Location = new System.Drawing.Point(276, 88);
            this.EndBalRspTBOX.Name = "EndBalRspTBOX";
            this.EndBalRspTBOX.Size = new System.Drawing.Size(190, 26);
            this.EndBalRspTBOX.TabIndex = 9;
            // 
            // ConfirmBTN
            // 
            this.ConfirmBTN.Location = new System.Drawing.Point(177, 156);
            this.ConfirmBTN.Name = "ConfirmBTN";
            this.ConfirmBTN.Size = new System.Drawing.Size(173, 35);
            this.ConfirmBTN.TabIndex = 11;
            this.ConfirmBTN.Text = "Confirm Changes";
            this.ConfirmBTN.UseVisualStyleBackColor = true;
            // 
            // AuditTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 231);
            this.Controls.Add(this.ConfirmBTN);
            this.Controls.Add(this.EndBalRspTBOX);
            this.Controls.Add(this.AccRspTBOX);
            this.Controls.Add(this.EndBalLBL);
            this.Controls.Add(this.AccTotLBL);
            this.Name = "AuditTotals";
            this.Text = "AuditTotals";
            this.Load += new System.EventHandler(this.AuditTotals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccTotLBL;
        private System.Windows.Forms.Label EndBalLBL;
        private System.Windows.Forms.TextBox AccRspTBOX;
        private System.Windows.Forms.TextBox EndBalRspTBOX;
        private System.Windows.Forms.Button ConfirmBTN;
    }
}