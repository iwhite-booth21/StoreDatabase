
namespace StoreDatabase
{
    partial class Cart
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
            this.userCartLBL = new System.Windows.Forms.Label();
            this.userPurchaseBTN = new System.Windows.Forms.Button();
            this.userCancelPurchase = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Mod_Cart_LNK = new System.Windows.Forms.LinkLabel();
            this.userCartItemsTBOX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userCartLBL
            // 
            this.userCartLBL.AutoSize = true;
            this.userCartLBL.Location = new System.Drawing.Point(12, 47);
            this.userCartLBL.Name = "userCartLBL";
            this.userCartLBL.Size = new System.Drawing.Size(295, 20);
            this.userCartLBL.TabIndex = 0;
            this.userCartLBL.Text = "Here are the following things in your cart:";
            // 
            // userPurchaseBTN
            // 
            this.userPurchaseBTN.Location = new System.Drawing.Point(12, 433);
            this.userPurchaseBTN.Name = "userPurchaseBTN";
            this.userPurchaseBTN.Size = new System.Drawing.Size(152, 32);
            this.userPurchaseBTN.TabIndex = 1;
            this.userPurchaseBTN.Text = "Confirm Purchase";
            this.userPurchaseBTN.UseVisualStyleBackColor = true;
            // 
            // userCancelPurchase
            // 
            this.userCancelPurchase.Location = new System.Drawing.Point(231, 433);
            this.userCancelPurchase.Name = "userCancelPurchase";
            this.userCancelPurchase.Size = new System.Drawing.Size(152, 32);
            this.userCancelPurchase.TabIndex = 2;
            this.userCancelPurchase.Text = "Cancel";
            this.userCancelPurchase.UseMnemonic = false;
            this.userCancelPurchase.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // Mod_Cart_LNK
            // 
            this.Mod_Cart_LNK.AutoSize = true;
            this.Mod_Cart_LNK.Location = new System.Drawing.Point(104, 392);
            this.Mod_Cart_LNK.Name = "Mod_Cart_LNK";
            this.Mod_Cart_LNK.Size = new System.Drawing.Size(203, 20);
            this.Mod_Cart_LNK.TabIndex = 5;
            this.Mod_Cart_LNK.TabStop = true;
            this.Mod_Cart_LNK.Text = "Unsure? Change Cart Here";
            // 
            // userCartItemsTBOX
            // 
            this.userCartItemsTBOX.Location = new System.Drawing.Point(12, 91);
            this.userCartItemsTBOX.Multiline = true;
            this.userCartItemsTBOX.Name = "userCartItemsTBOX";
            this.userCartItemsTBOX.Size = new System.Drawing.Size(371, 278);
            this.userCartItemsTBOX.TabIndex = 3;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 518);
            this.Controls.Add(this.Mod_Cart_LNK);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.userCartItemsTBOX);
            this.Controls.Add(this.userCancelPurchase);
            this.Controls.Add(this.userPurchaseBTN);
            this.Controls.Add(this.userCartLBL);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userCartLBL;
        private System.Windows.Forms.Button userPurchaseBTN;
        private System.Windows.Forms.Button userCancelPurchase;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel Mod_Cart_LNK;
        private System.Windows.Forms.TextBox userCartItemsTBOX;
    }
}