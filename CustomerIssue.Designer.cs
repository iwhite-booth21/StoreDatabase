
namespace StoreDatabase
{
    partial class CustomerIssue
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
            this.IssueTBOX = new System.Windows.Forms.TextBox();
            this.HelpMeTXT = new System.Windows.Forms.Label();
            this.CustIssue_Submit_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IssueTBOX
            // 
            this.IssueTBOX.Location = new System.Drawing.Point(39, 63);
            this.IssueTBOX.Multiline = true;
            this.IssueTBOX.Name = "IssueTBOX";
            this.IssueTBOX.Size = new System.Drawing.Size(397, 575);
            this.IssueTBOX.TabIndex = 2;
            this.IssueTBOX.TextChanged += new System.EventHandler(this.IssueTBOX_TextChanged);
            // 
            // HelpMeTXT
            // 
            this.HelpMeTXT.AutoSize = true;
            this.HelpMeTXT.Location = new System.Drawing.Point(35, 19);
            this.HelpMeTXT.Name = "HelpMeTXT";
            this.HelpMeTXT.Size = new System.Drawing.Size(240, 20);
            this.HelpMeTXT.TabIndex = 3;
            this.HelpMeTXT.Text = "We are dedicated to helping you,";
            // 
            // CustIssue_Submit_BTN
            // 
            this.CustIssue_Submit_BTN.Location = new System.Drawing.Point(121, 655);
            this.CustIssue_Submit_BTN.Name = "CustIssue_Submit_BTN";
            this.CustIssue_Submit_BTN.Size = new System.Drawing.Size(190, 40);
            this.CustIssue_Submit_BTN.TabIndex = 4;
            this.CustIssue_Submit_BTN.Text = "Submit Changes";
            this.CustIssue_Submit_BTN.UseVisualStyleBackColor = true;
            // 
            // CustomerIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 718);
            this.Controls.Add(this.CustIssue_Submit_BTN);
            this.Controls.Add(this.HelpMeTXT);
            this.Controls.Add(this.IssueTBOX);
            this.Name = "CustomerIssue";
            this.Text = "CustomerIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IssueTBOX;
        private System.Windows.Forms.Label HelpMeTXT;
        private System.Windows.Forms.Button CustIssue_Submit_BTN;
    }
}