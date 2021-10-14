
namespace StoreDatabase
{
    partial class Mod_Cart
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
            this.userCartItemsTBOX = new System.Windows.Forms.TextBox();
            this.userCancelPurchase = new System.Windows.Forms.Button();
            this.userPurchaseBTN = new System.Windows.Forms.Button();
            this.userCartLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userCartItemsTBOX
            // 
            this.userCartItemsTBOX.Location = new System.Drawing.Point(103, 62);
            this.userCartItemsTBOX.Multiline = true;
            this.userCartItemsTBOX.Name = "userCartItemsTBOX";
            this.userCartItemsTBOX.Size = new System.Drawing.Size(371, 382);
            this.userCartItemsTBOX.TabIndex = 9;
            // 
            // userCancelPurchase
            // 
            this.userCancelPurchase.Location = new System.Drawing.Point(322, 463);
            this.userCancelPurchase.Name = "userCancelPurchase";
            this.userCancelPurchase.Size = new System.Drawing.Size(152, 32);
            this.userCancelPurchase.TabIndex = 8;
            this.userCancelPurchase.Text = "Cancel";
            this.userCancelPurchase.UseMnemonic = false;
            this.userCancelPurchase.UseVisualStyleBackColor = true;
            // 
            // userPurchaseBTN
            // 
            this.userPurchaseBTN.Location = new System.Drawing.Point(103, 463);
            this.userPurchaseBTN.Name = "userPurchaseBTN";
            this.userPurchaseBTN.Size = new System.Drawing.Size(152, 32);
            this.userPurchaseBTN.TabIndex = 7;
            this.userPurchaseBTN.Text = "Confirm Changes";
            this.userPurchaseBTN.UseVisualStyleBackColor = true;
            // 
            // userCartLBL
            // 
            this.userCartLBL.AutoSize = true;
            this.userCartLBL.Location = new System.Drawing.Point(99, 26);
            this.userCartLBL.Name = "userCartLBL";
            this.userCartLBL.Size = new System.Drawing.Size(295, 20);
            this.userCartLBL.TabIndex = 6;
            this.userCartLBL.Text = "Here are the following things in your cart:";
            // 
            // Mod_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 529);
            this.Controls.Add(this.userCartItemsTBOX);
            this.Controls.Add(this.userCancelPurchase);
            this.Controls.Add(this.userPurchaseBTN);
            this.Controls.Add(this.userCartLBL);
            this.Name = "Mod_Cart";
            this.Text = "Mod_Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userCartItemsTBOX;
        private System.Windows.Forms.Button userCancelPurchase;
        private System.Windows.Forms.Button userPurchaseBTN;
        private System.Windows.Forms.Label userCartLBL;
    }
}