namespace StoreDatabase
{
    partial class LoginForm
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
            this.LoginBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.userResponseTBX = new System.Windows.Forms.TextBox();
            this.passwordResponseTBX = new System.Windows.Forms.TextBox();
            this.userLBL = new System.Windows.Forms.Label();
            this.passLBL = new System.Windows.Forms.Label();
            this.LoginPromptLBL = new System.Windows.Forms.Label();
            this.LoginGBX = new System.Windows.Forms.GroupBox();
            this.cafLinkLBL = new System.Windows.Forms.LinkLabel();
            this.LoginGBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(176, 251);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(112, 34);
            this.LoginBTN.TabIndex = 0;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(345, 251);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(112, 34);
            this.CancelBTN.TabIndex = 1;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // userResponseTBX
            // 
            this.userResponseTBX.Location = new System.Drawing.Point(176, 155);
            this.userResponseTBX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userResponseTBX.Name = "userResponseTBX";
            this.userResponseTBX.Size = new System.Drawing.Size(280, 27);
            this.userResponseTBX.TabIndex = 2;
            // 
            // passwordResponseTBX
            // 
            this.passwordResponseTBX.Location = new System.Drawing.Point(176, 193);
            this.passwordResponseTBX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordResponseTBX.Name = "passwordResponseTBX";
            this.passwordResponseTBX.Size = new System.Drawing.Size(280, 27);
            this.passwordResponseTBX.TabIndex = 3;
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.Location = new System.Drawing.Point(20, 159);
            this.userLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(86, 19);
            this.userLBL.TabIndex = 4;
            this.userLBL.Text = "Username:";
            // 
            // passLBL
            // 
            this.passLBL.AutoSize = true;
            this.passLBL.Location = new System.Drawing.Point(22, 197);
            this.passLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLBL.Name = "passLBL";
            this.passLBL.Size = new System.Drawing.Size(82, 19);
            this.passLBL.TabIndex = 5;
            this.passLBL.Text = "Password:";
            // 
            // LoginPromptLBL
            // 
            this.LoginPromptLBL.AutoSize = true;
            this.LoginPromptLBL.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPromptLBL.Location = new System.Drawing.Point(20, 79);
            this.LoginPromptLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginPromptLBL.Name = "LoginPromptLBL";
            this.LoginPromptLBL.Size = new System.Drawing.Size(373, 41);
            this.LoginPromptLBL.TabIndex = 6;
            this.LoginPromptLBL.Text = "Please Login to Continue";
            // 
            // LoginGBX
            // 
            this.LoginGBX.Controls.Add(this.cafLinkLBL);
            this.LoginGBX.Controls.Add(this.LoginPromptLBL);
            this.LoginGBX.Controls.Add(this.LoginBTN);
            this.LoginGBX.Controls.Add(this.passLBL);
            this.LoginGBX.Controls.Add(this.CancelBTN);
            this.LoginGBX.Controls.Add(this.userLBL);
            this.LoginGBX.Controls.Add(this.userResponseTBX);
            this.LoginGBX.Controls.Add(this.passwordResponseTBX);
            this.LoginGBX.Location = new System.Drawing.Point(54, 18);
            this.LoginGBX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginGBX.Name = "LoginGBX";
            this.LoginGBX.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginGBX.Size = new System.Drawing.Size(528, 336);
            this.LoginGBX.TabIndex = 7;
            this.LoginGBX.TabStop = false;
            this.LoginGBX.Text = "User Login";
            // 
            // cafLinkLBL
            // 
            this.cafLinkLBL.AutoSize = true;
            this.cafLinkLBL.Location = new System.Drawing.Point(20, 313);
            this.cafLinkLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cafLinkLBL.Name = "cafLinkLBL";
            this.cafLinkLBL.Size = new System.Drawing.Size(116, 19);
            this.cafLinkLBL.TabIndex = 7;
            this.cafLinkLBL.TabStop = true;
            this.cafLinkLBL.Text = "Create Account";
            this.cafLinkLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cafLinkLBL_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 368);
            this.Controls.Add(this.LoginGBX);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "UserLogin";
            this.LoginGBX.ResumeLayout(false);
            this.LoginGBX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.TextBox userResponseTBX;
        private System.Windows.Forms.TextBox passwordResponseTBX;
        private System.Windows.Forms.Label userLBL;
        private System.Windows.Forms.Label passLBL;
        private System.Windows.Forms.Label LoginPromptLBL;
        private System.Windows.Forms.GroupBox LoginGBX;
        private System.Windows.Forms.LinkLabel cafLinkLBL;
    }
}

