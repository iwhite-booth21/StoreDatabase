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
            this.SuspendLayout();
            // 
            // greetUserLBL
            // 
            this.greetUserLBL.AutoSize = true;
            this.greetUserLBL.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetUserLBL.Location = new System.Drawing.Point(62, 51);
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
            this.userModAccLLBL.Location = new System.Drawing.Point(64, 161);
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
            this.userLogOutLLBL.Location = new System.Drawing.Point(64, 224);
            this.userLogOutLLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLogOutLLBL.Name = "userLogOutLLBL";
            this.userLogOutLLBL.Size = new System.Drawing.Size(120, 36);
            this.userLogOutLLBL.TabIndex = 2;
            this.userLogOutLLBL.TabStop = true;
            this.userLogOutLLBL.Text = "Log Out";
            this.userLogOutLLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userLogOutLLBL_LinkClicked);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 395);
            this.Controls.Add(this.userLogOutLLBL);
            this.Controls.Add(this.userModAccLLBL);
            this.Controls.Add(this.greetUserLBL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetUserLBL;
        private System.Windows.Forms.LinkLabel userModAccLLBL;
        private System.Windows.Forms.LinkLabel userLogOutLLBL;
    }
}