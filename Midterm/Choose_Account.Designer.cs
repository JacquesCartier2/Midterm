
namespace Midterm
{
    partial class Choose_Account
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
            this.btn_SavingsAccount = new System.Windows.Forms.Button();
            this.btn_CheckingAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SavingsAccount
            // 
            this.btn_SavingsAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SavingsAccount.Location = new System.Drawing.Point(57, 136);
            this.btn_SavingsAccount.Name = "btn_SavingsAccount";
            this.btn_SavingsAccount.Size = new System.Drawing.Size(180, 33);
            this.btn_SavingsAccount.TabIndex = 0;
            this.btn_SavingsAccount.Text = "Savings Account";
            this.btn_SavingsAccount.UseVisualStyleBackColor = true;
            this.btn_SavingsAccount.Click += new System.EventHandler(this.btn_SavingsAccount_Click);
            // 
            // btn_CheckingAccount
            // 
            this.btn_CheckingAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CheckingAccount.Location = new System.Drawing.Point(57, 44);
            this.btn_CheckingAccount.Name = "btn_CheckingAccount";
            this.btn_CheckingAccount.Size = new System.Drawing.Size(180, 33);
            this.btn_CheckingAccount.TabIndex = 1;
            this.btn_CheckingAccount.Text = "Checking Account";
            this.btn_CheckingAccount.UseVisualStyleBackColor = true;
            this.btn_CheckingAccount.Click += new System.EventHandler(this.btn_CheckingAccount_Click);
            // 
            // Choose_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 199);
            this.Controls.Add(this.btn_CheckingAccount);
            this.Controls.Add(this.btn_SavingsAccount);
            this.Name = "Choose_Account";
            this.Text = "Choose Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SavingsAccount;
        private System.Windows.Forms.Button btn_CheckingAccount;
    }
}