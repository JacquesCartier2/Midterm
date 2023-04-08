
namespace Midterm
{
    partial class Account
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
            this.AccountLabel = new System.Windows.Forms.Label();
            this.txt_AccountInput = new System.Windows.Forms.TextBox();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountLabel.Location = new System.Drawing.Point(12, 9);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(323, 19);
            this.AccountLabel.TabIndex = 0;
            this.AccountLabel.Text = "(placeholder)*Account type* Account Balance: $$$$";
            // 
            // txt_AccountInput
            // 
            this.txt_AccountInput.Location = new System.Drawing.Point(12, 45);
            this.txt_AccountInput.Name = "txt_AccountInput";
            this.txt_AccountInput.Size = new System.Drawing.Size(500, 23);
            this.txt_AccountInput.TabIndex = 1;
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Withdraw.Location = new System.Drawing.Point(162, 92);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(194, 44);
            this.btn_Withdraw.TabIndex = 2;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Deposit.Location = new System.Drawing.Point(162, 142);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(194, 44);
            this.btn_Deposit.TabIndex = 3;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Transfer.Location = new System.Drawing.Point(162, 192);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(194, 44);
            this.btn_Transfer.TabIndex = 4;
            this.btn_Transfer.Text = "Transfer";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Back.Location = new System.Drawing.Point(162, 242);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(194, 44);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 298);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.txt_AccountInput);
            this.Controls.Add(this.AccountLabel);
            this.Name = "Account";
            this.Text = "Account";
            this.Shown += new System.EventHandler(this.Account_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.TextBox txt_AccountInput;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Button btn_Back;
    }
}