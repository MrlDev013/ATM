namespace ATM_Forms
{
    partial class Form1
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.lbl_AccountMainPage = new System.Windows.Forms.Label();
            this.lbl_PasswordMainPage = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(232, 50);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(326, 50);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 1;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_Account
            // 
            this.txt_Account.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Account.Location = new System.Drawing.Point(70, 32);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(146, 23);
            this.txt_Account.TabIndex = 2;
            // 
            // lbl_AccountMainPage
            // 
            this.lbl_AccountMainPage.AutoSize = true;
            this.lbl_AccountMainPage.Location = new System.Drawing.Point(4, 35);
            this.lbl_AccountMainPage.Name = "lbl_AccountMainPage";
            this.lbl_AccountMainPage.Size = new System.Drawing.Size(55, 15);
            this.lbl_AccountMainPage.TabIndex = 3;
            this.lbl_AccountMainPage.Text = "Account:";
            // 
            // lbl_PasswordMainPage
            // 
            this.lbl_PasswordMainPage.AutoSize = true;
            this.lbl_PasswordMainPage.Location = new System.Drawing.Point(4, 70);
            this.lbl_PasswordMainPage.Name = "lbl_PasswordMainPage";
            this.lbl_PasswordMainPage.Size = new System.Drawing.Size(60, 15);
            this.lbl_PasswordMainPage.TabIndex = 4;
            this.lbl_PasswordMainPage.Text = "Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(70, 67);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(146, 23);
            this.txt_Password.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 118);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_PasswordMainPage);
            this.Controls.Add(this.lbl_AccountMainPage);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Login;
        private Button btn_Register;
        private TextBox txt_Account;
        private Label lbl_AccountMainPage;
        private Label lbl_PasswordMainPage;
        private TextBox txt_Password;
    }
}