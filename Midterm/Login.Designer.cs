
namespace Midterm
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerNumberLabel = new System.Windows.Forms.Label();
            this.txt_CustomerNumber = new System.Windows.Forms.TextBox();
            this.PINLabel = new System.Windows.Forms.Label();
            this.txt_PIN = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerNumberLabel
            // 
            this.CustomerNumberLabel.AutoSize = true;
            this.CustomerNumberLabel.Location = new System.Drawing.Point(194, 47);
            this.CustomerNumberLabel.Name = "CustomerNumberLabel";
            this.CustomerNumberLabel.Size = new System.Drawing.Size(109, 15);
            this.CustomerNumberLabel.TabIndex = 0;
            this.CustomerNumberLabel.Text = "Customer Number:";
            // 
            // txt_CustomerNumber
            // 
            this.txt_CustomerNumber.Location = new System.Drawing.Point(178, 65);
            this.txt_CustomerNumber.Name = "txt_CustomerNumber";
            this.txt_CustomerNumber.Size = new System.Drawing.Size(137, 23);
            this.txt_CustomerNumber.TabIndex = 1;
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.Location = new System.Drawing.Point(230, 122);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(29, 15);
            this.PINLabel.TabIndex = 2;
            this.PINLabel.Text = "PIN:";
            // 
            // txt_PIN
            // 
            this.txt_PIN.Location = new System.Drawing.Point(178, 140);
            this.txt_PIN.Name = "txt_PIN";
            this.txt_PIN.Size = new System.Drawing.Size(137, 23);
            this.txt_PIN.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(208, 213);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Enter";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 303);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_PIN);
            this.Controls.Add(this.PINLabel);
            this.Controls.Add(this.txt_CustomerNumber);
            this.Controls.Add(this.CustomerNumberLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNumberLabel;
        private System.Windows.Forms.TextBox txt_CustomerNumber;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.TextBox txt_PIN;
        private System.Windows.Forms.Button btn_Login;
    }
}

