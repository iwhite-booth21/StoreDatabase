namespace StoreDatabase
{
    partial class CreateDepartment
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
            this.DNameRspTBOX = new System.Windows.Forms.TextBox();
            this.StoreSectRspTBOX = new System.Windows.Forms.TextBox();
            this.DManRspTBOX = new System.Windows.Forms.TextBox();
            this.NumEmpRspTBOX = new System.Windows.Forms.TextBox();
            this.DnameLBL = new System.Windows.Forms.Label();
            this.DManLBL = new System.Windows.Forms.Label();
            this.StoreSectLBL = new System.Windows.Forms.Label();
            this.NumEmpLBL = new System.Windows.Forms.Label();
            this.SubDeptBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.ModDeptLnk = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // DNameRspTBOX
            // 
            this.DNameRspTBOX.Location = new System.Drawing.Point(246, 54);
            this.DNameRspTBOX.Name = "DNameRspTBOX";
            this.DNameRspTBOX.Size = new System.Drawing.Size(216, 26);
            this.DNameRspTBOX.TabIndex = 0;
            // 
            // StoreSectRspTBOX
            // 
            this.StoreSectRspTBOX.Location = new System.Drawing.Point(246, 146);
            this.StoreSectRspTBOX.Name = "StoreSectRspTBOX";
            this.StoreSectRspTBOX.Size = new System.Drawing.Size(216, 26);
            this.StoreSectRspTBOX.TabIndex = 1;
            // 
            // DManRspTBOX
            // 
            this.DManRspTBOX.Location = new System.Drawing.Point(246, 97);
            this.DManRspTBOX.Name = "DManRspTBOX";
            this.DManRspTBOX.Size = new System.Drawing.Size(216, 26);
            this.DManRspTBOX.TabIndex = 2;
            // 
            // NumEmpRspTBOX
            // 
            this.NumEmpRspTBOX.Location = new System.Drawing.Point(246, 188);
            this.NumEmpRspTBOX.Name = "NumEmpRspTBOX";
            this.NumEmpRspTBOX.Size = new System.Drawing.Size(216, 26);
            this.NumEmpRspTBOX.TabIndex = 3;
            // 
            // DnameLBL
            // 
            this.DnameLBL.AutoSize = true;
            this.DnameLBL.Location = new System.Drawing.Point(37, 54);
            this.DnameLBL.Name = "DnameLBL";
            this.DnameLBL.Size = new System.Drawing.Size(144, 20);
            this.DnameLBL.TabIndex = 4;
            this.DnameLBL.Text = "Department Name:";
            // 
            // DManLBL
            // 
            this.DManLBL.AutoSize = true;
            this.DManLBL.Location = new System.Drawing.Point(37, 103);
            this.DManLBL.Name = "DManLBL";
            this.DManLBL.Size = new System.Drawing.Size(165, 20);
            this.DManLBL.TabIndex = 5;
            this.DManLBL.Text = "Department Manager:";
            // 
            // StoreSectLBL
            // 
            this.StoreSectLBL.AutoSize = true;
            this.StoreSectLBL.Location = new System.Drawing.Point(37, 152);
            this.StoreSectLBL.Name = "StoreSectLBL";
            this.StoreSectLBL.Size = new System.Drawing.Size(110, 20);
            this.StoreSectLBL.TabIndex = 6;
            this.StoreSectLBL.Text = "Store Section:";
            // 
            // NumEmpLBL
            // 
            this.NumEmpLBL.AutoSize = true;
            this.NumEmpLBL.Location = new System.Drawing.Point(37, 191);
            this.NumEmpLBL.Name = "NumEmpLBL";
            this.NumEmpLBL.Size = new System.Drawing.Size(167, 20);
            this.NumEmpLBL.TabIndex = 7;
            this.NumEmpLBL.Text = "Number of employees:";
            // 
            // SubDeptBTN
            // 
            this.SubDeptBTN.Location = new System.Drawing.Point(41, 274);
            this.SubDeptBTN.Name = "SubDeptBTN";
            this.SubDeptBTN.Size = new System.Drawing.Size(173, 29);
            this.SubDeptBTN.TabIndex = 8;
            this.SubDeptBTN.Text = "Submit Department";
            this.SubDeptBTN.UseVisualStyleBackColor = true;
            this.SubDeptBTN.Click += new System.EventHandler(this.SubDeptBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(270, 274);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(140, 29);
            this.CancelBTN.TabIndex = 9;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModDeptLnk
            // 
            this.ModDeptLnk.AutoSize = true;
            this.ModDeptLnk.Location = new System.Drawing.Point(142, 236);
            this.ModDeptLnk.Name = "ModDeptLnk";
            this.ModDeptLnk.Size = new System.Drawing.Size(212, 20);
            this.ModDeptLnk.TabIndex = 10;
            this.ModDeptLnk.TabStop = true;
            this.ModDeptLnk.Text = "Modify Existing Department?";
            this.ModDeptLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 356);
            this.Controls.Add(this.ModDeptLnk);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SubDeptBTN);
            this.Controls.Add(this.NumEmpLBL);
            this.Controls.Add(this.StoreSectLBL);
            this.Controls.Add(this.DManLBL);
            this.Controls.Add(this.DnameLBL);
            this.Controls.Add(this.NumEmpRspTBOX);
            this.Controls.Add(this.DManRspTBOX);
            this.Controls.Add(this.StoreSectRspTBOX);
            this.Controls.Add(this.DNameRspTBOX);
            this.Name = "CreateDepartment";
            this.Text = "Create A New Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DNameRspTBOX;
        private System.Windows.Forms.TextBox StoreSectRspTBOX;
        private System.Windows.Forms.TextBox DManRspTBOX;
        private System.Windows.Forms.TextBox NumEmpRspTBOX;
        private System.Windows.Forms.Label DnameLBL;
        private System.Windows.Forms.Label DManLBL;
        private System.Windows.Forms.Label StoreSectLBL;
        private System.Windows.Forms.Label NumEmpLBL;
        private System.Windows.Forms.Button SubDeptBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.LinkLabel ModDeptLnk;
    }
}