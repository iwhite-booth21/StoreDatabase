
namespace StoreDatabase
{
    partial class CreateCustomerServiceIssue
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
            this.HelpMeTXT = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.vCustServLBL = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // HelpMeTXT
            // 
            this.HelpMeTXT.AutoSize = true;
            this.HelpMeTXT.Location = new System.Drawing.Point(12, 9);
            this.HelpMeTXT.Name = "HelpMeTXT";
            this.HelpMeTXT.Size = new System.Drawing.Size(397, 20);
            this.HelpMeTXT.TabIndex = 0;
            this.HelpMeTXT.Text = "Please help us help you: Leave a issue in the box below";
            this.HelpMeTXT.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 253);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(12, 337);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(139, 64);
            this.submitBTN.TabIndex = 2;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(270, 337);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(139, 64);
            this.CancelBTN.TabIndex = 3;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // vCustServLBL
            // 
            this.vCustServLBL.AutoSize = true;
            this.vCustServLBL.Location = new System.Drawing.Point(79, 421);
            this.vCustServLBL.Name = "vCustServLBL";
            this.vCustServLBL.Size = new System.Drawing.Size(248, 20);
            this.vCustServLBL.TabIndex = 4;
            this.vCustServLBL.TabStop = true;
            this.vCustServLBL.Text = "View All Customer Service Issues:";
            // 
            // CustomerService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.vCustServLBL);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HelpMeTXT);
            this.Name = "CustomerService";
            this.Text = "CustomerService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelpMeTXT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.LinkLabel vCustServLBL;
    }
}