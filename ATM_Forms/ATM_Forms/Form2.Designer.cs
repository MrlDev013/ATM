namespace ATM_Forms
{
    partial class Form2
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
            this.txt_NameRegister = new System.Windows.Forms.TextBox();
            this.txt_IDRegister = new System.Windows.Forms.TextBox();
            this.txt_PasswordRegister = new System.Windows.Forms.TextBox();
            this.txt_AddressRegister = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SubmitRegister = new System.Windows.Forms.Button();
            this.btn_CleanRegister = new System.Windows.Forms.Button();
            this.btn_BackRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NameRegister
            // 
            this.txt_NameRegister.Location = new System.Drawing.Point(66, 30);
            this.txt_NameRegister.Name = "txt_NameRegister";
            this.txt_NameRegister.Size = new System.Drawing.Size(198, 23);
            this.txt_NameRegister.TabIndex = 0;
            // 
            // txt_IDRegister
            // 
            this.txt_IDRegister.Location = new System.Drawing.Point(66, 72);
            this.txt_IDRegister.Name = "txt_IDRegister";
            this.txt_IDRegister.Size = new System.Drawing.Size(198, 23);
            this.txt_IDRegister.TabIndex = 1;
            // 
            // txt_PasswordRegister
            // 
            this.txt_PasswordRegister.Location = new System.Drawing.Point(66, 116);
            this.txt_PasswordRegister.Name = "txt_PasswordRegister";
            this.txt_PasswordRegister.Size = new System.Drawing.Size(198, 23);
            this.txt_PasswordRegister.TabIndex = 2;
            // 
            // txt_AddressRegister
            // 
            this.txt_AddressRegister.Location = new System.Drawing.Point(66, 160);
            this.txt_AddressRegister.Name = "txt_AddressRegister";
            this.txt_AddressRegister.Size = new System.Drawing.Size(198, 23);
            this.txt_AddressRegister.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address:";
            // 
            // btn_SubmitRegister
            // 
            this.btn_SubmitRegister.Location = new System.Drawing.Point(105, 206);
            this.btn_SubmitRegister.Name = "btn_SubmitRegister";
            this.btn_SubmitRegister.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitRegister.TabIndex = 8;
            this.btn_SubmitRegister.Text = "Submit";
            this.btn_SubmitRegister.UseVisualStyleBackColor = true;
            this.btn_SubmitRegister.Click += new System.EventHandler(this.btn_SubmitRegister_Click);
            // 
            // btn_CleanRegister
            // 
            this.btn_CleanRegister.Location = new System.Drawing.Point(105, 238);
            this.btn_CleanRegister.Name = "btn_CleanRegister";
            this.btn_CleanRegister.Size = new System.Drawing.Size(75, 23);
            this.btn_CleanRegister.TabIndex = 9;
            this.btn_CleanRegister.Text = "Clear";
            this.btn_CleanRegister.UseVisualStyleBackColor = true;
            this.btn_CleanRegister.Click += new System.EventHandler(this.btn_CleanRegister_Click);
            // 
            // btn_BackRegister
            // 
            this.btn_BackRegister.Location = new System.Drawing.Point(12, 219);
            this.btn_BackRegister.Name = "btn_BackRegister";
            this.btn_BackRegister.Size = new System.Drawing.Size(48, 23);
            this.btn_BackRegister.TabIndex = 10;
            this.btn_BackRegister.Text = "Back";
            this.btn_BackRegister.UseVisualStyleBackColor = true;
            this.btn_BackRegister.Click += new System.EventHandler(this.btn_BackRegister_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 273);
            this.Controls.Add(this.btn_BackRegister);
            this.Controls.Add(this.btn_CleanRegister);
            this.Controls.Add(this.btn_SubmitRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AddressRegister);
            this.Controls.Add(this.txt_PasswordRegister);
            this.Controls.Add(this.txt_IDRegister);
            this.Controls.Add(this.txt_NameRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_NameRegister;
        private TextBox txt_IDRegister;
        private TextBox txt_PasswordRegister;
        private TextBox txt_AddressRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_SubmitRegister;
        private Button btn_CleanRegister;
        private Button btn_BackRegister;
    }
}